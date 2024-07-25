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
    public partial class frm_main : Form
    {
        public static string account_no;

        Connection conn = new Connection();

        SqlCommand cmd;

        public frm_main()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login fl = new frm_login();
            fl.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_balance fb = new frm_balance();
            fb.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_balance fb = new frm_balance();
            fb.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_deposti fd = new frm_deposti();
            fd.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_deposti fd = new frm_deposti();
            fd.ShowDialog();
       
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_withdraw fw = new frm_withdraw();
            fw.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_withdraw fw = new frm_withdraw();
            fw.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_statement fs = new frm_statement();
            fs.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_statement fs = new frm_statement();
            fs.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_transection ft = new frm_transection();
            ft.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_transection ft = new frm_transection();
            ft.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_changepin fc = new frm_changepin();
            fc.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_changepin fc = new frm_changepin();
            fc.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            account_no = frm_login.accountno;

            lbl_accountno.Text = account_no;

            loadaccount();
        }

        private void lbl_accountno_Click(object sender, EventArgs e)
        {
            
        }

        private void loadaccount()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select yourname,dob From account Where accountno = '" + lbl_accountno.Text + "'";

                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_username.Text = dr.GetValue(0).ToString();
                    lbl_date.Text = dr.GetValue(1).ToString();
                }

                con.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
