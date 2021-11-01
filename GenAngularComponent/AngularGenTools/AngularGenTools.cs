using AngularGenTools.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngularGenTools
{
    public partial class AngularGenTools : Form
    {
        private readonly string templatePath = @"D:\Test";
        private readonly string templateTreeview = @"D:\Hoa";
        //string strFiles = "";
        StringBuilder strFiles = new StringBuilder();
        public AngularGenTools()
        {
            InitializeComponent();
        }

        public bool LoadDirectory(string dirPath)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);
                //Setting ProgressBar Maximum Value
                progressBarGen.Maximum = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(dirPath, "**", SearchOption.AllDirectories).Length;
                TreeNode treeNode = treeViewFile.Nodes.Add(di.Name);
                treeNode.Tag = di.FullName;
                treeNode.StateImageIndex = 0;
                LoadFiles(dirPath, treeNode);
                LoadSubDirectories(dirPath, treeNode);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void WriteAFile(string filePath, string[] lines)
        {
            using (StreamWriter file = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                     file.WriteLine(line);
                }
            }
        }

        private string BrowserFile(string pathFile)
        {
            //1. validate
            //1.1 if folder return blank
            if (Directory.Exists(pathFile))
            {
                return "";
            }
            StringBuilder results = new StringBuilder();

            string[] lines = File.ReadAllLines(pathFile);

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                results.Append("\t").Append(line);
            }

            return results.ToString();
        }

        private void desOpenBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                destinationTxt.Text = diag.SelectedPath;
                MessageBox.Show(diag.SelectedPath);
            }
        }

        private void destinationTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private string DirectorySearchNameFilesAsync(string path, int levelNode = 0)
        {

            //string strFiles = "";
            try
            {
                string[] allfiles = Directory.GetFileSystemEntries(path, "*");
                foreach (string file in allfiles)
                {
                    //1. add tab to easy to view
                    string tab = new String('\t', levelNode);

                    strFiles = strFiles.Append("\n").Append(tab).Append(Path.GetFileName(file));
                    //strFiles = strFiles + "\n" + tab + Path.GetFileName(file);
                    if (!Directory.Exists(file))
                    {


                        string filePath = Path.GetFullPath(file);
                        //2. read a file from template
                        string[] lines = ReadAfile(filePath);

                        //3. write file to destination path
                        string replacedText=file.Replace(sourceTxt.Text, "");
                        string desFilePath = destinationTxt.Text + replacedText;
                         WriteAFile(desFilePath, lines);
                        //BrowserFile(filePath);


                    }
                    else
                    {
                        //4. create folder
                        string newFolder = Path.Combine(destinationTxt.Text, Path.GetFileName(file));
                        Directory.CreateDirectory(newFolder);
                        DirectorySearchNameFilesAsync(file, levelNode+1);
                    }
                }

                return strFiles.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return strFiles.ToString();
            }
        }

        private string DirectorySearchNameFiles(string path, int levelNode = 0)
        {
            string strFiles = "";
            string strTotal = "";
            //StringBuilder strFiles = new StringBuilder();
            try
            {
                string[] allfiles = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
                foreach (string f in allfiles)
                {
                    // add tab  

                    string tab = new String('\t', levelNode);
                    strFiles = strFiles + "\n " + tab + Path.GetFileName(f);
                    string filePath = Path.GetFullPath(f);
                    //BrowserFile(filePath);

                    if (Directory.Exists(f))
                    {
                        //strDirs = strDirs + "\n " + Path.GetFileName(f);
                        //Console.WriteLine(Path.GetFileName(d));
                        levelNode = levelNode + 1;
                        DirectorySearchNameFiles(f, levelNode);
                    }
                    //Console.WriteLine(Path.GetFileName(f));
                }

                strTotal = strFiles;
                return strTotal;
            }
            catch (Exception ex)
            {
                return strTotal;
            }
        }

        private async void genBtn_Click(object sender, EventArgs e)
        {
            //1. validate
            string sourcePath = sourceTxt.Text.ToString();
            string desPath = destinationTxt.Text.ToString();

            if (ValidateString.IsNullOrBlank(sourcePath))
            {
                MessageBox.Show("Source Path not allowed empty!");
                return;
            }
            else if (ValidateString.IsNullOrBlank(desPath))
            {
                MessageBox.Show("Destination Path not allowed empty!");
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Please choose a folder");
            }
            //1. Get template

            //1.1 read files from template source
            //DirectoryInfo d = new DirectoryInfo(@"D:\Test"); //Assuming Test is your Folder

            //FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            //string str = "";

            //foreach (FileInfo file in Files)
            //{
            //    str = str + "\n " + file.Name;

            //}
            string testFileContent = @"D:\test\text1.txt";
            richTextBoxTest.Text = DirectorySearchNameFilesAsync(sourcePath);
            //richTextBoxTest.Text = DirectorySearchNameFiles(templatePath);

            fileContent.Text = BrowserFile(testFileContent);

            //1.1 show treeview

            // Setting Inital Value of Progress Bar
            // Clear All Nodes if Already Exists
            treeViewFile.Nodes.Clear();
            progressBarGen.Visible = true;
            if (LoadDirectory(sourcePath))
            {
                Thread.Sleep(500);
                progressBarGen.Value = 0;
                genCompleted.Visible = true;
            }
            progressBarGen.Visible = false;
            //2. Gen Project structure

            //3. Gen Details

            //4. Inform Gen success
            //MessageBox.Show("Gen Angular Project Success");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void LoadFiles(string dir, TreeNode treeNodeParam)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files
            foreach (string file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TreeNode treeNode = treeNodeParam.Nodes.Add(fileInfo.Name);
                treeNode.Tag = fileInfo.FullName;
                treeNode.StateImageIndex = 1;
                UpdateProgress();
            }
        }

        private void LoadSubDirectories(string dirPath, TreeNode td)
        {
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dirPath);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo dir = new DirectoryInfo(subdirectory);
                TreeNode treeNode = td.Nodes.Add(dir.Name);
                treeNode.StateImageIndex = 0;
                treeNode.Tag = dir.FullName;
                LoadFiles(subdirectory, treeNode);
                LoadSubDirectories(subdirectory, treeNode);
                UpdateProgress();
            }
        }

        private void previewGenProjectBtn_Click(object sender, EventArgs e)
        {
            //1. Get template

            //2. Show template
        }

        private string[] ReadAfile(string pathFile)
        {
            //1. validate
            //1.1 if folder return blank
            if (Directory.Exists(pathFile))
            {
                return new String[] { };
            }

            string[] lines = File.ReadAllLines(pathFile);

            return lines;
        }

        private void richTextBoxTest_TextChanged(object sender, EventArgs e)
        {
        }

        private void sourceOpenBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                sourceTxt.Text = diag.SelectedPath;
                MessageBox.Show(diag.SelectedPath);
            }
        }

        /// <summary>
        /// Preview details each file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewFile_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //1. get seleted file
            string pathOfSelectedNode = treeViewFile.SelectedNode.Tag.ToString();

            //2. show content fo the selected file


            fileContent.Text = BrowserFile(pathOfSelectedNode);
        }

        private void UpdateProgress()
        {
            if (progressBarGen.Value < progressBarGen.Maximum)
            {
                progressBarGen.Value++;
                int percent = (int)(((double)progressBarGen.Value / (double)progressBarGen.Maximum) * 100);
                progressBarGen.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBarGen.Width / 2 - 10, progressBarGen.Height / 2 - 7));

                Application.DoEvents();
            }
        }
    }
}