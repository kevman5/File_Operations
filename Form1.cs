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

namespace file_operationschpt12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String infofile;
            openFileDialog1.ShowDialog();
            infofile = openFileDialog1.FileName;
            tb_1.Text = infofile;
            

            using (StreamReader fileReader = new StreamReader(infofile))
            {
                string inputrecord = fileReader.ReadLine();
                string[] inputfields;
               
                if (inputrecord != null)
                {
                    inputfields = inputrecord.Split(',');
                    tb_fname.Text = inputfields[0];
                    tb_Lname.Text = inputfields[1];
                    tb_phone.Text = inputfields[2];
                    tb_add.Text = inputfields[3];
                    tb_email.Text = inputfields[4];
                    tb_ins.Text = inputfields[5];
                    

                }
                fileReader.Close();
            }

        }

    

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            String infofile = "C:\\temp\\infofile.txt";
            infofile = saveFileDialog1.FileName;
            tb_1.Text = infofile;
            TextWriter tw = new StreamWriter(infofile);
            String s, s1;
            s = tb_fname.Text.ToString() + "," + tb_Lname.Text.ToString() + "," + tb_phone.Text.ToString() + "," + tb_add.Text.ToString() + "," + tb_email.Text.ToString() + "," + tb_ins.Text.ToString();
            
            tw.WriteLine(s);
            
            tw.Close();



        }
    }
}
