namespace Savy_App
{
    partial class Product_List
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
            this.btn_close = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Transaction = new System.Windows.Forms.Label();
            this.lbl_p_price = new System.Windows.Forms.Label();
            this.Name_ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_product_price = new System.Windows.Forms.Label();
            this.lbl_p_SKU = new System.Windows.Forms.Label();
            this.lbl_product_sku = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_p_supplier = new System.Windows.Forms.Label();
            this.lbl_product_supplier = new System.Windows.Forms.Label();
            this.lbl_product_availability = new System.Windows.Forms.Label();
            this.lbl_p_availability = new System.Windows.Forms.Label();
            this.lbl_p_description = new System.Windows.Forms.Label();
            this.lbl_product_desc = new System.Windows.Forms.Label();
            this.lbl_product_brand = new System.Windows.Forms.Label();
            this.lbl_p_brand = new System.Windows.Forms.Label();
            this.lbl_p_quantity = new System.Windows.Forms.Label();
            this.lbl_product_qty = new System.Windows.Forms.Label();
            this.dgv_chart = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(1153, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 33);
            this.btn_close.TabIndex = 422;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel6.Controls.Add(this.Transaction);
            this.panel6.Location = new System.Drawing.Point(406, 60);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(782, 41);
            this.panel6.TabIndex = 420;
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.BackColor = System.Drawing.Color.Transparent;
            this.Transaction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.White;
            this.Transaction.Location = new System.Drawing.Point(21, 7);
            this.Transaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(201, 28);
            this.Transaction.TabIndex = 358;
            this.Transaction.Text = "Manage Products";
            // 
            // lbl_p_price
            // 
            this.lbl_p_price.AutoSize = true;
            this.lbl_p_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_price.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_price.Location = new System.Drawing.Point(185, 37);
            this.lbl_p_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_price.Name = "lbl_p_price";
            this.lbl_p_price.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_price.TabIndex = 374;
            this.lbl_p_price.Text = "Section";
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.BackColor = System.Drawing.Color.Transparent;
            this.Name_.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(94, 81);
            this.Name_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(0, 23);
            this.Name_.TabIndex = 414;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_product_name);
            this.panel1.Controls.Add(this.lbl_product_id);
            this.panel1.Location = new System.Drawing.Point(14, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 38);
            this.panel1.TabIndex = 416;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(17, 4);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(168, 28);
            this.lbl_product_name.TabIndex = 348;
            this.lbl_product_name.Text = "Product Name";
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_id.Location = new System.Drawing.Point(292, 12);
            this.lbl_product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(91, 17);
            this.lbl_product_id.TabIndex = 398;
            this.lbl_product_id.Text = "Product\'s ID:";
            this.lbl_product_id.Visible = false;
            // 
            // lbl_product_price
            // 
            this.lbl_product_price.AutoSize = true;
            this.lbl_product_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_price.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_price.Location = new System.Drawing.Point(18, 37);
            this.lbl_product_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_price.Name = "lbl_product_price";
            this.lbl_product_price.Size = new System.Drawing.Size(60, 22);
            this.lbl_product_price.TabIndex = 370;
            this.lbl_product_price.Text = "Price :";
            // 
            // lbl_p_SKU
            // 
            this.lbl_p_SKU.AutoSize = true;
            this.lbl_p_SKU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_SKU.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_SKU.Location = new System.Drawing.Point(185, 7);
            this.lbl_p_SKU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_SKU.Name = "lbl_p_SKU";
            this.lbl_p_SKU.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_SKU.TabIndex = 373;
            this.lbl_p_SKU.Text = "Section";
            // 
            // lbl_product_sku
            // 
            this.lbl_product_sku.AutoSize = true;
            this.lbl_product_sku.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_sku.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_sku.Location = new System.Drawing.Point(18, 6);
            this.lbl_product_sku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_sku.Name = "lbl_product_sku";
            this.lbl_product_sku.Size = new System.Drawing.Size(52, 22);
            this.lbl_product_sku.TabIndex = 369;
            this.lbl_product_sku.Text = "SKU :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_p_supplier);
            this.panel4.Controls.Add(this.lbl_product_supplier);
            this.panel4.Controls.Add(this.lbl_product_availability);
            this.panel4.Controls.Add(this.lbl_p_availability);
            this.panel4.Controls.Add(this.lbl_p_description);
            this.panel4.Controls.Add(this.lbl_product_desc);
            this.panel4.Controls.Add(this.lbl_product_brand);
            this.panel4.Controls.Add(this.lbl_p_brand);
            this.panel4.Controls.Add(this.lbl_p_quantity);
            this.panel4.Controls.Add(this.lbl_product_qty);
            this.panel4.Controls.Add(this.lbl_p_SKU);
            this.panel4.Controls.Add(this.lbl_product_sku);
            this.panel4.Controls.Add(this.lbl_product_price);
            this.panel4.Controls.Add(this.lbl_p_price);
            this.panel4.Location = new System.Drawing.Point(14, 97);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 655);
            this.panel4.TabIndex = 419;
            // 
            // lbl_p_supplier
            // 
            this.lbl_p_supplier.AutoSize = true;
            this.lbl_p_supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_supplier.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_supplier.Location = new System.Drawing.Point(185, 163);
            this.lbl_p_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_supplier.Name = "lbl_p_supplier";
            this.lbl_p_supplier.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_supplier.TabIndex = 386;
            this.lbl_p_supplier.Text = "Section";
            // 
            // lbl_product_supplier
            // 
            this.lbl_product_supplier.AutoSize = true;
            this.lbl_product_supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_supplier.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_supplier.Location = new System.Drawing.Point(18, 162);
            this.lbl_product_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_supplier.Name = "lbl_product_supplier";
            this.lbl_product_supplier.Size = new System.Drawing.Size(88, 22);
            this.lbl_product_supplier.TabIndex = 384;
            this.lbl_product_supplier.Text = "Supplier :";
            // 
            // lbl_product_availability
            // 
            this.lbl_product_availability.AutoSize = true;
            this.lbl_product_availability.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_availability.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_availability.Location = new System.Drawing.Point(18, 194);
            this.lbl_product_availability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_availability.Name = "lbl_product_availability";
            this.lbl_product_availability.Size = new System.Drawing.Size(109, 22);
            this.lbl_product_availability.TabIndex = 385;
            this.lbl_product_availability.Text = "Availability :";
            // 
            // lbl_p_availability
            // 
            this.lbl_p_availability.AutoSize = true;
            this.lbl_p_availability.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_availability.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_availability.Location = new System.Drawing.Point(185, 194);
            this.lbl_p_availability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_availability.Name = "lbl_p_availability";
            this.lbl_p_availability.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_availability.TabIndex = 387;
            this.lbl_p_availability.Text = "Section";
            // 
            // lbl_p_description
            // 
            this.lbl_p_description.AutoSize = true;
            this.lbl_p_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_description.Location = new System.Drawing.Point(185, 101);
            this.lbl_p_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_description.Name = "lbl_p_description";
            this.lbl_p_description.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_description.TabIndex = 380;
            this.lbl_p_description.Text = "Section";
            // 
            // lbl_product_desc
            // 
            this.lbl_product_desc.AutoSize = true;
            this.lbl_product_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_desc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_desc.Location = new System.Drawing.Point(18, 100);
            this.lbl_product_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_desc.Name = "lbl_product_desc";
            this.lbl_product_desc.Size = new System.Drawing.Size(113, 22);
            this.lbl_product_desc.TabIndex = 378;
            this.lbl_product_desc.Text = "Description :";
            // 
            // lbl_product_brand
            // 
            this.lbl_product_brand.AutoSize = true;
            this.lbl_product_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_brand.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_brand.Location = new System.Drawing.Point(18, 132);
            this.lbl_product_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_brand.Name = "lbl_product_brand";
            this.lbl_product_brand.Size = new System.Drawing.Size(70, 22);
            this.lbl_product_brand.TabIndex = 379;
            this.lbl_product_brand.Text = "Brand :";
            // 
            // lbl_p_brand
            // 
            this.lbl_p_brand.AutoSize = true;
            this.lbl_p_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_brand.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_brand.Location = new System.Drawing.Point(185, 132);
            this.lbl_p_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_brand.Name = "lbl_p_brand";
            this.lbl_p_brand.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_brand.TabIndex = 381;
            this.lbl_p_brand.Text = "Section";
            // 
            // lbl_p_quantity
            // 
            this.lbl_p_quantity.AutoSize = true;
            this.lbl_p_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_quantity.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_quantity.Location = new System.Drawing.Point(185, 69);
            this.lbl_p_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_quantity.Name = "lbl_p_quantity";
            this.lbl_p_quantity.Size = new System.Drawing.Size(68, 22);
            this.lbl_p_quantity.TabIndex = 377;
            this.lbl_p_quantity.Text = "Section";
            // 
            // lbl_product_qty
            // 
            this.lbl_product_qty.AutoSize = true;
            this.lbl_product_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_qty.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_qty.Location = new System.Drawing.Point(18, 68);
            this.lbl_product_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_qty.Name = "lbl_product_qty";
            this.lbl_product_qty.Size = new System.Drawing.Size(89, 22);
            this.lbl_product_qty.TabIndex = 375;
            this.lbl_product_qty.Text = "Quantity :";
            // 
            // dgv_chart
            // 
            this.dgv_chart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chart.Location = new System.Drawing.Point(406, 98);
            this.dgv_chart.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_chart.Name = "dgv_chart";
            this.dgv_chart.ReadOnly = true;
            this.dgv_chart.RowHeadersVisible = false;
            this.dgv_chart.Size = new System.Drawing.Size(782, 654);
            this.dgv_chart.TabIndex = 417;
            this.dgv_chart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chart_CellClick);
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
            this.btn_delete.Location = new System.Drawing.Point(798, 758);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(390, 48);
            this.btn_delete.TabIndex = 426;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edit.Location = new System.Drawing.Point(406, 758);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(390, 48);
            this.btn_edit.TabIndex = 424;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_add.Location = new System.Drawing.Point(14, 758);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(390, 48);
            this.btn_add.TabIndex = 425;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Product_List
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
            this.Name = "Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_List";
            this.Load += new System.EventHandler(this.Product_List_Load);
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

        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label Transaction;
        public System.Windows.Forms.Label lbl_p_price;
        public System.Windows.Forms.Label Name_;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_product_id;
        public System.Windows.Forms.Label lbl_product_price;
        public System.Windows.Forms.Label lbl_p_SKU;
        public System.Windows.Forms.Label lbl_product_sku;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lbl_p_quantity;
        public System.Windows.Forms.Label lbl_product_qty;
        public System.Windows.Forms.DataGridView dgv_chart;
        public System.Windows.Forms.Label lbl_p_supplier;
        public System.Windows.Forms.Label lbl_product_supplier;
        public System.Windows.Forms.Label lbl_product_availability;
        public System.Windows.Forms.Label lbl_p_availability;
        public System.Windows.Forms.Label lbl_p_description;
        public System.Windows.Forms.Label lbl_product_desc;
        public System.Windows.Forms.Label lbl_product_brand;
        public System.Windows.Forms.Label lbl_p_brand;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_add;
    }
}