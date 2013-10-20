using System;
using System.Collections.Generic;
using System.IO;
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

namespace MoveFolder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveFolder(object sender, RoutedEventArgs e)
        {
            string SourceDir = GetSourceDir();
            string DestDir = GetDestDir();
            if (!Directory.Exists(SourceDir))
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            if (Directory.Exists(DestDir))
            {
                Directory.Delete(DestDir, true);
            }
            try
            {
                DirectoryCopy(SourceDir, DestDir, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            MessageBox.Show("sucessed!");
        }

        private string GetDestDir()
        {
            string a = @"I:\Users\jamesyang\Desktop\F2\XML";
            return a;
        }

        private string GetSourceDir()
        {
            string a = @"I:\Users\jamesyang\Desktop\F1\XML";
            return a;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = System.IO.Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = System.IO.Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
