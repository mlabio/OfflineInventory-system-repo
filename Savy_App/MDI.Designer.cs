namespace Savy_App
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_users = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_brands = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_products = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dashboard,
            this.menu_users,
            this.menu_suppliers,
            this.menu_brands,
            this.menu_products,
            this.menu_orders,
            this.menu_reports,
            this.menu_logout});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.menu_orders;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 10, 0, 10);
            this.menuStrip.Size = new System.Drawing.Size(1892, 49);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_dashboard
            // 
            this.menu_dashboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_dashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_dashboard.ForeColor = System.Drawing.Color.White;
            this.menu_dashboard.Name = "menu_dashboard";
            this.menu_dashboard.Size = new System.Drawing.Size(116, 29);
            this.menu_dashboard.Text = "Dashboard";
            this.menu_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_users
            // 
            this.menu_users.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_users.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_users.ForeColor = System.Drawing.Color.White;
            this.menu_users.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menu_users.Name = "menu_users";
            this.menu_users.Size = new System.Drawing.Size(70, 29);
            this.menu_users.Text = "Users";
            this.menu_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_brands
            // 
            this.menu_brands.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_brands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_brands.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_brands.ForeColor = System.Drawing.Color.White;
            this.menu_brands.Name = "menu_brands";
            this.menu_brands.Size = new System.Drawing.Size(82, 29);
            this.menu_brands.Text = "Brands";
            this.menu_brands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_brands.Click += new System.EventHandler(this.menu_brands_Click);
            // 
            // menu_products
            // 
            this.menu_products.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_products.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_products.ForeColor = System.Drawing.Color.White;
            this.menu_products.Name = "menu_products";
            this.menu_products.Size = new System.Drawing.Size(98, 29);
            this.menu_products.Text = "Products";
            this.menu_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_products.Click += new System.EventHandler(this.menu_products_Click);
            // 
            // menu_orders
            // 
            this.menu_orders.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_orders.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_orders.ForeColor = System.Drawing.Color.White;
            this.menu_orders.Name = "menu_orders";
            this.menu_orders.Size = new System.Drawing.Size(81, 29);
            this.menu_orders.Text = "Orders";
            this.menu_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_reports
            // 
            this.menu_reports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_reports.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_reports.ForeColor = System.Drawing.Color.White;
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(87, 29);
            this.menu_reports.Text = "Reports";
            this.menu_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_logout
            // 
            this.menu_logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_logout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_logout.ForeColor = System.Drawing.Color.White;
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(54, 29);
            this.menu_logout.Text = "Exit";
            this.menu_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 969);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1892, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(122, 20);
            this.toolStripStatusLabel.Text = "Savy Store | 2019";
            // 
            // menu_suppliers
            // 
            this.menu_suppliers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_suppliers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_suppliers.ForeColor = System.Drawing.Color.White;
            this.menu_suppliers.Name = "menu_suppliers";
            this.menu_suppliers.Size = new System.Drawing.Size(102, 29);
            this.menu_suppliers.Text = "Suppliers";
            this.menu_suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_suppliers.Click += new System.EventHandler(this.menu_suppliers_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 994);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savy Inventory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menu_users;
        private System.Windows.Forms.ToolStripMenuItem menu_brands;
        private System.Windows.Forms.ToolStripMenuItem menu_products;
        private System.Windows.Forms.ToolStripMenuItem menu_orders;
        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menu_dashboard;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_suppliers;
    }
}



