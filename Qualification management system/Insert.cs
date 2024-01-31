//----------------------------------------
//
//Insert
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:アカウント新規登録機能
//----------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Qualification_management_system
{
    public partial class Insert : Form
    {
        /// <summary>
        /// Insert
        /// フォーム作成
        /// </summary>
        public Insert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// InsertButton
        /// データベースにaddress,passwordを追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton(object sender, EventArgs e)
        {
            //データベースを代入
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=account.db"))
            {
                //データベースを開く
                connection.Open();
                //データベースの処理
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    // SQLコマンドを宣言する
                    SQLiteCommand accountCommand = connection.CreateCommand();
                    //SQL文の代入
                    accountCommand.CommandText = "INSERT INTO t_product (address, password) VALUES (@Address, @Password)";
                    //パラメータセット
                    accountCommand.Parameters.Add("Address", System.Data.DbType.String);
                    //パラメータセット
                    accountCommand.Parameters.Add("Password", System.Data.DbType.String);
                    //テキストボックスに書かれたものの取得
                    string mail_text = mail_textBox.Text;
                    //テキストボックスに書かれたものの取得
                    string password_text = password_textBox.Text;
                    //データ追加
                    accountCommand.Parameters["Address"].Value = mail_text ;
                    //データ追加
                    accountCommand.Parameters["Password"].Value = password_text;
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
        /// Menu画面に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton(object sender, EventArgs e)
        {
            //Menuフォームを代入
            Form menu = new Menu();
            //代入した値を開く
            menu.Show();
            //現在のフォームを閉じる
            this.Hide();
        }
    }
}
