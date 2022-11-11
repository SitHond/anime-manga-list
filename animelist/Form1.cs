using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace animelist
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            
            InitializeComponent();
            /*
            bool user = false;

            if(user == true)
            {
                string usericon = "";
                SqlConnection connn = new SqlConnection("Server=DESKTOP-DEQB5OG\\SQLEXPRESS;Database=test_ptog;Trusted_Connection=True;");
                connn.Open();
                SqlCommand c = new SqlCommand($"SELECT * FROM user WHERE icon = @icon", connn);
                c.Parameters.Add(new SqlParameter("@icon",));
                SqlDataReader dr;
                dr = c.ExecuteReader();
                
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Изображение пользователя - 
            pictureBox1.ImageLocation = "https://sithond.ru/404.png";
            pictureBox2.ImageLocation = "https://sithond.ru/aav.png";
            pictureBox3.ImageLocation = "https://sithond.ru/aav.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            user_name.Visible = false;
            ani_look.Visible = false;
            ani_look2.Visible = false;
            ani_viewed.Visible = false;
            your_list.Visible = false;
            anime.Visible = false;
            pictureBox1.Visible = false;

            LoginBox.Visible = true;
            PassBox.Visible = true;
            Login_btn.Visible = true;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "a" && PassBox.Text == "a")
            {
                bool user = true;


                user_name.Visible = true;
                ani_look.Visible = true;
                ani_look2.Visible = true;
                ani_viewed.Visible = true;
                your_list.Visible = true;
                anime.Visible = true;
                pictureBox1.Visible = true;

                LoginBox.Visible = false;
                PassBox.Visible = false;
                Login_btn.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
