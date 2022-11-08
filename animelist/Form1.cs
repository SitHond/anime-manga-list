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
        {
            Form1 f1 = new Form1();
            f1.Hide();
            login f = new login();
            f.Show(); 
        }
    }
}
