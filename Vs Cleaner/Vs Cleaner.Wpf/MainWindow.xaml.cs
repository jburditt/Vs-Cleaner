using System.Windows;
using System.Windows.Forms;

namespace Vs_Cleaner.Wpf
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

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    projectFolderPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void cleanProjectButton_Click(object sender, RoutedEventArgs e)
        {
            Program.CleanFolder(projectFolderPath.Text);
        }
    }
}
