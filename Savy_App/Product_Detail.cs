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
            Record = new SQL();
            dt = new DataTable();
            
            //Populate brand
            string brand_conn_string = "SELECT * FROM Brands" + " WHERE brandStatus = 1";
            dt = Record.SELECT_STATEMENT(brand_conn_string);
            for (int counter = 0; counter < dt.Rows.Count; counter++)
            {
                string brandName = dt.Rows[counter]["brandName"].ToString();
                this.cmb_brand.Items.Add(brandName);
            }

            //Populate supplier
            string supplier_conn_string = "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1";
            dt = Record.SELECT_STATEMENT(supplier_conn_string);
            for (int counter = 0; counter < dt.Rows.Count; counter++)
            {
                string supplierName = dt.Rows[counter]["supplierName"].ToString();
                this.cmb_brand.Items.Add(supplierName);
            }
        }
    }
}
