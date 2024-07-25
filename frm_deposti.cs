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
    public partial class frm_deposti : Form
    {
        public static string account;

        Connection conn = new Connection();

        SqlCommand cmd;

        public frm_deposti()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main fm = new frm_main();
            fm.ShowDialog();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {              

                if (txt_addamount.Text == "")
                {
                    MessageBox.Show("Please , Enter Deposti Amount", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update account Set amount = '" + txt_totalamount.Text + "' Where accountno = '" + lbl_accountno.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(amount) From account";

                    SqlCommand cmd1 = new SqlCommand(str1, con);

                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {
                        addtransection();
                        MessageBox.Show("Your Transaction Is Successfull ... ", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadbalance();
                        txt_addamount.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Your Transaction Is Failed ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addtransection()
        {
            try
            {
                    String type = "Deposti";

                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into transections(accountno,name,mobailno,transectiontype,amount,totalamount,date)Values('" + lbl_accountno.Text + "','" + lbl_name.Text + "','" + lbl_mobailno.Text + "','" + type + "','" + txt_addamount.Text + "','" + txt_totalamount.Text + "','" + lbl_date.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(date) From transections";

                    SqlCommand cmd1 = new SqlCommand(str1, con);

                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Your Transaction Is Failed ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();

                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }


        private void loadbalance()
        {
            account = frm_main.account_no;

            lbl_accountno.Text = account;

            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select yourname,mobailno,amount From account Where accountno = '" + lbl_accountno.Text + "'";

                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_name.Text = dr.GetValue(0).ToString();
                    lbl_mobailno.Text = dr.GetValue(1).ToString();
                    lbl_currentamount.Text = dr.GetValue(2).ToString();
                    
                }

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addition()
        {
            try
            {
                if (txt_addamount.Text == "")
                {
                    txt_totalamount.Text = "";
                }
                else 
                {
                    int Sum;

                    Sum = Int32.Parse(txt_addamount.Text) + Int32.Parse(lbl_currentamount.Text);

                    txt_totalamount.Text = Sum.ToString();
                }
            }
            catch (Exception) 
            {

            }
        }

        private void frm_deposti_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString();
            loadbalance();
        }

        private void txt_addamount_TextChanged(object sender, EventArgs e)
        {
            addition();
        }
    }
}
