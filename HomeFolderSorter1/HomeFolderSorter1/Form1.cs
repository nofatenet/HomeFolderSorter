using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HomeFolderSorter1
{
    public partial class HomeFolderSorter : Form
    {
        public HomeFolderSorter()
        {
            InitializeComponent();
        }

        public string sSelectedPath = @"C:\";      // C:\Users\your_user\your_folder\

        private void GetFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            FBD.Description = "Azo ist doof";

            FBD.SelectedPath = textBox2.Text;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                textBox2.Text = FBD.SelectedPath;
                //string[] filesArray = Directory.GetFiles(FBD.SelectedPath);
                string[] dirsArray = Directory.GetDirectories(FBD.SelectedPath);

                //foreach (string file in filesArray)
                //{
                //    listBox1.Items.Add(file);
                //}

                foreach (string dir in dirsArray)
                {
                    string sDirectoryName = Path.GetFileName(dir);
                    if (isvalid(sDirectoryName))
                    {
                        listBox1.Items.Add(sDirectoryName);
                    }
                }

                buttonByYear.Enabled = true;

            }
        }

        public bool isvalid(string directoryName)
        {
            string sregex = @"[A-Z- a-z0-9]{1,} \([0-9]{4}\)";
            if (Regex.IsMatch(directoryName, sregex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonByYear_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            //string[] filesArray = Directory.GetFiles(FBD.SelectedPath);
            string[] dirsArray = Directory.GetDirectories(textBox2.Text);

            //foreach (string file in filesArray)
            //{
            //    listBox1.Items.Add(file);
            //}

            foreach (string dir in dirsArray)
            {
                string sDirectoryName = Path.GetFileName(dir);
                if (isvalidByYear(sDirectoryName))
                {
                    listBox1.Items.Add(sDirectoryName);
                }
            }


        }

        public bool isvalidByYear(string directoryName)
        {
            string sregex2 = @"[A-Z- a-z0-9]{1,} \(" + textBox1.Text + @"\)";
            if (Regex.IsMatch(directoryName, sregex2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
