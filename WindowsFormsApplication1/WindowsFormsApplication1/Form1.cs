using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 後片付け
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub!","result");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub! NewRepos", "確認");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
