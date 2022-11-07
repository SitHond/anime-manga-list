using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace animelist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            if(field_login.Text == "a" && field_pass.Text == "a")
            {
                Form1 f = new Form1();
                f.Show();
                Close();    
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
    }
}
