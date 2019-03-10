using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savy_App
{
    public partial class Product_Detail : Form
    {
        SQL Record;
        DataTable dt;
        public Product_Detail()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Detail_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            
            //Populate brand
            dt = getBrands("All"); //ALL
            for (int counter = 0; counter < dt.Rows.Count; counter++)
            {
                string brandName = dt.Rows[counter]["brandName"].ToString();
                this.cmb_brand.Items.Add(brandName);
            }

            dt = getSuppliers("All"); //ALL
            for (int counter = 0; counter < dt.Rows.Count; counter++)
            {
                string supplierName = dt.Rows[counter]["supplierName"].ToString();
                this.cmb_supplier.Items.Add(supplierName);
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Record = new SQL();
            dt = new DataTable();
            int status = rb_active.Checked == true ? 1 : 0;
            dt = getSuppliers(cmb_supplier.Text);
            int supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
            dt = getBrands(cmb_brand.Text);
            int brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());

            String insert_statement =
                "INSERT INTO Products(productName, productDescription, productStatus, productSKU, productPrice, productQty, brandId, supplierId, CREATE_DATE, LAST_UPDATE_DATE)"
                + " VALUES('"
                + txt_name.Text + "','"
                + txt_description.Text + "',"
                + status + ",'"
                + txt_sku.Text + "','"
                + txt_price.Text + "',"
                + Convert.ToInt32(txt_qty.Text) + ","
                + supplierId + ","
                + brandId + ",'"
                + DateTime.Now.ToShortDateString() + "','"
                + DateTime.Now.ToShortDateString() + "')";

            Record.CUD_STATEMENT(insert_statement);
            MessageBox.Show("Supplier Detail saved successfully!");
            Record.close();
            clearProductFields();
        }
        public void clearProductFields()
        {
            txt_name.Text = "";
            txt_description.Text = "";
            txt_sku.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            dtp_date.Value = DateTime.Now;
            cmb_brand.Text = "";
            cmb_supplier.Text = "";
        }

        public dynamic getSuppliers(string text)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            //Populate brands
            conn_string = text == "All" ? "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1" : "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1 AND supplierName = '" + text + "'";
            dt = Record.SELECT_STATEMENT(conn_string);
            return dt;
        }

        public dynamic getBrands(string text)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            //Populate supplier
            conn_string = text == "All" ? "SELECT * FROM Brands" + " WHERE brandId = 1" : "SELECT * FROM Brands" + " WHERE brandStatus = 1 AND brandName = '" + text + "'";
            dt = Record.SELECT_STATEMENT(conn_string);
            return dt;
        }

    }
}
