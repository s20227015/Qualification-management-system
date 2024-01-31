
namespace Qualification_management_system
{
    partial class AccountDB
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
            this.TableCreate = new System.Windows.Forms.Button();
            this.DateAddition = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.DateLoading = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.passwordTextUpdate = new System.Windows.Forms.TextBox();
            this.addressTextUpdate = new System.Windows.Forms.TextBox();
            this.searchTextUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateUpdate = new System.Windows.Forms.Button();
            this.searchTextDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableCreate
            // 
            this.TableCreate.Location = new System.Drawing.Point(20, 20);
            this.TableCreate.Name = "TableCreate";
            this.TableCreate.Size = new System.Drawing.Size(150, 60);
            this.TableCreate.TabIndex = 0;
            this.TableCreate.Text = "テーブル作成";
            this.TableCreate.UseVisualStyleBackColor = true;
            this.TableCreate.Click += new System.EventHandler(this.TableCreate_Click);
            // 
            // DateAddition
            // 
            this.DateAddition.Location = new System.Drawing.Point(220, 20);
            this.DateAddition.Name = "DateAddition";
            this.DateAddition.Size = new System.Drawing.Size(150, 60);
            this.DateAddition.TabIndex = 1;
            this.DateAddition.Text = "データ追加";
            this.DateAddition.UseVisualStyleBackColor = true;
            this.DateAddition.Click += new System.EventHandler(this.DateAddition_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(563, 58);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(134, 22);
            this.passwordText.TabIndex = 9;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(381, 58);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(150, 22);
            this.addressText.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Address.Location = new System.Drawing.Point(420, 20);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(87, 24);
            this.Address.TabIndex = 7;
            this.Address.Text = "address";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Password.Location = new System.Drawing.Point(578, 20);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(103, 24);
            this.Password.TabIndex = 6;
            this.Password.Text = "password";
            // 
            // DateLoading
            // 
            this.DateLoading.Location = new System.Drawing.Point(220, 120);
            this.DateLoading.Name = "DateLoading";
            this.DateLoading.Size = new System.Drawing.Size(150, 60);
            this.DateLoading.TabIndex = 10;
            this.DateLoading.Text = "データ読み込み";
            this.DateLoading.UseVisualStyleBackColor = true;
            this.DateLoading.Click += new System.EventHandler(this.DateLoading_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 130);
            this.dataGridView1.TabIndex = 11;
            // 
            // passwordTextUpdate
            // 
            this.passwordTextUpdate.Location = new System.Drawing.Point(563, 346);
            this.passwordTextUpdate.Name = "passwordTextUpdate";
            this.passwordTextUpdate.Size = new System.Drawing.Size(134, 22);
            this.passwordTextUpdate.TabIndex = 21;
            // 
            // addressTextUpdate
            // 
            this.addressTextUpdate.Location = new System.Drawing.Point(381, 346);
            this.addressTextUpdate.Name = "addressTextUpdate";
            this.addressTextUpdate.Size = new System.Drawing.Size(150, 22);
            this.addressTextUpdate.TabIndex = 20;
            // 
            // searchTextUpdate
            // 
            this.searchTextUpdate.Location = new System.Drawing.Point(381, 294);
            this.searchTextUpdate.Name = "searchTextUpdate";
            this.searchTextUpdate.Size = new System.Drawing.Size(150, 22);
            this.searchTextUpdate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(578, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(420, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(417, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "検索CD";
            // 
            // DateUpdate
            // 
            this.DateUpdate.Location = new System.Drawing.Point(220, 256);
            this.DateUpdate.Name = "DateUpdate";
            this.DateUpdate.Size = new System.Drawing.Size(150, 60);
            this.DateUpdate.TabIndex = 15;
            this.DateUpdate.Text = "データ修正";
            this.DateUpdate.UseVisualStyleBackColor = true;
            this.DateUpdate.Click += new System.EventHandler(this.DateUpdate_Click);
            // 
            // searchTextDelete
            // 
            this.searchTextDelete.Location = new System.Drawing.Point(382, 416);
            this.searchTextDelete.Name = "searchTextDelete";
            this.searchTextDelete.Size = new System.Drawing.Size(150, 22);
            this.searchTextDelete.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(417, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "検索CD";
            // 
            // DateDelete
            // 
            this.DateDelete.Location = new System.Drawing.Point(220, 378);
            this.DateDelete.Name = "DateDelete";
            this.DateDelete.Size = new System.Drawing.Size(150, 60);
            this.DateDelete.TabIndex = 22;
            this.DateDelete.Text = "データ削除";
            this.DateDelete.UseVisualStyleBackColor = true;
            this.DateDelete.Click += new System.EventHandler(this.DateDelete_Click);
            // 
            // AccountDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.searchTextDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateDelete);
            this.Controls.Add(this.passwordTextUpdate);
            this.Controls.Add(this.addressTextUpdate);
            this.Controls.Add(this.searchTextUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DateLoading);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.DateAddition);
            this.Controls.Add(this.TableCreate);
            this.Name = "AccountDB";
            this.Text = "AccountDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TableCreate;
        private System.Windows.Forms.Button DateAddition;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button DateLoading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox passwordTextUpdate;
        private System.Windows.Forms.TextBox addressTextUpdate;
        private System.Windows.Forms.TextBox searchTextUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DateUpdate;
        private System.Windows.Forms.TextBox searchTextDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DateDelete;
    }
}