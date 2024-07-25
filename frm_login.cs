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
    public partial class frm_login : Form
    {
        Connection conn = new Connection();

        SqlCommand cmd;

        public static string accountno;

        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (txt_accountno.Text == "" || txt_pin.Text == "")
                {
                    MessageBox.Show("Please , Enter Login details", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From account Where accountno = '" + txt_accountno.Text + "' and pin = '" + txt_pin.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader(); 

                    if (dr.Read())
                    {
                        accountno = txt_accountno.Text;
                        this.Hide();
                        frm_main fm = new frm_main();
                        fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register fr = new frm_register();
            fr.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
