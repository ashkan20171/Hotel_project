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
    public partial class frmroom : Form
    {
        public frmroom()
        {
            InitializeComponent();
        }

        private void tbl_roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void frmroom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.InsertQuery(txtcode.Text, int.Parse(txttakht.Text), int.Parse(txtmasahat.Text), decimal.Parse(txtgheymat.Text), txtemkanat.Text, txttozihat.Text, "1");
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            MessageBox.Show("اطلاعات مربوط به اتاق ثبت شد.حال می توانید برای آن رزرو را انجام دهید.");
            txtcode.Text = tbl_roomTableAdapter.getmaxcode().ToString();
            txtemkanat.Clear();
            txtgheymat.Clear();
            txtmasahat.Clear();
            txttakht.Clear();
            txttozihat.Clear();
            txttakht.Focus();
            
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX7_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX7.Text == "")
            {
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
            else
            {
                tbl_roomTableAdapter.FillBycode(hotelDataSet.tbl_room, textBoxX7.Text);
            }
        }

        private void textBoxX8_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX8.Text == "")
            {
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
            else
            {
                tbl_roomTableAdapter.FillBygheymat(hotelDataSet.tbl_room,decimal.Parse( textBoxX8.Text));
            }
        }

        private void textBoxX9_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX9.Text == "")
            {
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
            else
            {
                tbl_roomTableAdapter.FillBytakht(hotelDataSet.tbl_room,int.Parse(txttakht.Text));
            }
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_roomupdate(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();

        }

        private void frmroom_Activated(object sender, EventArgs e)
        {
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهید حذف کنید؟در صورت حذف اطلاعات غیر قابل بازیابی خواهد بود","اخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                tbl_roomTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
        }

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهید حذف کنید؟در صورت حذف اطلاعات غیر قابل بازیابی خواهد بود", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_roomTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void اتاقرزرونیستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.upflag("1", dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
