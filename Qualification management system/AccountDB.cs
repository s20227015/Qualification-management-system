using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Qualification_management_system
{
    public partial class AccountDB : Form
    {
       
        public AccountDB()
        {
            InitializeComponent();
        }

        private void TableCreate_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=account.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "create table t_product(CD INTEGER PRIMARY KEY AUTOINCREMENT, address INTEGER, password INTEGER, it INTEGER," +
                        " informationBasic INTEGER, informationApplication INTEGER, support INTEGER, programma INTEGER, utilizationThree INTEGER," +
                        " utilizationTwo INTEGER, utilizationOne INTEGER, multiexpert INTEGER, multiBasic INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void DateAddition_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=account.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO t_product (address, password, it, informationBasic, informationApplication, " +
                        "support, programma, utilizationThree, utilizationTwo, utilizationOne, multiexpert, multiBasic ) " +
                        "VALUES (@Address, @Password, @It, @InformationBasic, @InformationApplication, @Support, @Programma, @UtilizationThree, " +
                        "@UtilizationTwo, @UtilizationOne, @Multiexpert, @MultiBasic )";

                    cmd.Parameters.Add("Address", System.Data.DbType.Int32);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);
                    cmd.Parameters.Add("It", System.Data.DbType.Int32);
                    cmd.Parameters.Add("InformationBasic", System.Data.DbType.Int32); 
                    cmd.Parameters.Add("InformationApplication", System.Data.DbType.Int32);
                    cmd.Parameters.Add("Support", System.Data.DbType.Int32);
                    cmd.Parameters.Add("Programma", System.Data.DbType.Int32);
                    cmd.Parameters.Add("UtilizationThree", System.Data.DbType.Int32);
                    cmd.Parameters.Add("UtilizationTwo", System.Data.DbType.Int32);
                    cmd.Parameters.Add("UtilizationOne", System.Data.DbType.Int32);
                    cmd.Parameters.Add("Multiexpert", System.Data.DbType.Int32);
                    cmd.Parameters.Add("MultiBasic", System.Data.DbType.Int32);

                    //データ追加
                    cmd.Parameters["Address"].Value = addressText.Text;
                    cmd.Parameters["Password"].Value = passwordText.Text;
                    cmd.Parameters["It"].Value = 0;
                    cmd.Parameters["InformationBasic"].Value = 0;
                    cmd.Parameters["InformationApplication"].Value = 0;
                    cmd.Parameters["Support"].Value = 0;
                    cmd.Parameters["Programma"].Value = 0;
                    cmd.Parameters["UtilizationThree"].Value = 0;
                    cmd.Parameters["UtilizationTwo"].Value = 0;
                    cmd.Parameters["UtilizationOne"].Value = 0;
                    cmd.Parameters["Multiexpert"].Value = 0;
                    cmd.Parameters["MultiBasic"].Value = 0;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void DateLoading_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=account.db"))
            {
                //DataTableを生成します。
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void DateUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=account.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE    t_product set address = @Address, password = @Password WHERE CD = @Cd";
                    //パラメータセット
                    cmd.Parameters.Add("Address", System.Data.DbType.String);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);
                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["Address"].Value = addressTextUpdate.Text;
                    cmd.Parameters["Password"].Value = passwordTextUpdate.Text;
                    cmd.Parameters["Cd"].Value = int.Parse(searchTextUpdate.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
        private void DateDelete_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=account.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "DELETE FROM t_product WHERE CD = @Cd;";
                    //パラメータセット
                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //データ削除
                    cmd.Parameters["Cd"].Value = int.Parse(searchTextDelete.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
    }
}
