using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System_Using_Csharp
{
    public partial class frm_balance : Form
    {
        public static string account;

        Connection conn = new Connection();

        SqlCommand cmd;

        public frm_balance()
        {
            InitializeComponent();
        }

   
        private void label8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_main fm = new frm_main();
            fm.ShowDialog();
        }

        private void frm_balance_Load(object sender, EventArgs e)
        {
            Loadaccount();

        }

        private void Loadaccount()
        {
            account = frm_main.account_no;

            lbl_accountno.Text = account;

            loadaccount();

        }

        private void loadaccount()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select yourname,amount From account Where accountno = '" + lbl_accountno.Text + "'";

                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_username.Text = dr.GetValue(0).ToString();
                    lbl_amount.Text = dr.GetValue(1).ToString();
                }

                con.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
