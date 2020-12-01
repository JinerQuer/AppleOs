using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppleOs.Test
{
    /// <summary>
    /// MainTestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainTestWindow : Window
    {
        public MainTestWindow()
        {
            InitializeComponent();
        }

        private void Window_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Minimized(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Maximized(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }
    }
}
