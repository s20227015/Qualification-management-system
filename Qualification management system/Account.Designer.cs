
namespace Qualification_management_system
{
    partial class Account
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
            this.account_title = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.addition_button = new System.Windows.Forms.Button();
            this.memberUpdate_button = new System.Windows.Forms.Button();
            this.memberDelete_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account_title
            // 
            this.account_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.account_title.Location = new System.Drawing.Point(190, 9);
            this.account_title.Name = "account_title";
            this.account_title.Size = new System.Drawing.Size(455, 100);
            this.account_title.TabIndex = 0;
            this.account_title.Text = "アカウント";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Aqua;
            this.search_button.Location = new System.Drawing.Point(674, 88);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(114, 50);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "検索";
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // addition_button
            // 
            this.addition_button.BackColor = System.Drawing.Color.Yellow;
            this.addition_button.Location = new System.Drawing.Point(310, 250);
            this.addition_button.Name = "addition_button";
            this.addition_button.Size = new System.Drawing.Size(180, 80);
            this.addition_button.TabIndex = 2;
            this.addition_button.Text = "試験の合格月";
            this.addition_button.UseVisualStyleBackColor = false;
            this.addition_button.Click += new System.EventHandler(this.MemberAdditionButton);
            // 
            // memberUpdate_button
            // 
            this.memberUpdate_button.BackColor = System.Drawing.Color.Lime;
            this.memberUpdate_button.Location = new System.Drawing.Point(310, 150);
            this.memberUpdate_button.Name = "memberUpdate_button";
            this.memberUpdate_button.Size = new System.Drawing.Size(180, 80);
            this.memberUpdate_button.TabIndex = 3;
            this.memberUpdate_button.Text = "社員情報変更";
            this.memberUpdate_button.UseVisualStyleBackColor = false;
            this.memberUpdate_button.Click += new System.EventHandler(this.MemberUpdateButton);
            // 
            // memberDelete_button
            // 
            this.memberDelete_button.BackColor = System.Drawing.Color.Red;
            this.memberDelete_button.Location = new System.Drawing.Point(310, 350);
            this.memberDelete_button.Name = "memberDelete_button";
            this.memberDelete_button.Size = new System.Drawing.Size(180, 80);
            this.memberDelete_button.TabIndex = 4;
            this.memberDelete_button.Text = "社員情報削除";
            this.memberDelete_button.UseVisualStyleBackColor = false;
            this.memberDelete_button.Click += new System.EventHandler(this.MemberDeleteButton);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gray;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 56);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.BackButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "アカウント";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.memberDelete_button);
            this.Controls.Add(this.memberUpdate_button);
            this.Controls.Add(this.addition_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.account_title);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label account_title;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button addition_button;
        private System.Windows.Forms.Button memberUpdate_button;
        private System.Windows.Forms.Button memberDelete_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button button1;
    }
}