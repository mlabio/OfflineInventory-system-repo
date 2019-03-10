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
    public partial class Brand_List : Form
    {
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

    }
}
