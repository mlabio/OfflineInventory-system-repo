﻿using System;
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
    public partial class Transaction : Form
    {
        SQL Record;
        DataTable dt, dt2, dt3;
        string lbl_product_id = "", lbl_product_to_remove = "", lbl_cart_id = "";
        int count = 0;
        int rowIndex = -1;
        public Transaction()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                count = count + 1;
                btn_savetransaction.Enabled = true;
                btn_clear.Enabled = true;
                //dtg_cart.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_discount.Text, txt_qty.Text, textBox1.Text);
                foreach (DataGridViewRow row in this.dtg_cart.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(textBox1.Text))
                    {
                        rowIndex = row.Index;
                        //this.dt.Rows.RemoveAt(rowIndex);
                    }
                }
                if (rowIndex == -1)
                {
                    dt3.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_discount.Text, txt_qty.Text, textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Product already exists in your cart.");
                }
            }
            clearFields();
            
        }
        public void clearFields()
        {
            txt_product.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
            txt_discount.Text = "";
            txt_stock.Text = "";
            lbl_product_id = "";
            textBox1.Text = "";
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            clearFields();
            loadRecords();
        }

        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM Products");

            dtg_products.DataSource = dt;

            dtg_products.Columns[0].Visible = false;
            dtg_products.Columns[1].HeaderText = "Product Name";
            dtg_products.Columns[2].HeaderText = "Description";
            dtg_products.Columns[3].Visible = false;
            dtg_products.Columns[4].HeaderText = "SKU";
            dtg_products.Columns[5].Visible = false;
            dtg_products.Columns[6].Visible = false;
            dtg_products.Columns[7].Visible = false;
            dtg_products.Columns[8].Visible = false;
            dtg_products.Columns[9].Visible = false;
            dtg_products.Columns[10].Visible = false;
            dtg_products.Columns[11].Visible = false;

            dt3 = new DataTable();
            dt3.Columns.Add("Product");
            dt3.Columns.Add("Price");
            dt3.Columns.Add("Stock");
            dt3.Columns.Add("Qty");
            dt3.Columns.Add("Discount");
            dt3.Columns.Add("Id");
            dtg_cart.DataSource = dt3;

            dtg_cart.Columns[5].Visible = false;
        }

        public void clearCart()
        {
            dt = new DataTable();
            dtg_cart.DataSource = dt;

            dtg_cart.Columns[0].HeaderText = "Product Name";
            dtg_cart.Columns[1].HeaderText = "Price";
            dtg_cart.Columns[2].HeaderText = "Stock";
            dtg_cart.Columns[3].HeaderText = "Qty";
            dtg_cart.Columns[4].HeaderText = "Discount";
            dtg_cart.Columns[5].Visible = false;
        }

        private void dtg_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dtg_cart.Rows[i];

                lbl_cart_id = row.Cells[0].Value.ToString();

                if (lbl_cart_id != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    //dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId = " + Convert.ToInt32(lbl_product_id));
                    //txt_product.Text = dt.Rows[0]["productName"].ToString();
                    //txt_stock.Text = dt.Rows[0]["productQty"].ToString();
                    //txt_price.Text = dt.Rows[0]["productPrice"].ToString();
                }
                else
                {
                    clearFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear you cart?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                count = 0;
                btn_savetransaction.Enabled = false;
                btn_clear.Enabled = false;
                clearCart();

            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
                //this.Close();
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("You cart is empty!");
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();

                String insert_statement =
                    "INSERT INTO Transactions(transactionDate, isDeleted, totalAmount, isPaid, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES('"
                    + DateTime.Now.ToShortDateString() + "', 0, 0, 0,'"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(insert_statement);
                MessageBox.Show("Transaction created successfully!");
                
                //GET THE inventory_delivery_id of the inventory request
                string test = "SELECT TOP 1 * from Transactions WHERE isPaid = 0 and isDeleted = 0 ORDER BY CONVERT(DATETIME,CREATE_DATE,20) DESC";
                dt2 = Record.SELECT_STATEMENT(test);

                string transactionId = dt2.Rows[0]["transactionId"].ToString();
                int tran_id = Convert.ToInt32(transactionId);
                float totalAmount = 0;

                int temp = (dtg_cart.RowCount);
                for (int i = 0; i < temp; i++)
                {
                    string productName = (string)dtg_cart[0, i].Value;
                    string productPrice = (string)dtg_cart[1, i].Value;
                    string productStock = (string)dtg_cart[2, i].Value;
                    string productQty = (string)dtg_cart[3, i].Value;
                    string productDiscount = (string)dtg_cart[4, i].Value;
                    string productId = (string)dtg_cart[5, i].Value;
                    float discountedPrice = float.Parse(productQty) * (float.Parse(productPrice) / (float.Parse(productDiscount) / 100));
                    totalAmount += discountedPrice;

                    //SAVING SA DATABASE - creation of inventory delivery items
                    String insert_prod_transaction =
                        "INSERT INTO TransactionProducts(productId, discountPercent, originalPrice, discountedPrice, quantity, transactionId, CREATE_DATE, LAST_UPDATE_DATE)"
                        + "VALUES("
                        + Convert.ToInt32(productId) + ", "
                        + float.Parse(productDiscount) + ","
                        + float.Parse(productPrice) + ","
                        + discountedPrice + ","
                        + Convert.ToInt32(productQty) + ","
                        + tran_id + ",'"
                        + DateTime.Now.ToShortDateString() + "','"
                        + DateTime.Now.ToShortDateString() + "')";

                    Record.CUD_STATEMENT(insert_prod_transaction);
                }
                //UPDATE inventory_request_item  total_quantity_delivered and item_status = "Delivered"
                String update_trans_statement = "UPDATE Transactions SET totalAmount=" + totalAmount + ",LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transactionId=" + tran_id + "";
                Record.CUD_STATEMENT(update_trans_statement);

                Payment h = new Payment();
                h.txt_transactionId.Text = tran_id.ToString();
                h.MdiParent = MdiParent;
                
                totalAmount = 0;
                count = 0;
                //clearCart();
                h.Show();
                this.Close();

            }
        }

        private void dtg_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dtg_products.Rows[i];

                lbl_product_id = row.Cells[0].Value.ToString();
                textBox1.Text = dt.Rows[0]["productId"].ToString();

                if (lbl_product_id != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId = " + Convert.ToInt32(lbl_product_id));
                    txt_product.Text = dt.Rows[0]["productName"].ToString();
                    txt_stock.Text = dt.Rows[0]["productQty"].ToString();
                    txt_price.Text = dt.Rows[0]["productPrice"].ToString();
                }
                else
                {
                    clearFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }
    }
}
