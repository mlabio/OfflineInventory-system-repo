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
    public partial class Supplier_List : Form
    {
        SQL Record;
        DataTable dt;
        public Supplier_List()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Supplier_Detail h = new Supplier_Detail();
            h.MdiParent = MdiParent;
            h.Show();

            this.Close();
        }

        private void Supplier_List_Load(object sender, EventArgs e)
        {
            clearSupplierFields();
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM Suppliers");

            dgv_chart.DataSource = dt;

            dgv_chart.Columns[0].Visible = false;
            dgv_chart.Columns[1].HeaderText = "Supplier Name";
            dgv_chart.Columns[2].HeaderText = "Description";
            dgv_chart.Columns[3].Visible = false;
            dgv_chart.Columns[4].HeaderText = "Address";
            dgv_chart.Columns[5].Visible = false;
            dgv_chart.Columns[6].HeaderText = "Phone #";
            dgv_chart.Columns[7].HeaderText = "Contact Person";
            dgv_chart.Columns[8].Visible = false;
            dgv_chart.Columns[9].Visible = false;
        }

        private void dgv_chart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dgv_chart.Rows[i];

                lbl_supplier_id.Text = row.Cells[0].Value.ToString();

                if (lbl_supplier_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId = " + Convert.ToInt32(lbl_supplier_id.Text));
                    lbl_supplier_name.Text = dt.Rows[0]["supplierName"].ToString();
                    lbl_s_address.Text = dt.Rows[0]["supplierAddress"].ToString();
                    lbl_s_description.Text = dt.Rows[0]["supplierDescription"].ToString();
                    lbl_s_phone.Text = dt.Rows[0]["supplierPhone"].ToString();
                    lbl_s_contactperson.Text = dt.Rows[0]["supplierContactPerson"].ToString();
                    lbl_s_status.Text = dt.Rows[0]["supplierStatus"].ToString() == "1"? "Active": "Not Active";
                }
                else
                {
                    clearSupplierFields();
                }
                
            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }
        public void clearSupplierFields()
        {
            lbl_supplier_name.Text = "Supplier Name";
            lbl_s_address.Text = "";
            lbl_s_description.Text = "";
            lbl_s_phone.Text = "";
            lbl_s_contactperson.Text = "";
            lbl_s_status.Text = "";
            lbl_supplier_id.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_supplier_id.Text == "")
            {
                MessageBox.Show("No supplier selected!");
            }
            else
            {
                Supplier_Detail h = new Supplier_Detail();
                h.lbl_supplier_id.Text = lbl_supplier_id.Text;
                h.MdiParent = MdiParent;
                h.Show();

                this.Close();
            }
        }
    }
}
