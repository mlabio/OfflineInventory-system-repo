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
using CrystalDecisions.ReportSource;
using CrystalDecisions.Web;
using CrystalDecisions.Windows.Forms;

namespace Savy_App
{
    public partial class ViewTransactions : Form
    {
        SQL Record;
        DataTable dt;
        public ViewTransactions()
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
            dt = Record.SELECT_STATEMENT("SELECT * FROM Transactions");

            dataGridView2.DataSource = dt;

            dataGridView2.Columns[0].HeaderText = "Receipt Number";
            dataGridView2.Columns[1].HeaderText = "Date";
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].HeaderText = "Total Amount";
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
        }

        public void clearFields()
        {
            label1.Text = "";
        }
        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            clearFields();
            loadRecords();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dataGridView2.Rows[i];

                label1.Text = dt.Rows[0]["transactionId"].ToString();
            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("transactionId = {0}", Convert.ToInt32(txt_search.Text));
                dataGridView2.DataSource = dv;
            }
            else
            {
                dataGridView2.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                showReport();
            }
        }
        public void showReport()
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("D:" + "\\" + "OfflineInventory-system-repo" + "\\" + "Savy_App" + "\\" + "Receipt.rpt");

            crConnectionInfo.ServerName = "ASUS-PC" + "\\" + "MSSQL";
            crConnectionInfo.DatabaseName = "SavyPOS_DB";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "sql";
            crConnectionInfo.IntegratedSecurity = true;
            //cryRpt.SetParameterValue("transId", label1.Text);

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = label1.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["transId"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            cryRpt.SetDataSource(CrTables);

            crv_1.ReportSource = cryRpt;
            crv_1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("No Receipt Number is selected!");
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();


                ReturnProducts h = new ReturnProducts();
                h.label1.Text = label1.Text;
                h.MdiParent = MdiParent;

                h.Show();
                this.Close();

            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
    }
}
