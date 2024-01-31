//----------------------------------------
//
//Login
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:
//----------------------------------------
using System;
using System.Windows.Forms;

namespace Qualification_management_system
{
    public partial class Account : Form
    {
        /// <summary>
        /// Account
        /// フォーム作成
        /// </summary>
        public Account()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MemberUpdateButton
        /// Updateフォームに移る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberUpdateButton(object sender, EventArgs e)
        {
            //アップデートフォームを代入
            Form update = new UserUpdate();
            //代入した値を開く
            update.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        /// <summary>
        /// MemberDeleteButton
        /// Deleteフォームに移る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberDeleteButton(object sender, EventArgs e)
        {
            //MemberDeleteを代入
            Form delete = new MemberDelete();
            //代入した値を開く
            delete.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        /// <summary>
        /// MemberAdditionButton
        /// Additionフォームに移る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberAdditionButton(object sender, EventArgs e)
        {
            //Additionフォームを代入
            Form addition = new MonthUpdate();
            //代入した値を開く
            addition.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        /// <summary>
        /// BackButton
        /// Accountフォームに移る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton(object sender, EventArgs e)
        {
            //Accountフォームを代入
            Form account = new Account();
            //代入した値を開く
            account.Show();
            //現在のフォームを閉じる
            this.Hide();
        }
    }
}
