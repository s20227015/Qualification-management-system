//----------------------------------------
//
//MemberDelete
//
//作成日：12/26
//作成者：森崎貴斗
//
//内容:会員データ変更機能
//----------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Qualification_management_system
{
    public partial class MonthUpdate : Form
    {
        private string _loginCd;
        public MonthUpdate()
        {
            InitializeComponent();
        }

        private void MonthUpdateScreen(object sender, EventArgs e)
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
                    accountCommand.CommandText = "SELECT * FROM t_product WHERE CD = @Cd;";
                    //パラメータセット
                    accountCommand.Parameters.Add("Cd", System.Data.DbType.Int32);
                    //データ追加
                    accountCommand.Parameters["Cd"].Value = LoginUser_Info.CD;

                    using (SQLiteDataReader accountReader = accountCommand.ExecuteReader())
                    {
                        if(accountReader.Read())
                        {
                            // データが存在する場合、各フィールドの値を取得してUI要素にセットする
                            it_text.Text = accountReader["it"].ToString();
                            informationBasic_text.Text = accountReader["informationBasic"].ToString();
                            informationApplication_text.Text = accountReader["informationApplication"].ToString();
                            support_text.Text = accountReader["support"].ToString();
                            programma_text.Text = accountReader["programma"].ToString();

                        }
                    }
                }
            }
        }

        private void ConfirmButton(object sender, EventArgs e)
        {
            //データベースを代入
            using (SQLiteConnection con = new SQLiteConnection("Data Source=account.db"))
            {
                //データベースを開く
                con.Open();
                //代入したデータベースの処理
                using (SQLiteTransaction trans = con.BeginTransaction()) //データベースを開始する
                {
                    //SQLコマンドを宣言する
                    SQLiteCommand cmd = con.CreateCommand();
                    //SQL文の代入
                    cmd.CommandText = "UPDATE    t_product set it = @It, informationBasic = @InformationBasic, informationApplication = @InformationApplication, support = @Support, programma = @Programma";

                    //"UPDATE    t_product set address = @Address, password = @Password WHERE CD = @Cd"

                    //パラメータセット
                    cmd.Parameters.Add("It", System.Data.DbType.String);
                    cmd.Parameters.Add("InformationBasic", System.Data.DbType.String);
                    cmd.Parameters.Add("InformationApplication", System.Data.DbType.String);
                    cmd.Parameters.Add("Support", System.Data.DbType.String);
                    cmd.Parameters.Add("Programma", System.Data.DbType.String);

                    //cmd.Parameters.Add("It", System.Data.DbType.Int32);
                    //cmd.Parameters.Add("InformationBasic", System.Data.DbType.Int32);
                    //cmd.Parameters.Add("InformationApplication", System.Data.DbType.Int32);
                    //cmd.Parameters.Add("Support", System.Data.DbType.Int32);
                    //cmd.Parameters.Add("Programma", System.Data.DbType.Int32);

                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //ログインしているCDを取得
                    _loginCd = Convert.ToString(LoginUser_Info.CD);

                    //データ追加
                    cmd.Parameters["It"].Value = it_text.Text;
                    cmd.Parameters["InformationBasic"].Value = informationBasic_text.Text;
                    cmd.Parameters["InformationApplication"].Value = informationApplication_text.Text;
                    cmd.Parameters["Support"].Value = support_text.Text;
                    cmd.Parameters["Programma"].Value = programma_text.Text;
                    cmd.Parameters["Cd"].Value = _loginCd;


                    //SQLコマンドを終了する
                    //cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
            //Accountフォームを代入
            Form account = new Account();
            //代入した値を開く
            account.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //MonthUpdateNextフォームを代入
            Form monthUpdateNext = new MonthUpdateNext();
            //代入した値を開く
            monthUpdateNext.Show();
            //現在のフォームを閉じる
            this.Hide();
        }

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
