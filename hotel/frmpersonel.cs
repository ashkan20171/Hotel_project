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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }

        private void frmpersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);
            txtcode.Clear();
            txtfamil.Clear();
            txtfieldwork.Clear();
            txtmobile.Clear();
            txtname.Clear();
            txtpw.Clear();
            txttell.Clear();
            txtus.Clear();
            rdo1.Checked = true;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int pre1=0;
            if (rdo1.Checked==true)
            {
                 pre1 = 1;
            }
            if (rdo2.Checked == true)
            {
                 pre1 = 2;
            }
            if (rdo3.Checked == true)
            {
                pre1 = 3;
            }

            tbl_personelTableAdapter.InsertQuery(txtcode.Text, txtname.Text, txtfamil.Text, txttell.Text, txtaddress.Text, txtmobile.Text, txtfieldwork.Text, txtus.Text, txtpw.Text, pre1);
            tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
            MessageBox.Show("این کاربر در نرم افزار ثبت شد");
            txtcode.Clear();
            txtfamil.Clear();
            txtfieldwork.Clear();
            txtmobile.Clear();
            txtname.Clear();
            txtpw.Clear();
            txttell.Clear();
            txtus.Clear();

        }

        private void dataGridViewX1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            int pre1 = 0;
            if (rdo1.Checked == true)
            {
                pre1 = 1;
            }
            if (rdo2.Checked == true)
            {
                pre1 = 2;
            }
            if (rdo3.Checked == true)
            {
                pre1 = 3;
            }


            tbl_personelTableAdapter.UpdateQuery(txtname.Text, txtfamil.Text, txttell.Text, txtaddress.Text, txtmobile.Text, txtfieldwork.Text, txtus.Text, txtpw.Text,pre1, txtcode.Text);
            tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            txtcode.Clear();
            txtfamil.Clear();
            txtfieldwork.Clear();
            txtmobile.Clear();
            txtname.Clear();
            txtpw.Clear();
            txttell.Clear();
            txtus.Clear();
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            tbl_personelTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
        }
    }
}
