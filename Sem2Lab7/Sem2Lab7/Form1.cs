using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2Lab7
{
    public partial class Form1 : Form
    {
        private const string path = @"C:\Users\Никита\source\papka";

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateFolders_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            for (int i = 0; i < 100; i++)
            {
                dir.CreateSubdirectory($"Folder_{i}");
            }
            MessageBox.Show("Ok");
        }

        private void CreateSubfolders_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            int max = Int32.MaxValue;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    dir.CreateSubdirectory($"Folder_{i}");
                    dir = new DirectoryInfo(dir.FullName + $"\\Folder_{i}");
                }
                catch (PathTooLongException)
                {
                    max = i + 1;
                    break;
                }
            }
            MessageBox.Show("Ok");
            MessageBox.Show($"Max: {max + 1}");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (var folder in dir.GetDirectories())
            {
                folder.Delete(true);
            }
            MessageBox.Show("Deleted");
        }

        private void SearchAndOpen_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
    }
}
