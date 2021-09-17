using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel
{
    public partial class frm_updatecustomer : Form
    {
        public frm_updatecustomer(string code)
        {
            InitializeComponent();
            txtcode.Text = code;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_updatecustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.FillBycode(this.hotelDataSet.tbl_customer,txtcode.Text);
       
        }

        private void tbl_customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.UpdateQuery(txtnam.Text, txtfamil.Text, txtcodemelli.Text, txttell.Text, txtmobile.Text, txtcode.Text);
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
