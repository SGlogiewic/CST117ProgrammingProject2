using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117ProgrammingProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String drawnImage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                drawnImage.Backcolor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                drawnImage.Backcolor = Color.Blue;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                drawnImage.Backcolor = Color.Green;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                drawnImage.Backcolor = Color.Yellow;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                drawnImage.Backcolor = Color.Red;
            }
            else if (radioButton2.Checked) 
            {
                drawnImage.Backcolor = Color.Blue;
            }
            else if (radioButton3.Checked)
            {
                drawnImage.Backcolor = Color.Green;
            }
            else if (radioButton4.Checked)
            {
                drawnImage.Backcolor = Color.Yellow;
            }
            else 
            {
                drawnImage.Backcolor = Color.White;
            }
        }
    }
}
