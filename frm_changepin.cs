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
    public partial class frm_changepin : Form
    {
        public static string accountno_;

        Connection conn = new Connection();

        public frm_changepin()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main fm = new frm_main();
            fm.ShowDialog();
        }

        private void frm_changepin_Load(object sender, EventArgs e)
        {
            accountno_ = frm_main.account_no;

            lbl_accountno.Text = accountno_;

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_confirmpin.Text == "" || txt_newpin.Text == "")
                {
                    MessageBox.Show("Please , Enter Valied Pin", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_newpin.Text.Trim() != txt_confirmpin.Text.Trim())
                {
                    MessageBox.Show("Pin Is Not Matched", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update account Set pin = '" + txt_confirmpin.Text + "' Where accountno = '" + lbl_accountno.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(accountno) From account";

                    SqlCommand cmd1 = new SqlCommand(str1, con);

                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {

                        MessageBox.Show("Your Pin Changed Successfull ... ", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_confirmpin.Clear();
                        txt_newpin.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Your Pin Changed Failed ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
