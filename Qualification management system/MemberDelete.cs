//----------------------------------------
//
//MemberDelete
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:会員データ削除機能
//----------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Qualification_management_system
{
    public partial class MemberDelete : Form
    {
        /// <summary>
        /// MemberDelete
        /// フォーム作成
        /// </summary>
        public MemberDelete()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  DeleteButton
        ///  会員情報の削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton(object sender, EventArgs e)
        {
            //データベースを代入
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=account.db"))
            {
                //データベースを開く
                connection.Open();
                //データベースの処理
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    //SQLコマンドを宣言する
                    SQLiteCommand accountCommand = connection.CreateCommand();
                    //SQL文の代入
                    accountCommand.CommandText = "DELETE FROM t_product WHERE CD = @Cd;";
                    //パラメータセット
                    accountCommand.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //ログインしているCDを取得
                    string Cd_text = Convert.ToString(LoginUser_Info.CD);
                    //データ追加
                    accountCommand.Parameters["Cd"].Value = int.Parse(Cd_text);
                    //SQLコマンドを終了する
                    accountCommand.ExecuteNonQuery();
                    //コミット
                    transaction.Commit();
                }
            }
            //Menuフォームを代入
            Form menu = new Menu();
            //代入した値を開く
            menu.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        /// <summary>
        /// BackButton
        /// Account画面に戻る
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
