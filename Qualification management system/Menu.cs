//----------------------------------------
//
//Menu
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:新規登録かログイン画面への選択画面
//----------------------------------------
using System;
using System.Windows.Forms;

namespace Qualification_management_system
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void InsertButton(object sender, EventArgs e)
        {
            //Insertフォームを代入
            Form insert = new Insert();
            //代入した値を開く
            insert.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            //Loginフォームを代入
            Form login = new Login();
            //代入した値を開く
            login.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        private void end_button_Click(object sender, EventArgs e)
        {

        }
    }
}
