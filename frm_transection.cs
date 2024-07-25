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
    public partial class frm_transection : Form
    {
        public static string account;

        Connection conn = new Connection();

        SqlCommand cmd;

        public frm_transection()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main fm = new frm_main();
            fm.ShowDialog();
        }

        private void transectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_transection);

        }

        private void frm_transection_Load(object sender, EventArgs e)
        {
            account = frm_main.account_no;

            lbl_accountno.Text = account;

            showtransections();

        }

        private void showtransections()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select * From transections Where accountno = '" + lbl_accountno.Text + "'";

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                transectionsDataGridView.DataSource = dt;

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
