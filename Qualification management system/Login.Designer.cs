
namespace Qualification_management_system
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_title = new System.Windows.Forms.Label();
            this.mail_label = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_title
            // 
            this.login_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.login_title.Location = new System.Drawing.Point(225, 9);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(408, 100);
            this.login_title.TabIndex = 0;
            this.login_title.Text = "ログイン";
            // 
            // mail_label
            // 
            this.mail_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mail_label.Location = new System.Drawing.Point(80, 168);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(222, 40);
            this.mail_label.TabIndex = 1;
            this.mail_label.Text = "メールアドレス";
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(255, 230);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(320, 22);
            this.mail_textBox.TabIndex = 2;
            this.mail_textBox.TextChanged += new System.EventHandler(this.MailTextBox);
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password_label.Location = new System.Drawing.Point(80, 270);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(173, 40);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "パスワード";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(255, 330);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(320, 22);
            this.password_textBox.TabIndex = 4;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gray;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 56);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.BackButton);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.login_button.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.login_button.Location = new System.Drawing.Point(668, 388);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(120, 50);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "ログイン";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.LoginButton);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.mail_label);
            this.Controls.Add(this.login_title);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button login_button;
    }
}