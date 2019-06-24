using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int product_status, product_id, brand_id, supplier_id;
        public Product_Detail()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_name.MaxLength = 30;
            txt_description.MaxLength = 30;
            txt_sku.MaxLength = 20;
            txt_price.MaxLength = 12;
            txt_qty.MaxLength = 12;
        }

        private void Product_Detail_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            //Populate brand
            dt = getBrands("All"); //ALL

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Brands!");
                this.Close();
            }
            else
            {
                for (int counter = 0; counter < dt.Rows.Count; counter++)
                {
                    string brandName = dt.Rows[counter]["brandName"].ToString();
                    this.cmb_brand.Items.Add(brandName);
                }
            }
            

            dt = getSuppliers("All"); //ALL
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Suppliers!");
                this.Close();
            }
            else
            {
                for (int counter = 0; counter < dt.Rows.Count; counter++)
                {
                    string supplierName = dt.Rows[counter]["supplierName"].ToString();
                    this.cmb_supplier.Items.Add(supplierName);
                }
            }
            
            if (lbl_product_id.Text == "")
            {
                clearProductFields();
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
                dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId=" + Convert.ToInt32(lbl_product_id.Text));
                txt_name.Text = dt.Rows[0]["productName"].ToString();
                txt_description.Text = dt.Rows[0]["productDescription"].ToString();
                product_status = Convert.ToInt32(dt.Rows[0]["productStatus"].ToString());
                brand_id = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                supplier_id = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                cmb_supplier.Text = getSpecificSupplier(supplier_id);
                cmb_brand.Text = getSpecificBrand(brand_id);
                if (product_status == 1)
                {
                    rb_active.Checked = true;
                    rb_inactive.Checked = false;
                }
                else
                {
                    rb_active.Checked = false;
                    rb_inactive.Checked = true;
                }
                txt_price.Text = dt.Rows[0]["productPrice"].ToString();
                txt_sku.Text = dt.Rows[0]["productSKU"].ToString();
                txt_qty.Text = dt.Rows[0]["productQty"].ToString();

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

            String statement = "";
            if (lbl_product_id.Text == "")
            {
                statement =
                "INSERT INTO Products(productName, productDescription, productStatus, productSKU, productPrice, productQty, brandId, supplierId, CREATE_DATE, LAST_UPDATE_DATE)"
                + " VALUES('"
                + txt_name.Text + "','"
                + txt_description.Text + "',"
                + status + ",'"
                + txt_sku.Text + "','"
                + txt_price.Text + "',"
                + Convert.ToInt32(txt_qty.Text) + ","
                    //+ ImageToBase64(product_image.Image,System.Drawing.Imaging.ImageFormat.Png) + ","
                + supplierId + ","
                + brandId + ",'"
                + DateTime.Now.ToShortDateString() + "','"
                + DateTime.Now.ToShortDateString() + "')";
            }
            else
            {
                statement = "UPDATE Products set productName = '" + txt_name.Text
                    + "', productDescription = '" + txt_description.Text
                    + "', productStatus = " + status
                    + ", productSKU = '" + txt_sku.Text
                    + "', productPrice = '" + txt_price.Text
                    + "', productQty = " + Convert.ToInt32(txt_qty.Text)
                    + ", brandId = " + brandId
                    + ", supplierId = " + supplierId
                    + ", LAST_UPDATE_DATE = '" + DateTime.Now.ToShortDateString()
                    + "' where productId = " + Convert.ToInt32(lbl_product_id.Text)
                    + "";
            }

            Record.CUD_STATEMENT(statement);
            MessageBox.Show("Supplier Detail saved successfully!");
            Record.close();
            clearProductFields();
        }
        public void clearProductFields()
        {
            lbl_product_id.Text = "";
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
        public dynamic getSpecificSupplier(int id)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            conn_string = "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1 AND supplierId = " + id + "";
            dt = Record.SELECT_STATEMENT(conn_string);

            dt = Record.SELECT_STATEMENT(conn_string);
            string supplierName = dt.Rows[0]["supplierName"].ToString();
            return supplierName;
        }

        public dynamic getBrands(string text)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            //Populate supplier
            conn_string = text == "All" ? "SELECT * FROM Brands" + " WHERE brandStatus = 1" : "SELECT * FROM Brands" + " WHERE brandStatus = 1 AND brandName = '" + text + "'";
            dt = Record.SELECT_STATEMENT(conn_string);
            return dt;
        }

        public dynamic getSpecificBrand(int id)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            conn_string = "SELECT * FROM Brands" + " WHERE brandStatus = 1 AND brandId = " + id + "";
            dt = Record.SELECT_STATEMENT(conn_string);

            dt = Record.SELECT_STATEMENT(conn_string);
            string brandName = dt.Rows[0]["brandName"].ToString();
            return brandName;
        }

        //public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        // Convert Image to byte[]
        //        image.Save(ms, format);
        //        byte[] imageBytes = ms.ToArray();

        //        // Convert byte[] to Base64 String
        //        string base64String = Convert.ToBase64String(imageBytes);
        //        return base64String;
        //    }
        //}
    }
}
