//----------------------------------------
//
//Login
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:アカウントログイン機能
//----------------------------------------
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Qualification_management_system
{
    public partial class Login : Form
    {
        private string _dbAddress;
        private string _dbPassword;
        private string _loginCd;

        /// <summary>
        /// Login
        /// フォーム作成
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MailTextBox
        /// テキストボックスに打たれた場合データベースからAddressとPasswordを変数に保持する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailTextBox(object sender, EventArgs e)
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
                    //データテーブルの代入
                    DataTable accountDataTable = new DataTable();
                    //SQL文の代入
                    accountCommand.CommandText = $" SELECT * FROM t_product WHERE address = @dbAddress";
                    //パラメータセット
                    accountCommand.Parameters.Add("dbAddress", System.Data.DbType.String);
                    //MailTextBoxに打たれたデータ追加 
                    accountCommand.Parameters["dbAddress"].Value = mail_textBox.Text;
                    //データの読み込み
                    SQLiteDataReader accountReader = accountCommand.ExecuteReader();
                    //データベースの中身が終わるまで回す
                    while (accountReader.Read() == true)
                    {
                        //読み込んだ値を代入し一時的に保存　accountReader["Address"]をstringに
                        _dbAddress = accountReader["Address"].ToString();     
                        //accountReader["Passward"]をstringに
                        _dbPassword = accountReader["Password"].ToString();

                        _loginCd = accountReader["CD"].ToString();
                    }
                    //読み込み終了
                    accountReader.Close();
                }
            }
        }

        /// <summary>
        /// LoginButton
        /// //入力されたIDとパスワードがDBのIDとパスワードと一致するかの確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton(object sender, EventArgs e)
        {
            //入力されたIDとパスワードが、DBのIDとパスワードと一致していたらAccountフォームを開く。でない場合Loginフォームを開く
            if (mail_textBox.Text == _dbAddress && password_textBox.Text == _dbPassword)
            {
                //Accountフォームを代入
                Form account = new Account();
                //代入した値を開く
                account.Show();
                //現在のフォームを閉じる
                this.Hide();
                //LoginUserスクリプトのLoginUser_InfoクラスのCDに値を入れている
                LoginUser_Info.CD = int.Parse(_loginCd);
                MessageBox.Show(Convert.ToString(LoginUser_Info.CD));

            }
            else
            {
                //Loginフォームを代入
                Form login = new Login();
                //代入した値を開く
                login.Show();
                //現在のフォームを閉じる
                this.Hide();
            }
        }

        /// <summary>
        /// BackButton
        /// Menu画面に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton(object sender, EventArgs e)
        {
            //メニューフォームを代入
            Form menu = new Menu();
            //代入した値を開く
            menu.Show();
            //現在のフォームを閉じる
            this.Hide();
        }
    }
}
