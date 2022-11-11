namespace animelist
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.Label();
            this.your_list = new System.Windows.Forms.Label();
            this.anime = new System.Windows.Forms.LinkLabel();
            this.ani_look = new System.Windows.Forms.LinkLabel();
            this.ani_look2 = new System.Windows.Forms.LinkLabel();
            this.ani_viewed = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(87, 27);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(59, 13);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "user_name";
            this.user_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // your_list
            // 
            this.your_list.AutoSize = true;
            this.your_list.Location = new System.Drawing.Point(13, 87);
            this.your_list.Name = "your_list";
            this.your_list.Size = new System.Drawing.Size(67, 13);
            this.your_list.TabIndex = 2;
            this.your_list.Text = "Ваш список";
            // 
            // anime
            // 
            this.anime.AutoSize = true;
            this.anime.LinkColor = System.Drawing.Color.Black;
            this.anime.Location = new System.Drawing.Point(16, 104);
            this.anime.Name = "anime";
            this.anime.Size = new System.Drawing.Size(40, 13);
            this.anime.TabIndex = 3;
            this.anime.TabStop = true;
            this.anime.Text = "Аниме";
            // 
            // ani_look
            // 
            this.ani_look.AutoSize = true;
            this.ani_look.LinkColor = System.Drawing.Color.Black;
            this.ani_look.Location = new System.Drawing.Point(25, 126);
            this.ani_look.Name = "ani_look";
            this.ani_look.Size = new System.Drawing.Size(47, 13);
            this.ani_look.TabIndex = 4;
            this.ani_look.TabStop = true;
            this.ani_look.Text = "Смотрю";
            // 
            // ani_look2
            // 
            this.ani_look2.AutoSize = true;
            this.ani_look2.LinkColor = System.Drawing.Color.Black;
            this.ani_look2.Location = new System.Drawing.Point(25, 150);
            this.ani_look2.Name = "ani_look2";
            this.ani_look2.Size = new System.Drawing.Size(81, 13);
            this.ani_look2.TabIndex = 5;
            this.ani_look2.TabStop = true;
            this.ani_look2.Text = "Буду смотреть";
            // 
            // ani_viewed
            // 
            this.ani_viewed.AutoSize = true;
            this.ani_viewed.LinkColor = System.Drawing.Color.Black;
            this.ani_viewed.Location = new System.Drawing.Point(25, 173);
            this.ani_viewed.Name = "ani_viewed";
            this.ani_viewed.Size = new System.Drawing.Size(82, 13);
            this.ani_viewed.TabIndex = 6;
            this.ani_viewed.TabStop = true;
            this.ani_viewed.Text = "Просмотренно";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(165, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 451);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(165, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(636, 2);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(28, 29);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 9;
            this.LoginBox.Visible = false;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(28, 78);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 10;
            this.PassBox.Visible = false;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(41, 104);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 11;
            this.Login_btn.Text = "Войти";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Visible = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ani_viewed);
            this.Controls.Add(this.ani_look2);
            this.Controls.Add(this.ani_look);
            this.Controls.Add(this.anime);
            this.Controls.Add(this.your_list);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Login_btn);
            this.Name = "Form1";
            this.Text = "Anime Manga List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label your_list;
        private System.Windows.Forms.LinkLabel anime;
        private System.Windows.Forms.LinkLabel ani_look;
        private System.Windows.Forms.LinkLabel ani_look2;
        private System.Windows.Forms.LinkLabel ani_viewed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button button1;
    }
}

