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
    }
}
