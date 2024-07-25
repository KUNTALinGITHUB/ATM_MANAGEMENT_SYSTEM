namespace ATM_Management_System_Using_Csharp
{
    partial class frm_withdraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_drawamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_mobailno = new System.Windows.Forms.Label();
            this.lbl_accountno = new System.Windows.Forms.Label();
            this.lbl_currentamount = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 41);
            this.label3.TabIndex = 30;
            this.label3.Text = "ATM WITHDRAW";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(228, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 38);
            this.label8.TabIndex = 33;
            this.label8.Text = "Back";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Controls.Add(this.txt_drawamount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(410, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 416);
            this.panel1.TabIndex = 31;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Green;
            this.btn_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(73, 240);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(395, 60);
            this.btn_Submit.TabIndex = 37;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_drawamount
            // 
            this.txt_drawamount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drawamount.Location = new System.Drawing.Point(73, 150);
            this.txt_drawamount.Multiline = true;
            this.txt_drawamount.Name = "txt_drawamount";
            this.txt_drawamount.Size = new System.Drawing.Size(395, 55);
            this.txt_drawamount.TabIndex = 38;
            this.txt_drawamount.TextChanged += new System.EventHandler(this.txt_drawamount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(163, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "WITHDRAW";
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamount.Location = new System.Drawing.Point(66, 402);
            this.txt_totalamount.Multiline = true;
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(276, 55);
            this.txt_totalamount.TabIndex = 39;
            this.txt_totalamount.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(111, 126);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(139, 29);
            this.lbl_name.TabIndex = 41;
            this.lbl_name.Text = "User name";
            this.lbl_name.Visible = false;
            // 
            // lbl_mobailno
            // 
            this.lbl_mobailno.AutoSize = true;
            this.lbl_mobailno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mobailno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobailno.ForeColor = System.Drawing.Color.White;
            this.lbl_mobailno.Location = new System.Drawing.Point(111, 177);
            this.lbl_mobailno.Name = "lbl_mobailno";
            this.lbl_mobailno.Size = new System.Drawing.Size(140, 29);
            this.lbl_mobailno.TabIndex = 42;
            this.lbl_mobailno.Text = "Mobail No.";
            this.lbl_mobailno.Visible = false;
            // 
            // lbl_accountno
            // 
            this.lbl_accountno.AutoSize = true;
            this.lbl_accountno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_accountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountno.ForeColor = System.Drawing.Color.White;
            this.lbl_accountno.Location = new System.Drawing.Point(111, 239);
            this.lbl_accountno.Name = "lbl_accountno";
            this.lbl_accountno.Size = new System.Drawing.Size(146, 29);
            this.lbl_accountno.TabIndex = 43;
            this.lbl_accountno.Text = "Account No";
            this.lbl_accountno.Visible = false;
            // 
            // lbl_currentamount
            // 
            this.lbl_currentamount.AutoSize = true;
            this.lbl_currentamount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentamount.ForeColor = System.Drawing.Color.White;
            this.lbl_currentamount.Location = new System.Drawing.Point(111, 304);
            this.lbl_currentamount.Name = "lbl_currentamount";
            this.lbl_currentamount.Size = new System.Drawing.Size(165, 29);
            this.lbl_currentamount.TabIndex = 44;
            this.lbl_currentamount.Text = "Current Cash";
            this.lbl_currentamount.Visible = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(111, 355);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(144, 29);
            this.lbl_date.TabIndex = 45;
            this.lbl_date.Text = "Date&&Time";
            this.lbl_date.Visible = false;
            // 
            // frm_withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM_Management_System_Using_Csharp.Properties.Resources.Presentation1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_currentamount);
            this.Controls.Add(this.lbl_accountno);
            this.Controls.Add(this.lbl_mobailno);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_totalamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_withdraw";
            this.Load += new System.EventHandler(this.frm_withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_drawamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalamount;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_mobailno;
        private System.Windows.Forms.Label lbl_accountno;
        private System.Windows.Forms.Label lbl_currentamount;
        private System.Windows.Forms.Label lbl_date;
    }
}