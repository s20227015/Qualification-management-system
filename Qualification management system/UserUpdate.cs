using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Qualification_management_system
{
    public partial class UserUpdate : Form
    {
        private string _loginCd;
        public UserUpdate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// UpdateButton
        /// ログインしているアカウントのaddress,passwordの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton(object sender, EventArgs e)
        {
            //データベースを代入
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=account.db"))
            {
                //データベースを開く
                connection.Open();
                //代入したデータベースの処理
                using (SQLiteTransaction transaction = connection.BeginTransaction()) //データベースを開始する
                {
                    //SQLコマンドを宣言する
                    SQLiteCommand accountCommand = connection.CreateCommand();
                    //SQL文の代入
                    accountCommand.CommandText = "UPDATE  t_product set address = @Address, password = @Password WHERE CD = @Cd";
                    //パラメータセット
                    accountCommand.Parameters.Add("Address", System.Data.DbType.String);
                    accountCommand.Parameters.Add("Password", System.Data.DbType.String);
                    accountCommand.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //ログインしているCDを取得
                    _loginCd = Convert.ToString(LoginUser_Info.CD);
                    //データ追加
                    accountCommand.Parameters["Address"].Value = Mail_textBox.Text;
                    accountCommand.Parameters["Password"].Value = Password_textBox.Text;
                    accountCommand.Parameters["Cd"].Value = _loginCd;
                    //SQLコマンドを終了する
                    accountCommand.ExecuteNonQuery();
                    //コミット
                    transaction.Commit();
                }
            }
            //Accountフォームを代入
            Form account = new Account();
            //代入した値を開く
            account.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        /// <summary>
        /// BackButton
        /// Account画面に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_button_Click(object sender, EventArgs e)
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
