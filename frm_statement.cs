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
    public partial class frm_statement : Form
    {
        public static string account;

        Connection conn = new Connection();

        public frm_statement()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main fm = new frm_main();
            fm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_statement_Load(object sender, EventArgs e)
        {
            loadaccountno();
            loadstatement();
        }

        private void loadstatement()
        {
            SqlConnection con = new SqlConnection(conn.db);

            con.Open();

            String str = "Select * From v_statement Where accountno = '" + lbl_accountno.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            ds_View_Statement dstp = new ds_View_Statement();

            sda.Fill(dstp, "v_statement");

            CR_Statement CRQ = new CR_Statement();

            CRQ.SetDataSource(dstp);

            crystalReportViewer1.ReportSource = CRQ;

            crystalReportViewer1.Refresh();

            dstp.Dispose();

            sda.Dispose();

            con.Close();
           
        }

        private void loadaccountno()
        {
            account = frm_main.account_no;

            lbl_accountno.Text = account;
        }
       
    }
}
