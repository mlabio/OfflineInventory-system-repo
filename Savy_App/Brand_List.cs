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
    public partial class Brand_List : Form
    {
        SQL Record;
        DataTable dt;
        public Brand_List()
        {
            InitializeComponent();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Brand_Details h = new Brand_Details();
            h.MdiParent = MdiParent;
            h.Show();

            this.Close();
        }

        private void Brand_List_Load(object sender, EventArgs e)
        {
            clearBrandFields();
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM Brands");

            dgv_chart.DataSource = dt;

            dgv_chart.Columns[0].Visible = false;
            dgv_chart.Columns[1].HeaderText = "Brand Name";
            dgv_chart.Columns[2].HeaderText = "Description";
            dgv_chart.Columns[3].Visible = false;
            dgv_chart.Columns[4].Visible = false;
            dgv_chart.Columns[5].Visible = false;
        }

        private void dgv_chart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dgv_chart.Rows[i];

                lbl_brand_id.Text = row.Cells[0].Value.ToString();

                if (lbl_brand_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId = " + Convert.ToInt32(lbl_brand_id.Text));
                    lbl_brand_name.Text = dt.Rows[0]["brandName"].ToString();
                    lbl_b_description.Text = dt.Rows[0]["brandDescription"].ToString();
                    lbl_b_status.Text = dt.Rows[0]["brandStatus"].ToString() == "1" ? "Active" : "Not Active";
                }
                else
                {
                    clearBrandFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }
        public void clearBrandFields()
        {
            lbl_brand_name.Text = "Brand Name";
            lbl_b_description.Text = "";
            lbl_b_status.Text = "";
        }


    }
}
