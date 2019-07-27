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
    public partial class Product_List : Form
    {
        SQL Record;
        DataTable dt, dt2;
        int brandId = 0, supplierId = 0;
        public Product_List()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product_Detail h = new Product_Detail();
            h.MdiParent = MdiParent;
            h.Show();

            this.Close();
        }

        private void Product_List_Load(object sender, EventArgs e)
        {
            clearProductFields();
            loadRecords();
        }

        public void clearProductFields()
        {
            lbl_product_name.Text = "Product Name";
            lbl_p_description.Text = "";
            lbl_p_price.Text = "";
            lbl_p_quantity.Text = "";
            lbl_p_SKU.Text = "";
            lbl_p_availability.Text = "";
            lbl_p_supplier.Text = "";
            lbl_p_brand.Text = "";
        }
        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM Products");

            dgv_chart.DataSource = dt;

            dgv_chart.Columns[0].Visible = false;
            dgv_chart.Columns[1].HeaderText = "Product Name";
            dgv_chart.Columns[2].HeaderText = "Description";
            dgv_chart.Columns[3].Visible = false;
            dgv_chart.Columns[4].HeaderText = "SKU";
            dgv_chart.Columns[5].HeaderText = "Price";
            dgv_chart.Columns[6].HeaderText = "Stock";
            dgv_chart.Columns[7].Visible = false;
            dgv_chart.Columns[8].Visible = false;
            dgv_chart.Columns[9].Visible = false;
            dgv_chart.Columns[10].Visible = false;
            dgv_chart.Columns[11].Visible = false;

            lbl_num_items.Text = dt.Rows.Count.ToString();

            if (dt.Rows.Count > 0)
            {
                lbl_product_id.Text = dt.Rows[0]["productId"].ToString();
                lbl_product_name.Text = dt.Rows[0]["productName"].ToString();
                lbl_p_description.Text = dt.Rows[0]["productDescription"].ToString();
                lbl_p_price.Text = dt.Rows[0]["productPrice"].ToString();
                lbl_p_quantity.Text = dt.Rows[0]["productQty"].ToString();
                lbl_p_SKU.Text = dt.Rows[0]["productSKU"].ToString();
                lbl_p_availability.Text = dt.Rows[0]["productStatus"].ToString() == "1" ? "True" : "False";
                brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                if (supplierId != 0)
                {
                    Record = new SQL();
                    dt2 = new DataTable();
                    dt2 = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId = " + supplierId);
                    lbl_p_supplier.Text = dt2.Rows[0]["supplierName"].ToString();
                }
                if (brandId != 0)
                {
                    Record = new SQL();
                    dt2 = new DataTable();
                    dt2 = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId = " + brandId);
                    lbl_p_brand.Text = dt2.Rows[0]["brandName"].ToString();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_product_id.Text == "")
            {
                MessageBox.Show("No product selected!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this supplier?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Record = new SQL();

                    string delete_record = "DELETE FROM Products WHERE productId = " + Convert.ToInt32(lbl_product_id.Text);
                    Record.CUD_STATEMENT(delete_record);
                    loadRecords();
                    MessageBox.Show("Product successfully deleted!");
                    clearProductFields();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_product_id.Text == "")
            {
                MessageBox.Show("No product selected!");
            }
            else
            {
                Product_Detail h = new Product_Detail();
                h.lbl_product_id.Text = lbl_product_id.Text;
                h.MdiParent = MdiParent;
                h.Show();

                this.Close();
            }
        }

        private void dgv_chart_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dgv_chart.Rows[i];

                lbl_product_id.Text = row.Cells[0].Value.ToString();

                if (lbl_product_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId = " + Convert.ToInt32(lbl_product_id.Text));
                    lbl_product_name.Text = dt.Rows[0]["productName"].ToString();
                    lbl_p_description.Text = dt.Rows[0]["productDescription"].ToString();
                    lbl_p_price.Text = dt.Rows[0]["productPrice"].ToString();
                    lbl_p_quantity.Text = dt.Rows[0]["productQty"].ToString();
                    lbl_p_SKU.Text = dt.Rows[0]["productSKU"].ToString();
                    lbl_p_availability.Text = dt.Rows[0]["productStatus"].ToString() == "1" ? "True" : "False";
                    brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                    supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                    if (supplierId != 0)
                    {
                        Record = new SQL();
                        dt2 = new DataTable();
                        dt2 = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId = " + supplierId);
                        lbl_p_supplier.Text = dt2.Rows[0]["supplierName"].ToString();
                    }
                    if (brandId != 0)
                    {
                        Record = new SQL();
                        dt2 = new DataTable();
                        dt2 = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId = " + brandId);
                        lbl_p_brand.Text = dt2.Rows[0]["brandName"].ToString();
                    }
                }
                else
                {
                    clearProductFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        
    }
}
