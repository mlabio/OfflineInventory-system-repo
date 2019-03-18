namespace Savy_App
{
    partial class Brand_List
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
            this.lbl_brand_id = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Transaction = new System.Windows.Forms.Label();
            this.Name_ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_brand_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_brand_description = new System.Windows.Forms.Label();
            this.lbl_b_description = new System.Windows.Forms.Label();
            this.dgv_chart = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_brand_status = new System.Windows.Forms.Label();
            this.lbl_b_status = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_brand_id
            // 
            this.lbl_brand_id.AutoSize = true;
            this.lbl_brand_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_brand_id.Location = new System.Drawing.Point(868, 9);
            this.lbl_brand_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand_id.Name = "lbl_brand_id";
            this.lbl_brand_id.Size = new System.Drawing.Size(81, 17);
            this.lbl_brand_id.TabIndex = 398;
            this.lbl_brand_id.Text = "Brand\'s ID :";
            this.lbl_brand_id.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel6.Controls.Add(this.Transaction);
            this.panel6.Location = new System.Drawing.Point(14, 175);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1174, 41);
            this.panel6.TabIndex = 410;
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.BackColor = System.Drawing.Color.Transparent;
            this.Transaction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.White;
            this.Transaction.Location = new System.Drawing.Point(20, 6);
            this.Transaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(181, 28);
            this.Transaction.TabIndex = 358;
            this.Transaction.Text = "Manage Brands";
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.BackColor = System.Drawing.Color.Transparent;
            this.Name_.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(93, 81);
            this.Name_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(0, 23);
            this.Name_.TabIndex = 399;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_brand_name);
            this.panel1.Controls.Add(this.lbl_brand_id);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 38);
            this.panel1.TabIndex = 401;
            // 
            // lbl_brand_name
            // 
            this.lbl_brand_name.AutoSize = true;
            this.lbl_brand_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_name.Location = new System.Drawing.Point(16, 4);
            this.lbl_brand_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand_name.Name = "lbl_brand_name";
            this.lbl_brand_name.Size = new System.Drawing.Size(148, 28);
            this.lbl_brand_name.TabIndex = 348;
            this.lbl_brand_name.Text = "Brand Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_b_status);
            this.panel4.Controls.Add(this.lbl_brand_status);
            this.panel4.Controls.Add(this.lbl_brand_description);
            this.panel4.Controls.Add(this.lbl_b_description);
            this.panel4.Location = new System.Drawing.Point(13, 97);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 70);
            this.panel4.TabIndex = 407;
            // 
            // lbl_brand_description
            // 
            this.lbl_brand_description.AutoSize = true;
            this.lbl_brand_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_description.Location = new System.Drawing.Point(17, 37);
            this.lbl_brand_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand_description.Name = "lbl_brand_description";
            this.lbl_brand_description.Size = new System.Drawing.Size(109, 22);
            this.lbl_brand_description.TabIndex = 370;
            this.lbl_brand_description.Text = "Description:";
            // 
            // lbl_b_description
            // 
            this.lbl_b_description.AutoSize = true;
            this.lbl_b_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_b_description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b_description.Location = new System.Drawing.Point(184, 37);
            this.lbl_b_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_b_description.Name = "lbl_b_description";
            this.lbl_b_description.Size = new System.Drawing.Size(68, 22);
            this.lbl_b_description.TabIndex = 374;
            this.lbl_b_description.Text = "Section";
            // 
            // dgv_chart
            // 
            this.dgv_chart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chart.Location = new System.Drawing.Point(13, 213);
            this.dgv_chart.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_chart.Name = "dgv_chart";
            this.dgv_chart.ReadOnly = true;
            this.dgv_chart.RowHeadersVisible = false;
            this.dgv_chart.Size = new System.Drawing.Size(1174, 538);
            this.dgv_chart.TabIndex = 402;
            this.dgv_chart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chart_CellClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(1152, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 33);
            this.btn_close.TabIndex = 413;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(798, 759);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(390, 48);
            this.btn_delete.TabIndex = 426;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Orange;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(406, 759);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(390, 48);
            this.btn_edit.TabIndex = 424;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(14, 759);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(390, 48);
            this.btn_add.TabIndex = 425;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_brand_status
            // 
            this.lbl_brand_status.AutoSize = true;
            this.lbl_brand_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_status.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_status.Location = new System.Drawing.Point(17, 7);
            this.lbl_brand_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand_status.Name = "lbl_brand_status";
            this.lbl_brand_status.Size = new System.Drawing.Size(64, 22);
            this.lbl_brand_status.TabIndex = 369;
            this.lbl_brand_status.Text = "Status:";
            // 
            // lbl_b_status
            // 
            this.lbl_b_status.AutoSize = true;
            this.lbl_b_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_b_status.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b_status.Location = new System.Drawing.Point(184, 8);
            this.lbl_b_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_b_status.Name = "lbl_b_status";
            this.lbl_b_status.Size = new System.Drawing.Size(68, 22);
            this.lbl_b_status.TabIndex = 373;
            this.lbl_b_status.Text = "Section";
            // 
            // Brand_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._1200x820;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 820);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Name_);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brand_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_List_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_brand_id;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label Transaction;
        public System.Windows.Forms.Label Name_;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_brand_name;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lbl_brand_description;
        public System.Windows.Forms.Label lbl_b_description;
        public System.Windows.Forms.DataGridView dgv_chart;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Label lbl_b_status;
        public System.Windows.Forms.Label lbl_brand_status;

    }
}