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
    public partial class frmreserve : Form
    {
        public frmreserve(string codecustomer)
        {
            InitializeComponent();
            cmbmoshtari.Text = codecustomer;
        }

        private void frmreserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.FillByflag(this.hotelDataSet1.tbl_room);
            // TODO: This line of code loads data into the 'hotelDataSet1.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet1.tbl_customer);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_reserve' table. You can move, or remove it, as needed.
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);
            txtcode.Text = tbl_reserveTableAdapter.getmaxcode().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbl_reserveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_reserveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_reserveTableAdapter.InsertQuery(txtcode.Text, faDatePicker1.Text, faDatePicker2.Text, cmbotagh.Text, cmbmoshtari.Text, txtmadrak.Text, 0, 0, 0);
            tbl_reserveTableAdapter.FillBycode(hotelDataSet.tbl_reserve, txtcode.Text);

            fishreserve rpt = new fishreserve();
            rpt.SetDataSource(hotelDataSet);
            report frm = new report();
            frm.Owner = this;
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Show();

            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
            tbl_roomTableAdapter.upflag(cmbmoshtari.Text, txtcode.Text);
            //MessageBox.Show("رزرو انجام شد.لطفا پرداختی های مشتری را از طریق همین فرم ثبت کنید","انجام شد",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            txtcode.Text = tbl_reserveTableAdapter.getmaxcode().ToString();
            
            txtmadrak.Clear();
            cmbmoshtari2.Focus();
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            int date =int.Parse( tbl_reserveTableAdapter.getdatediff(txtcodesearch.Text).ToString());

            decimal jamekol = date * decimal.Parse(lblgheymat.Text);

            lbljamekol.Text = jamekol.ToString();

            txtbaghimandeh.Text = tbl_reserveTableAdapter.getbaghimandeh(txtcodesearch.Text).ToString();
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
	{
        tbl_reserveTableAdapter.uppardakht(0, decimal.Parse(txtpardakhti.Text), txtcodesearch.Text);
        MessageBox.Show("پرداخت انجام شد");
        tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
        txtbaghimandeh.Text = tbl_reserveTableAdapter.getbaghimandeh(txtcodesearch.Text).ToString() ;
	}
            else
            {
                tbl_reserveTableAdapter.uppardakht(decimal.Parse(lbljamekol.Text), decimal.Parse(txtpardakhti.Text), txtcodesearch.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
                txtbaghimandeh.Text = tbl_reserveTableAdapter.getbaghimandeh(txtcodesearch.Text).ToString();
            }
        }

        private void خالیکردناتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.upflag("1", dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("اتاق خالی شد");
            tbl_roomTableAdapter.FillByflag(hotelDataSet.tbl_room);

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmcustomer().Show();
            
        }

        private void frmreserve_Activated(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
        }

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهید حذف کنید؟در صورت حذف اطلاعات غیر قابل بازیابی خواهد بود.","اخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                tbl_reserveTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهید حذف کنید؟در صورت حذف اطلاعات غیر قابل بازیابی خواهد بود.", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_reserveTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmupdatereserve(dataGridViewX1.CurrentRow.Cells["code"].Value.ToString()).ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
