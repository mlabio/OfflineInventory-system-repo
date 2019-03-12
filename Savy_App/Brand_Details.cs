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
    public partial class Brand_Details : Form
    {
        SQL Record;
        DataTable dt;
        public Brand_Details()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Record = new SQL();
                dt = new DataTable();
                int status = rb_active.Checked == true ? 1 : 0;

                String insert_statement =
                    "INSERT INTO Brands(brandName, brandDescription, brandStatus, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES('"
                    + txt_name.Text + "','"
                    + txt_description.Text + "',"
                    + status + ",'"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(insert_statement);
                MessageBox.Show("Brand Detail saved successfully!");
                Record.close();
                clearBrandFields();
            }
        }

        public void clearBrandFields()
        {
            txt_name.Text = "";
            txt_description.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            dtp_date.Value = DateTime.Now;
        }

        private void brands_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                e.Cancel = true;
                txt_name.Focus();
                errorProvider1.SetError(txt_name, "Please Enter Brand Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_name, null);
            }
        }
    }
}
