
namespace Qualification_management_system
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.insert_button = new System.Windows.Forms.Button();
            this.end_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.qualification_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.insert_button.Font = new System.Drawing.Font("ＭＳ 明朝", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insert_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insert_button.Location = new System.Drawing.Point(310, 150);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(180, 80);
            this.insert_button.TabIndex = 0;
            this.insert_button.Text = "新規登録";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.InsertButton);
            // 
            // end_button
            // 
            this.end_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.end_button.Font = new System.Drawing.Font("ＭＳ 明朝", 19.8F);
            this.end_button.Location = new System.Drawing.Point(310, 350);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(180, 80);
            this.end_button.TabIndex = 1;
            this.end_button.Text = "終了";
            this.end_button.UseVisualStyleBackColor = false;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.login_button.Font = new System.Drawing.Font("ＭＳ 明朝", 19.8F);
            this.login_button.Location = new System.Drawing.Point(310, 250);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 80);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "ログイン";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.LoginButton);
            // 
            // qualification_title
            // 
            this.qualification_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qualification_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.qualification_title.Location = new System.Drawing.Point(175, 9);
            this.qualification_title.Name = "qualification_title";
            this.qualification_title.Size = new System.Drawing.Size(509, 100);
            this.qualification_title.TabIndex = 3;
            this.qualification_title.Text = "資格管理";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qualification_title);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.end_button);
            this.Controls.Add(this.insert_button);
            this.Name = "Menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button end_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label qualification_title;
    }
}

