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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ani_look = new System.Windows.Forms.LinkLabel();
            this.ani_look2 = new System.Windows.Forms.LinkLabel();
            this.ani_viewed = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(16, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Аниме";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ani_viewed);
            this.Controls.Add(this.ani_look2);
            this.Controls.Add(this.ani_look);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.your_list);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Anime Manga List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label your_list;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel ani_look;
        private System.Windows.Forms.LinkLabel ani_look2;
        private System.Windows.Forms.LinkLabel ani_viewed;
    }
}

