﻿using System;
using System.Windows.Forms;
using System.Threading;
using Woodpecker;

namespace Woodpecker
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //高Dpi設定
            if (Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Thread to show splash window
            Thread thUI = new Thread(new ThreadStart(ShowSplashWindow))
            {
                Name = "Splash UI",
                Priority = ThreadPriority.Highest,
                IsBackground = true
            };
            thUI.Start();

            //Thread to load time-consuming resources.
            Thread th = new Thread(new ThreadStart(LoadResources))
            {
                Name = "Resource Loader",
                Priority = ThreadPriority.Normal
            };
            th.Start();
            th.Join();
            
            if (SplashForm != null)
            {
                SplashForm.Invoke(new MethodInvoker(delegate { SplashForm.Close(); }));
            }
            thUI.Join();
            if (args.Length == 0)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Form1(args[0].ToString()));
            }
        }

        public static frm_Splash SplashForm
        {
            get;
            set;
        }

        private static void LoadResources()
        {
            for (int i = 1; i <= 10; i++)
            {
                /*if (SplashForm != null)
                {SplashForm.Invoke(new MethodInvoker(delegate 
                        {SplashForm.labelMark.Text = "Spider";}));}*/
                Thread.Sleep(100);
            }
            
            Add_ons Add_ons = new Add_ons();
            Add_ons.CreateConfig();//如果根目錄沒有Config.ini則創建//
            Add_ons.USB_Read();//讀取USB設備的Pid, Vid//

            //Add_ons.CreateExcelFile();
        }

        private static void ShowSplashWindow()
        {
            SplashForm = new frm_Splash();
            Application.Run(SplashForm);
        }
    }
}
