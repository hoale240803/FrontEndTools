using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AngularGenTools
{
    public partial class AngularGenTools : Form
    {
        private readonly string templatePath = @"D:\Test";
        private readonly string templateTreeview = @"D:\Hoa";
        

        public AngularGenTools()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void sourceOpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text files|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader read = new StreamReader(ofd.FileName))
                    {
                        while (true)
                        {
                            string line = read.ReadLine();
                            if (line == null)
                                break;
                            richTextBoxTest.Text = line;
                        }
                    }
                }
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            // validate
            //string sourcePath = sourceTxt.Text.ToString();

            //if (ValidateString.IsNullOrBlank(sourcePath))
            //{
            //    MessageBox.Show("Source Path not allowed empty!");
            //}
            //string desPath = destinationTxt.Text.ToString();

            //if (ValidateString.IsNullOrBlank(desPath))
            //{
            //    MessageBox.Show("Destination Path not allowed empty!");
            //}
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
            richTextBoxTest.Text = DirectorySearchNameFiles(templatePath);
            fileContent.Text = BrowserFile(testFileContent);

            //1.1 show treeview

            // Setting Inital Value of Progress Bar
            // Clear All Nodes if Already Exists
            treeViewFile.Nodes.Clear();
            if (LoadDirectory(templateTreeview))
            {
                Thread.Sleep(500);
                progressBarGen.Value = 0;
                genCompleted.Visible = true;
            }
            

            //2. Gen Project structure

            //3. Gen Details

            //4. Inform Gen success
            //MessageBox.Show("Gen Angular Project Success");
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

        private void previewGenProjectBtn_Click(object sender, EventArgs e)
        {
            //1. Get template

            //2. Show template
        }

        private void desOpenBtn_Click(object sender, EventArgs e)
        {
            //1. open dialog
            //2. get the des path value
            //3 validate
        }

        private void destinationTxt_TextChanged(object sender, EventArgs e)
        {
        }

        public static string DirectorySearchNameFiles(string path, int levelNode = 0)
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
                Console.WriteLine(ex.Message);
                return strTotal;
            }
        }

        public static string BrowserFile(string pathFile)
        {
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

        private void richTextBoxTest_TextChanged(object sender, EventArgs e)
        {
        }
    }
}