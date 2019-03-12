using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Savy_App
{
    public partial class Supplier_Detail : Form
    {
        SQL Record;
        DataTable dt;

        public Supplier_Detail()
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
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                Record = new SQL();
                dt = new DataTable();
                int status = rb_active.Checked == true ? 1 : 0;
                int type = rb_store.Checked == true ? 1 : 0;

                String insert_statement =
                    "INSERT INTO Suppliers(supplierName, supplierDescription, supplierStatus, supplierAddress, supplierType, supplierPhone, supplierContactPerson, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES('"
                    + txt_name.Text + "','"
                    + txt_description.Text + "',"
                    + status + ",'"
                    + txt_address.Text + "',"
                    + type + ",'"
                    + txt_phone.Text + "','"
                    + txt_contact_person.Text + "','"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(insert_statement);
                MessageBox.Show("Supplier Detail saved successfully!");
                Record.close();
                clearSupplierFields();
            }
        }

        public void clearSupplierFields()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_description.Text = "";
            txt_phone.Text = "";
            txt_contact_person.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            rb_store.Checked = true;
            rb_person.Checked = false;
            dtp_date.Value = DateTime.Now;
        }

        private void nameValidator(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                e.Cancel = true;
                txt_name.Focus();
                nameError.SetError(txt_name, "Please Enter Supplier Name");
            }
            else
            {
                e.Cancel = false;
                nameError.SetError(txt_name, null);
            }
        }

        private void addressValidator(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_address.Text))
            {
                e.Cancel = true;
                addressError.SetError(txt_address, "Please Enter Address Name");
            }
            else
            {
                e.Cancel = false;
                addressError.SetError(txt_address, null);
            }
        }
    }
}
