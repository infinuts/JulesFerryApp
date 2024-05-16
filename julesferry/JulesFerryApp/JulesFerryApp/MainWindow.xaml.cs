using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace JulesFerryApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var comingSoonWindow = new ComingSoonWindow();
            comingSoonWindow.Show();
            this.Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            var comingSoonWindow = new ComingSoonWindow();
            comingSoonWindow.Show();
            this.Close();
        }

        private void GoToWebsiteButton_Click(object sender, RoutedEventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(currentDirectory, "Website.html");

            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Website.html not found!");
            }
        }
    }
}
