﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace EarthLiveSharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists(@"trace.log"))
            {
                File.Delete(@"trace.log");
            }
            Trace.Listeners.Add(new TextWriterTraceListener("trace.log"));
            Trace.AutoFlush = true;

            try
            {
                Cfg.load();
            }
            catch
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
    public class scraper
    {
        public static string latest_address = "";
        public static string saved_address = "";
        private static string image_folder = @".\\images\\";
        private static int image_cnt = 0;
        private static int max_number = 5;
        public static string json_url = "http://himawari8.nict.go.jp/img/D531106/latest.json";
        public static string pic_url = "";
        public static string GetLatestAddress()
        {
            HttpWebRequest request = WebRequest.Create(json_url) as HttpWebRequest;
            try 
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String date = reader.ReadToEnd().Substring(9,19);           
                String date_formated = date.Replace("-", "/").Replace(" ", "/").Replace(":", "");
                latest_address = pic_url + date_formated + "_0_0.png";
                Trace.WriteLine("[get latest address] " + date);
                response.Close();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
            finally
            {
                ;
            }
            return latest_address;
        }

        public static void SaveImage()
        {
            String image_path = image_folder + image_cnt.ToString() + ".png";
            //if(File.Exists(image_path))
            //{
            //    File.Delete(image_path + image_cnt.ToString() + ".png");
            //}
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(latest_address, image_path);
                Trace.WriteLine("[save image] " + latest_address + " > " + image_path);
                if (Directory.GetFiles(image_folder, "*.png").Length == 1)
                {
                    File.Copy(image_path, image_folder + "1.png", true);
                }
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
            }
            finally
            {
                client.Dispose();
            }
            image_cnt = (image_cnt + 1) % max_number;
        }

        public static void InitFolder()
        {
            if(Directory.Exists(image_folder))
            {
                // delete all images in the image folder.
                //string[] files = Directory.GetFiles(image_folder);
                //foreach (string fn in files)
                //{
                //    File.Delete(fn);
                //}
            }
            else
            {
                Trace.WriteLine("[create folder]");
                Directory.CreateDirectory(image_folder);
            }
        }
        public static void UpdateImage()
        {
            GetLatestAddress();
            if(latest_address.Equals(saved_address))
            {
                return;
            }
            else
            {
                SaveImage();
                saved_address = latest_address;
            }
        }
    }

    public class Cfg
    {
        public static string version;
        public static string orgin_addr;
        public static string cdn_addr;
        public static string source_select;
        public static int interval;
        public static int max_number;
        public static bool autostart;

        public static void load()
        {
            try
            {
                ExeConfigurationFileMap map = new ExeConfigurationFileMap();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection app = config.AppSettings;
                version = app.Settings["version"].Value;
                orgin_addr = app.Settings["orgin"].Value;
                cdn_addr = app.Settings["cdn"].Value;
                source_select = app.Settings["source_select"].Value;
                interval = Convert.ToInt32(app.Settings["interval"].Value);
                max_number = Convert.ToInt32(app.Settings["max_number"].Value);
                autostart = Convert.ToBoolean(app.Settings["autostart"].Value);
                return;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                MessageBox.Show("Configure error!");
                throw (e);
            }
        }
        public static void commit()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            //app.Settings["orgin"].Value = orgin_addr;
            //app.Settings["cdn"].Value = cdn_addr;
            app.Settings["source_select"].Value = source_select;
            app.Settings["interval"].Value = interval.ToString();
            app.Settings["max_number"].Value = max_number.ToString();
            app.Settings["autostart"].Value = autostart.ToString();
            config.Save();
            return;
        }
    }
}