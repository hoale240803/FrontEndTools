using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AngularGenTools
{
    public partial class AngularGenTools : Form
    {
        private readonly string templatePath = @"D:\Test";

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

            //2. Gen Project structure

            //3. Gen Details

            //4. Inform Gen success
            //MessageBox.Show("Gen Angular Project Success");
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