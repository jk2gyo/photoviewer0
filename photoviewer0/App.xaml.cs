using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace photoviewer0
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private string[] _supportExts = { ".jpg", ".bmp", ".png", ".tiff", ".gif" };
        /// <summary>
        /// アプリケーションでサポートするファイルの拡張子を取得する。
        /// </summary>
        public string[] SupportExts
        {
            get { return _supportExts; }
        }

        /// <summary>
        /// 現在のAppクラスのインスタンスを取得する
        /// </summary>
        public static new App Current
        {
            get { return Application.Current as App; }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // モダンな見た目にするために、ここで呼び出しておく。
            System.Windows.Forms.Application.EnableVisualStyles();
        }
    }
}
