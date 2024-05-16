using System.Windows;

namespace JulesFerryApp
{
    public partial class ComingSoonWindow : Window
    {
        public ComingSoonWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
