namespace Savy_App
{
    partial class Payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crv_1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Receipt1 = new Savy_App.Receipt();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.txt_transnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_savetransaction = new System.Windows.Forms.Button();
            this.dtg_products = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_ = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_transactionId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.crv_1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_change);
            this.groupBox1.Controls.Add(this.txt_totalamount);
            this.groupBox1.Controls.Add(this.txt_transnum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_payment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_savetransaction);
            this.groupBox1.Controls.Add(this.dtg_products);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 590);
            this.groupBox1.TabIndex = 455;
            this.groupBox1.TabStop = false;
            // 
            // crv_1
            // 
            this.crv_1.ActiveViewIndex = 0;
            this.crv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_1.DisplayStatusBar = false;
            this.crv_1.Location = new System.Drawing.Point(361, 15);
            this.crv_1.Name = "crv_1";
            this.crv_1.ReportSource = this.Receipt1;
            this.crv_1.ShowCloseButton = false;
            this.crv_1.ShowCopyButton = false;
            this.crv_1.ShowExportButton = false;
            this.crv_1.ShowGotoPageButton = false;
            this.crv_1.ShowGroupTreeButton = false;
            this.crv_1.ShowLogo = false;
            this.crv_1.ShowPageNavigateButtons = false;
            this.crv_1.ShowParameterPanelButton = false;
            this.crv_1.ShowTextSearchButton = false;
            this.crv_1.ShowZoomButton = false;
            this.crv_1.Size = new System.Drawing.Size(515, 569);
            this.crv_1.TabIndex = 463;
            this.crv_1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 461;
            this.label2.Text = "Change (Php):";
            // 
            // txt_change
            // 
            this.txt_change.Enabled = false;
            this.txt_change.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_change.ForeColor = System.Drawing.Color.Black;
            this.txt_change.Location = new System.Drawing.Point(173, 516);
            this.txt_change.Multiline = true;
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(165, 23);
            this.txt_change.TabIndex = 460;
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Enabled = false;
            this.txt_totalamount.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamount.ForeColor = System.Drawing.Color.Black;
            this.txt_totalamount.Location = new System.Drawing.Point(173, 452);
            this.txt_totalamount.Multiline = true;
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(165, 23);
            this.txt_totalamount.TabIndex = 455;
            // 
            // txt_transnum
            // 
            this.txt_transnum.Enabled = false;
            this.txt_transnum.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transnum.ForeColor = System.Drawing.Color.Black;
            this.txt_transnum.Location = new System.Drawing.Point(123, 426);
            this.txt_transnum.Multiline = true;
            this.txt_transnum.Name = "txt_transnum";
            this.txt_transnum.Size = new System.Drawing.Size(215, 23);
            this.txt_transnum.TabIndex = 454;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 459;
            this.label9.Text = "Total Amount (Php):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 453;
            this.label3.Text = "Payment (Php):";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.ForeColor = System.Drawing.Color.Black;
            this.txt_payment.Location = new System.Drawing.Point(173, 478);
            this.txt_payment.Multiline = true;
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(165, 23);
            this.txt_payment.TabIndex = 452;
            this.txt_payment.TextChanged += new System.EventHandler(this.txt_payment_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 457;
            this.label5.Text = "Transaction No. :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(6, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 33);
            this.panel6.TabIndex = 431;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 358;
            this.label1.Text = "Cart";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(5, 545);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 39);
            this.btn_clear.TabIndex = 450;
            this.btn_clear.Text = "Cancel Transaction";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_savetransaction
            // 
            this.btn_savetransaction.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_savetransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_savetransaction.Enabled = false;
            this.btn_savetransaction.FlatAppearance.BorderSize = 0;
            this.btn_savetransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_savetransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_savetransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savetransaction.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savetransaction.ForeColor = System.Drawing.Color.White;
            this.btn_savetransaction.Location = new System.Drawing.Point(172, 545);
            this.btn_savetransaction.Name = "btn_savetransaction";
            this.btn_savetransaction.Size = new System.Drawing.Size(165, 39);
            this.btn_savetransaction.TabIndex = 434;
            this.btn_savetransaction.Text = "Save Payment";
            this.btn_savetransaction.UseVisualStyleBackColor = false;
            this.btn_savetransaction.Click += new System.EventHandler(this.btn_savetransaction_Click);
            // 
            // dtg_products
            // 
            this.dtg_products.AllowUserToAddRows = false;
            this.dtg_products.AllowUserToDeleteRows = false;
            this.dtg_products.AllowUserToOrderColumns = true;
            this.dtg_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_products.BackgroundColor = System.Drawing.Color.Silver;
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_products.Location = new System.Drawing.Point(6, 48);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.ReadOnly = true;
            this.dtg_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtg_products.Size = new System.Drawing.Size(332, 372);
            this.dtg_products.TabIndex = 378;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 462;
            this.label4.Text = "_________________________________";
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.BackColor = System.Drawing.Color.Transparent;
            this.Name_.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(72, 59);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(0, 19);
            this.Name_.TabIndex = 453;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(869, 1);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 27);
            this.btn_close.TabIndex = 454;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_transactionId
            // 
            this.txt_transactionId.Enabled = false;
            this.txt_transactionId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transactionId.ForeColor = System.Drawing.Color.Black;
            this.txt_transactionId.Location = new System.Drawing.Point(12, 4);
            this.txt_transactionId.Multiline = true;
            this.txt_transactionId.Name = "txt_transactionId";
            this.txt_transactionId.Size = new System.Drawing.Size(88, 23);
            this.txt_transactionId.TabIndex = 456;
            this.txt_transactionId.Visible = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._1200x820;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.txt_transactionId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Name_);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_savetransaction;
        private System.Windows.Forms.DataGridView dtg_products;
        public System.Windows.Forms.Label Name_;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_change;
        public System.Windows.Forms.TextBox txt_totalamount;
        public System.Windows.Forms.TextBox txt_transnum;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_payment;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_transactionId;
        public System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_1;
        private Receipt Receipt1;
    }
}