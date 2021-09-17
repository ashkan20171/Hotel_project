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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }

        private void tbl_customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            txtcode.Text = tbl_customerTableAdapter.getmaxcode().ToString();
            txtcodemelli.Focus();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.InsertQuery(txtcode.Text, txtnam.Text, txtfamil.Text, txtcodemelli.Text, txttell.Text, txtmobile.Text);
            tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            MessageBox.Show("اطلاعات این مشنری با موفقیت ثبت شد","ثبت انجام شد",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtcode.Text = tbl_customerTableAdapter.getmaxcode().ToString();
            txtcodemelli.Clear();
            txtnam.Clear();
            txtfamil.Clear();
            txttell.Clear();
            txtmobile.Clear();
            txtcodemelli.Focus();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX2.Text == "")
            {
                this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            }

            else
            {
                tbl_customerTableAdapter.Fillmobile(hotelDataSet.tbl_customer, textBoxX2.Text);
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            }
            else
            {
                tbl_customerTableAdapter.Fillcodemelli(hotelDataSet.tbl_customer, textBoxX1.Text);
            }
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_updatecustomer(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog(); ;
        }

        private void frmcustomer_Activated(object sender, EventArgs e)
        {
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
        }

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهیدحذف کنید؟ اطلاعات پس از حذف غیر قابل بازیابی است", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_customerTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells["code"].Value.ToString());
                tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            } 
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهیدحذف کنید؟ اطلاعات پس از حذف غیر قابل بازیابی است", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_customerTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells["code"].Value.ToString());
                tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            }

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  this.Close(); 
            new frmreserve(dataGridViewX1.CurrentRow.Cells["code"].Value.ToString()).Show();
           
        }
    }
}
