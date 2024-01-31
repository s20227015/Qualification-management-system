
namespace Qualification_management_system
{
    partial class UserUpdate
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
            this.update_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Mail_textBox = new System.Windows.Forms.TextBox();
            this.qualification_mouth_label = new System.Windows.Forms.Label();
            this.qualification_label = new System.Windows.Forms.Label();
            this.update_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Lime;
            this.update_button.Location = new System.Drawing.Point(668, 390);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(120, 50);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "変更";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.UpdateButton);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gray;
            this.back_button.Location = new System.Drawing.Point(12, 14);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 56);
            this.back_button.TabIndex = 25;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(255, 330);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(300, 22);
            this.Password_textBox.TabIndex = 23;
            // 
            // Mail_textBox
            // 
            this.Mail_textBox.Location = new System.Drawing.Point(255, 230);
            this.Mail_textBox.Name = "Mail_textBox";
            this.Mail_textBox.Size = new System.Drawing.Size(300, 22);
            this.Mail_textBox.TabIndex = 22;
            // 
            // qualification_mouth_label
            // 
            this.qualification_mouth_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qualification_mouth_label.Location = new System.Drawing.Point(80, 270);
            this.qualification_mouth_label.Name = "qualification_mouth_label";
            this.qualification_mouth_label.Size = new System.Drawing.Size(186, 40);
            this.qualification_mouth_label.TabIndex = 20;
            this.qualification_mouth_label.Text = "パスワード";
            // 
            // qualification_label
            // 
            this.qualification_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qualification_label.Location = new System.Drawing.Point(80, 168);
            this.qualification_label.Name = "qualification_label";
            this.qualification_label.Size = new System.Drawing.Size(223, 34);
            this.qualification_label.TabIndex = 19;
            this.qualification_label.Text = "メールアドレス";
            // 
            // update_title
            // 
            this.update_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.update_title.Location = new System.Drawing.Point(275, 11);
            this.update_title.Name = "update_title";
            this.update_title.Size = new System.Drawing.Size(317, 100);
            this.update_title.TabIndex = 18;
            this.update_title.Text = "変更";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Mail_textBox);
            this.Controls.Add(this.qualification_mouth_label);
            this.Controls.Add(this.qualification_label);
            this.Controls.Add(this.update_title);
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Mail_textBox;
        private System.Windows.Forms.Label qualification_mouth_label;
        private System.Windows.Forms.Label qualification_label;
        private System.Windows.Forms.Label update_title;
    }
}