
namespace Qualification_management_system
{
    partial class MemberDelete
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
            this.delete_title = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_title
            // 
            this.delete_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delete_title.Location = new System.Drawing.Point(296, 25);
            this.delete_title.Name = "delete_title";
            this.delete_title.Size = new System.Drawing.Size(276, 100);
            this.delete_title.TabIndex = 0;
            this.delete_title.Text = "削除";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gray;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 56);
            this.back_button.TabIndex = 17;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.BackButton);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.Location = new System.Drawing.Point(259, 183);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(265, 112);
            this.delete_button.TabIndex = 18;
            this.delete_button.Text = "削除";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.DeleteButton);
            // 
            // MemberDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_title);
            this.Name = "MemberDelete";
            this.Text = "delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label delete_title;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button delete_button;
    }
}