
namespace AngularGenTools
{
    partial class AngularGenTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.sourceTxt = new System.Windows.Forms.TextBox();
            this.destinationTxt = new System.Windows.Forms.TextBox();
            this.genProjectTxt = new System.Windows.Forms.Label();
            this.projectTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileContent = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTest = new System.Windows.Forms.RichTextBox();
            this.projectType = new System.Windows.Forms.ComboBox();
            this.desOpenBtn = new System.Windows.Forms.Button();
            this.sourceOpenBtn = new System.Windows.Forms.Button();
            this.previewGenProjectBtn = new System.Windows.Forms.Button();
            this.destinationLbl = new System.Windows.Forms.Label();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.desOpenCompBtn = new System.Windows.Forms.Button();
            this.sourceOpenCompBtn = new System.Windows.Forms.Button();
            this.previewGenCompBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceGenCompLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.genComponentLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.treeViewFile = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarGen = new System.Windows.Forms.ProgressBar();
            this.genCompleted = new System.Windows.Forms.Label();
            this.projectTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(353, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(90, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Angular Gen Tool";
            this.titleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.Green;
            this.genBtn.ForeColor = System.Drawing.Color.Ivory;
            this.genBtn.Location = new System.Drawing.Point(273, 636);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(251, 76);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Gen";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // sourceTxt
            // 
            this.sourceTxt.Location = new System.Drawing.Point(60, 77);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(100, 20);
            this.sourceTxt.TabIndex = 2;
            // 
            // destinationTxt
            // 
            this.destinationTxt.Location = new System.Drawing.Point(60, 139);
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.Size = new System.Drawing.Size(100, 20);
            this.destinationTxt.TabIndex = 3;
            this.destinationTxt.TextChanged += new System.EventHandler(this.destinationTxt_TextChanged);
            // 
            // genProjectTxt
            // 
            this.genProjectTxt.AutoSize = true;
            this.genProjectTxt.Location = new System.Drawing.Point(337, 21);
            this.genProjectTxt.Name = "genProjectTxt";
            this.genProjectTxt.Size = new System.Drawing.Size(63, 13);
            this.genProjectTxt.TabIndex = 4;
            this.genProjectTxt.Text = "Gen Project";
            // 
            // projectTab
            // 
            this.projectTab.Controls.Add(this.tabPage1);
            this.projectTab.Controls.Add(this.tabPage2);
            this.projectTab.Location = new System.Drawing.Point(12, 53);
            this.projectTab.Name = "projectTab";
            this.projectTab.SelectedIndex = 0;
            this.projectTab.Size = new System.Drawing.Size(776, 577);
            this.projectTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.genCompleted);
            this.tabPage1.Controls.Add(this.progressBarGen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.treeViewFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.fileContent);
            this.tabPage1.Controls.Add(this.richTextBoxTest);
            this.tabPage1.Controls.Add(this.projectType);
            this.tabPage1.Controls.Add(this.desOpenBtn);
            this.tabPage1.Controls.Add(this.sourceOpenBtn);
            this.tabPage1.Controls.Add(this.previewGenProjectBtn);
            this.tabPage1.Controls.Add(this.destinationLbl);
            this.tabPage1.Controls.Add(this.sourceLbl);
            this.tabPage1.Controls.Add(this.sourceTxt);
            this.tabPage1.Controls.Add(this.genProjectTxt);
            this.tabPage1.Controls.Add(this.destinationTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gen Project Template";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "FileContent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "TreeView";
            // 
            // fileContent
            // 
            this.fileContent.Location = new System.Drawing.Point(518, 73);
            this.fileContent.Name = "fileContent";
            this.fileContent.Size = new System.Drawing.Size(175, 196);
            this.fileContent.TabIndex = 13;
            this.fileContent.Text = "";
            // 
            // richTextBoxTest
            // 
            this.richTextBoxTest.Location = new System.Drawing.Point(327, 75);
            this.richTextBoxTest.Name = "richTextBoxTest";
            this.richTextBoxTest.Size = new System.Drawing.Size(168, 196);
            this.richTextBoxTest.TabIndex = 12;
            this.richTextBoxTest.Text = "";
            this.richTextBoxTest.TextChanged += new System.EventHandler(this.richTextBoxTest_TextChanged);
            // 
            // projectType
            // 
            this.projectType.FormattingEnabled = true;
            this.projectType.Location = new System.Drawing.Point(18, 188);
            this.projectType.Name = "projectType";
            this.projectType.Size = new System.Drawing.Size(121, 21);
            this.projectType.TabIndex = 10;
            // 
            // desOpenBtn
            // 
            this.desOpenBtn.Location = new System.Drawing.Point(184, 139);
            this.desOpenBtn.Name = "desOpenBtn";
            this.desOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.desOpenBtn.TabIndex = 9;
            this.desOpenBtn.Text = "Open";
            this.desOpenBtn.UseVisualStyleBackColor = true;
            this.desOpenBtn.Click += new System.EventHandler(this.desOpenBtn_Click);
            // 
            // sourceOpenBtn
            // 
            this.sourceOpenBtn.Location = new System.Drawing.Point(184, 73);
            this.sourceOpenBtn.Name = "sourceOpenBtn";
            this.sourceOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.sourceOpenBtn.TabIndex = 8;
            this.sourceOpenBtn.Text = "Open";
            this.sourceOpenBtn.UseVisualStyleBackColor = true;
            this.sourceOpenBtn.Click += new System.EventHandler(this.sourceOpenBtn_Click);
            // 
            // previewGenProjectBtn
            // 
            this.previewGenProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.previewGenProjectBtn.Location = new System.Drawing.Point(130, 489);
            this.previewGenProjectBtn.Name = "previewGenProjectBtn";
            this.previewGenProjectBtn.Size = new System.Drawing.Size(563, 41);
            this.previewGenProjectBtn.TabIndex = 7;
            this.previewGenProjectBtn.Text = "Preview";
            this.previewGenProjectBtn.UseVisualStyleBackColor = false;
            this.previewGenProjectBtn.Click += new System.EventHandler(this.previewGenProjectBtn_Click);
            // 
            // destinationLbl
            // 
            this.destinationLbl.AutoSize = true;
            this.destinationLbl.Location = new System.Drawing.Point(15, 123);
            this.destinationLbl.Name = "destinationLbl";
            this.destinationLbl.Size = new System.Drawing.Size(60, 13);
            this.destinationLbl.TabIndex = 6;
            this.destinationLbl.Text = "Destination";
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(15, 52);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(41, 13);
            this.sourceLbl.TabIndex = 5;
            this.sourceLbl.Text = "Source";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.desOpenCompBtn);
            this.tabPage2.Controls.Add(this.sourceOpenCompBtn);
            this.tabPage2.Controls.Add(this.previewGenCompBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.sourceGenCompLbl);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.genComponentLbl);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gen Components";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // desOpenCompBtn
            // 
            this.desOpenCompBtn.Location = new System.Drawing.Point(193, 143);
            this.desOpenCompBtn.Name = "desOpenCompBtn";
            this.desOpenCompBtn.Size = new System.Drawing.Size(75, 23);
            this.desOpenCompBtn.TabIndex = 13;
            this.desOpenCompBtn.Text = "Open";
            this.desOpenCompBtn.UseVisualStyleBackColor = true;
            // 
            // sourceOpenCompBtn
            // 
            this.sourceOpenCompBtn.Location = new System.Drawing.Point(193, 81);
            this.sourceOpenCompBtn.Name = "sourceOpenCompBtn";
            this.sourceOpenCompBtn.Size = new System.Drawing.Size(75, 23);
            this.sourceOpenCompBtn.TabIndex = 12;
            this.sourceOpenCompBtn.Text = "Open";
            this.sourceOpenCompBtn.UseVisualStyleBackColor = true;
            // 
            // previewGenCompBtn
            // 
            this.previewGenCompBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.previewGenCompBtn.Location = new System.Drawing.Point(111, 188);
            this.previewGenCompBtn.Name = "previewGenCompBtn";
            this.previewGenCompBtn.Size = new System.Drawing.Size(563, 41);
            this.previewGenCompBtn.TabIndex = 6;
            this.previewGenCompBtn.Text = "Preview";
            this.previewGenCompBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destination";
            // 
            // sourceGenCompLbl
            // 
            this.sourceGenCompLbl.AutoSize = true;
            this.sourceGenCompLbl.Location = new System.Drawing.Point(28, 56);
            this.sourceGenCompLbl.Name = "sourceGenCompLbl";
            this.sourceGenCompLbl.Size = new System.Drawing.Size(41, 13);
            this.sourceGenCompLbl.TabIndex = 10;
            this.sourceGenCompLbl.Text = "Source";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // genComponentLbl
            // 
            this.genComponentLbl.AutoSize = true;
            this.genComponentLbl.Location = new System.Drawing.Point(297, 17);
            this.genComponentLbl.Name = "genComponentLbl";
            this.genComponentLbl.Size = new System.Drawing.Size(159, 13);
            this.genComponentLbl.TabIndex = 9;
            this.genComponentLbl.Text = "Gen Components base sql script";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // treeViewFile
            // 
            this.treeViewFile.Location = new System.Drawing.Point(18, 276);
            this.treeViewFile.Name = "treeViewFile";
            this.treeViewFile.Size = new System.Drawing.Size(252, 184);
            this.treeViewFile.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "TreeView";
            // 
            // progressBarGen
            // 
            this.progressBarGen.Location = new System.Drawing.Point(340, 436);
            this.progressBarGen.Name = "progressBarGen";
            this.progressBarGen.Size = new System.Drawing.Size(353, 23);
            this.progressBarGen.TabIndex = 18;
            // 
            // genCompleted
            // 
            this.genCompleted.AutoSize = true;
            this.genCompleted.Location = new System.Drawing.Point(476, 462);
            this.genCompleted.Name = "genCompleted";
            this.genCompleted.Size = new System.Drawing.Size(80, 13);
            this.genCompleted.TabIndex = 19;
            this.genCompleted.Text = "Gen Completed";
            this.genCompleted.Visible = false;
            // 
            // AngularGenTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 724);
            this.Controls.Add(this.projectTab);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "AngularGenTools";
            this.Text = "Angular Gen Tool";
            this.projectTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.TextBox destinationTxt;
        private System.Windows.Forms.Label genProjectTxt;
        private System.Windows.Forms.TabControl projectTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label destinationLbl;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button previewGenCompBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sourceGenCompLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label genComponentLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button previewGenProjectBtn;
        private System.Windows.Forms.Button desOpenBtn;
        private System.Windows.Forms.Button sourceOpenBtn;
        private System.Windows.Forms.Button desOpenCompBtn;
        private System.Windows.Forms.Button sourceOpenCompBtn;
        private System.Windows.Forms.RichTextBox richTextBoxTest;
        private System.Windows.Forms.ComboBox projectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox fileContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewFile;
        private System.Windows.Forms.ProgressBar progressBarGen;
        private System.Windows.Forms.Label genCompleted;
    }
}

