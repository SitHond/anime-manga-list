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
            login ma = new login();
            this.Visible = false;
            ma.ShowDialog();
            this.Visible = true;
        }
    }
}
