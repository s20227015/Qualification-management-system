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
    public partial class MonthUpdateNext : Form
    {
        public MonthUpdateNext()
        {
            InitializeComponent();
        }

        private void MonthUpdateNextScreen(object sender, EventArgs e)
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
                        if (accountReader.Read())
                        {

                            // データが存在する場合、各フィールドの値を取得してUI要素にセットする
                            Console.WriteLine("///////////" + accountReader["utilizationThree"].ToString());
                            utilizationThree_text.Text = accountReader["utilizationThree"].ToString();
                            utilizationTwo_text.Text = accountReader["utilizationTwo"].ToString();
                            utilizationOne_text.Text = accountReader["utilizationOne"].ToString();
                            multiexpert_text.Text = accountReader["multiexpert"].ToString();
                            multiBasic_text.Text = accountReader["multiBasic"].ToString();

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
                    cmd.CommandText = "UPDATE    t_product set utilizationThree = @UtilizationThree, utilizationTwo = @UtilizationTwo, " +
                        "utilizationOne = @UtilizationOne, multiexpert = @Multiexpert, multiBasic = @MultiBasic";
                    //パラメータセット
                    cmd.Parameters.Add("UtilizationThree", System.Data.DbType.String);
                    cmd.Parameters.Add("UtilizationTwo", System.Data.DbType.String);
                    cmd.Parameters.Add("UtilizationOne", System.Data.DbType.String);
                    cmd.Parameters.Add("Multiexpert", System.Data.DbType.String);
                    cmd.Parameters.Add("MultiBasic", System.Data.DbType.String);
                    //データ追加
                    cmd.Parameters["UtilizationThree"].Value = utilizationThree_text.Text;
                    cmd.Parameters["UtilizationTwo"].Value = utilizationTwo_text.Text;
                    cmd.Parameters["UtilizationOne"].Value = utilizationOne_text.Text;
                    cmd.Parameters["Multiexpert"].Value = multiexpert_text.Text;
                    cmd.Parameters["MultiBasic"].Value = multiBasic_text.Text;
                    //SQLコマンドを終了する
                    cmd.ExecuteNonQuery();
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
    }
}
