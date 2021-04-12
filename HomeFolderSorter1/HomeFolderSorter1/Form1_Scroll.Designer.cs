namespace HomeFolderSorter1
{
    partial class HomeFolderSorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFolderSorter));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GetFolder = new System.Windows.Forms.Button();
            this.buttonByYear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1980";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(407, 20);
            this.textBox2.TabIndex = 1;
            // 
            // GetFolder
            // 
            this.GetFolder.Location = new System.Drawing.Point(13, 12);
            this.GetFolder.Name = "GetFolder";
            this.GetFolder.Size = new System.Drawing.Size(75, 23);
            this.GetFolder.TabIndex = 2;
            this.GetFolder.Text = "GetFolder";
            this.GetFolder.UseVisualStyleBackColor = true;
            this.GetFolder.Click += new System.EventHandler(this.GetFolder_Click);
            // 
            // buttonByYear
            // 
            this.buttonByYear.Location = new System.Drawing.Point(220, 9);
            this.buttonByYear.Name = "buttonByYear";
            this.buttonByYear.Size = new System.Drawing.Size(102, 23);
            this.buttonByYear.TabIndex = 3;
            this.buttonByYear.Text = "buttonByYear";
            this.buttonByYear.UseVisualStyleBackColor = true;
            this.buttonByYear.Click += new System.EventHandler(this.buttonByYear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 225);
            this.listBox1.TabIndex = 4;
            // 
            // HomeFolderSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 329);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonByYear);
            this.Controls.Add(this.GetFolder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeFolderSorter";
            this.Text = "HomeFolderSorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button GetFolder;
        private System.Windows.Forms.Button buttonByYear;
        private System.Windows.Forms.ListBox listBox1;
    }
}

