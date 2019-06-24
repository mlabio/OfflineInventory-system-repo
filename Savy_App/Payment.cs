using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Savy_App
{
    public partial class Payment : Form
    {
        SQL Record;
        DataTable dt,dt2,dt3;
        public Payment()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM TransactionProducts WHERE transactionId="+ Convert.ToInt32(txt_transactionId.Text) +"");
            dtg_products.DataSource = dt;
            txt_change.Text = "0.00";

            //dtg_products.Columns[0].Visible = false;
            //dtg_products.Columns[1].HeaderText = "Product Name";
            //dtg_products.Columns[2].HeaderText = "Description";
            //dtg_products.Columns[3].Visible = false;
            //dtg_products.Columns[4].HeaderText = "SKU";
            //dtg_products.Columns[5].Visible = false;
            //dtg_products.Columns[6].Visible = false;
            //dtg_products.Columns[7].Visible = false;
            //dtg_products.Columns[8].Visible = false;
            //dtg_products.Columns[9].Visible = false;
            //dtg_products.Columns[10].Visible = false;
            //dtg_products.Columns[11].Visible = false;

            //dt2 = new DataTable();
            //dt2 = Record.SELECT_STATEMENT("SELECT * FROM Transactions WHERE transactionId=" + Convert.ToInt32(txt_transactionId.Text) + "");
            //string transactionId = dt2.Rows[0]["transactionId"].ToString();
            //txt_transnum.Text = transactionId;
            //txt_totalamount.Text = dt2.Rows[0]["totalAmount"].ToString();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            loadRecords();
        }

        private void btn_savetransaction_Click(object sender, EventArgs e)
        {
            if (txt_payment.Text!= "")
            {
                Record = new SQL();
                dt = new DataTable();

                String insert_statement =
                    "INSERT INTO Payment(transactionId, totalAmount, amountPaid, change, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES("
                    + txt_transactionId.Text + ","
                    + txt_totalamount.Text + ","
                    + txt_payment.Text + ","
                    + txt_change.Text + ",'"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(insert_statement);
                MessageBox.Show("Payment saved successfully!");
                Record.close();

                showReport();
                this.Close();
            }
            
        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {
            float diff = float.Parse(txt_totalamount.Text) - float.Parse(txt_payment.Text);
            if (diff < 0)
            {
                txt_change.Text = "0.00";
            }
            else
            {
                txt_change.Text = diff.ToString();
            }
        }
        public void showReport()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("Receipt.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions ;
            ParameterFieldDefinition crParameterFieldDefinition ;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = txt_transactionId.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["transId"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crv_1.ReportSource = cryRpt;
            crv_1.Refresh(); 
        }
    }
}
