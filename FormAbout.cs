using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindowsForms
{
    public partial class FormAbout: Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("notepad"); => 노트 열기
            System.Diagnostics.Process.Start("https://velog.io/@naji2-2/posts --incognito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
