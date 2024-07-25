using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace ATM_Management_System_Using_Csharp
{
    public partial class frm_register : Form
    {
        Connection conn = new Connection();

        public frm_register()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txt_accountno.Text = "" + GetUniqueKey(5);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login fl = new frm_login();
            fl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login fl = new frm_login();
            fl.ShowDialog();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_accountno.Text == "" || txt_address.Text == "" || txt_education.Text == "" || txt_mobailno.Text == "" || txt_occupation.Text == "" || txt_pin.Text == "" || txt_yourname.Text == "")
                {
                    MessageBox.Show("Please , Enter all details", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into account(accountno,yourname,mobailno,address,pin,education,occupation,dob,amount)Values('" + txt_accountno.Text + "','" + txt_yourname.Text + "','" + txt_mobailno.Text + "','" + txt_address.Text + "','" + txt_pin.Text + "','" + txt_education.Text + "','" + txt_occupation.Text + "','" + dtp_dob.Text + "','" + lbl_balance.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(accountno) From account";

                    SqlCommand cmd1 = new SqlCommand(str1, con);

                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Your Registration Is Successfull ... ", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frm_login fl = new frm_login();
                        fl.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Your Registration Is Failed ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    }

                    con.Close();

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            txt_accountno.Enabled = false;
            auto();
        }
    }
}
