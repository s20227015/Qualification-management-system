
namespace Qualification_management_system
{
    partial class Update
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
            this.passed_mouth_textBox = new System.Windows.Forms.TextBox();
            this.qualification_mouth_textBox = new System.Windows.Forms.TextBox();
            this.qualification_textBox = new System.Windows.Forms.TextBox();
            this.passed_mouth_label = new System.Windows.Forms.Label();
            this.qualification_mouth_label = new System.Windows.Forms.Label();
            this.qualification_label = new System.Windows.Forms.Label();
            this.update_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Lime;
            this.update_button.Location = new System.Drawing.Point(668, 388);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(120, 50);
            this.update_button.TabIndex = 17;
            this.update_button.Text = "変更";
            this.update_button.UseVisualStyleBackColor = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gray;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 56);
            this.back_button.TabIndex = 16;
            this.back_button.Text = "戻る";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // passed_mouth_textBox
            // 
            this.passed_mouth_textBox.Location = new System.Drawing.Point(292, 400);
            this.passed_mouth_textBox.Name = "passed_mouth_textBox";
            this.passed_mouth_textBox.Size = new System.Drawing.Size(300, 22);
            this.passed_mouth_textBox.TabIndex = 15;
            // 
            // qualification_mouth_textBox
            // 
            this.qualification_mouth_textBox.Location = new System.Drawing.Point(292, 300);
            this.qualification_mouth_textBox.Name = "qualification_mouth_textBox";
            this.qualification_mouth_textBox.Size = new System.Drawing.Size(300, 22);
            this.qualification_mouth_textBox.TabIndex = 14;
            // 
            // qualification_textBox
            // 
            this.qualification_textBox.Location = new System.Drawing.Point(292, 200);
            this.qualification_textBox.Name = "qualification_textBox";
            this.qualification_textBox.Size = new System.Drawing.Size(300, 22);
            this.qualification_textBox.TabIndex = 13;
            // 
            // passed_mouth_label
            // 
            this.passed_mouth_label.AutoSize = true;
            this.passed_mouth_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passed_mouth_label.Location = new System.Drawing.Point(150, 350);
            this.passed_mouth_label.Name = "passed_mouth_label";
            this.passed_mouth_label.Size = new System.Drawing.Size(114, 33);
            this.passed_mouth_label.TabIndex = 12;
            this.passed_mouth_label.Text = "合格月";
            // 
            // qualification_mouth_label
            // 
            this.qualification_mouth_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qualification_mouth_label.Location = new System.Drawing.Point(150, 250);
            this.qualification_mouth_label.Name = "qualification_mouth_label";
            this.qualification_mouth_label.Size = new System.Drawing.Size(140, 40);
            this.qualification_mouth_label.TabIndex = 11;
            this.qualification_mouth_label.Text = "受けた月";
            // 
            // qualification_label
            // 
            this.qualification_label.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qualification_label.Location = new System.Drawing.Point(150, 150);
            this.qualification_label.Name = "qualification_label";
            this.qualification_label.Size = new System.Drawing.Size(118, 34);
            this.qualification_label.TabIndex = 10;
            this.qualification_label.Text = "資格名";
            // 
            // update_title
            // 
            this.update_title.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.update_title.Location = new System.Drawing.Point(275, 9);
            this.update_title.Name = "update_title";
            this.update_title.Size = new System.Drawing.Size(250, 100);
            this.update_title.TabIndex = 9;
            this.update_title.Text = "変更";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.passed_mouth_textBox);
            this.Controls.Add(this.qualification_mouth_textBox);
            this.Controls.Add(this.qualification_textBox);
            this.Controls.Add(this.passed_mouth_label);
            this.Controls.Add(this.qualification_mouth_label);
            this.Controls.Add(this.qualification_label);
            this.Controls.Add(this.update_title);
            this.Name = "Update";
            this.Text = "update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox passed_mouth_textBox;
        private System.Windows.Forms.TextBox qualification_mouth_textBox;
        private System.Windows.Forms.TextBox qualification_textBox;
        private System.Windows.Forms.Label passed_mouth_label;
        private System.Windows.Forms.Label qualification_mouth_label;
        private System.Windows.Forms.Label qualification_label;
        private System.Windows.Forms.Label update_title;
    }
}