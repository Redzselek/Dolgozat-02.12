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
using System.IO;
using Microsoft.Win32;


namespace Dolgozat_02._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HozzaAd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                VersSzoveg.Text = File.ReadAllText(openFileDialog.FileName);
            openFileDialog.Filter = "Text files (*.txt)|*.txt|";
            openFileDialog.InitialDirectory = "H:\\C#2023\\Dolgozat 02.12\\Dolgozat 02.12\\Versek\\";
        }

        private void UjVers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Elolvas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
