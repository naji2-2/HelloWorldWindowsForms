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

namespace HelloWorldWindowsForms
{
    public partial class FormMain: System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "쾅!";
        }

        private void microsoftViToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

                // 모달창
                Form formAbout1 = new FormAbout();
                formAbout1.Text = "모달창(modal)";
                formAbout1.ShowDialog();

                // 모달리스창
                Form formAbout2 = new FormAbout();
                formAbout2.Text = "모달리스창(Modeless)";
                formAbout2.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일(*txt)|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                 case DialogResult.OK:
                    //textBox1.Text = openFileDialog.FileName;
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                        break;
                case DialogResult.Cancel:
                        MessageBox.Show("취소했습니다.");
                        break;
            }
        }
    }
}
