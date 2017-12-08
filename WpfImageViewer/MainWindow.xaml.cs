using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfImageViewer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// このウィンドウに関連付けられたビューモデルを取得します。
        /// </summary>
        public MainWindowViewModel Model
        {
            get { return DataContext as MainWindowViewModel; }
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            // ViewModelに委譲する
            this.Model.OpenDirectory();
        }
    }
}
