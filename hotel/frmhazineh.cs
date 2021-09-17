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
    public partial class frmhazineh : Form
    {
        public frmhazineh()
        {
            InitializeComponent();
        }

        private void frmhazineh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_hazineh' table. You can move, or remove it, as needed.
            this.tbl_hazinehTableAdapter.Fill(this.hotelDataSet.tbl_hazineh);
            lbljamekol.Text = tbl_hazinehTableAdapter.getmablagh().ToString();
            lblpardakhti.Text = tbl_hazinehTableAdapter.ScalarQuery().ToString();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //string flag2;
            //if (rdokharid.Checked == true)
            //{
            //    flag2 = "خرید";

            //}
            //else if (rdokhedmat.Checked == true)
            //{
            //    flag2 = "خدمت";
            //}

            tbl_hazinehTableAdapter.InsertQuery(txtcode.Text, txtcodefactor.Text, txtcodepersonel.Text, txtsharh.Text, txtforooshandeh.Text, decimal.Parse(txtmablagh.Text),"", decimal.Parse(txtpardakhti.Text), txttozihat.Text);
            tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            MessageBox.Show("هزینه مورد نظر شما ثبت شد");
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید می خواهید حذف کنید؟در صورت حذف اطلاعات قابل بازیابی نیست","اخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                tbl_hazinehTableAdapter.DeleteQuery(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
                   tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillBycodefactor(hotelDataSet.tbl_hazineh, textBoxX1.Text);
            }
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX2.Text == "")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillByforooshandeh(hotelDataSet.tbl_hazineh,textBoxX2.Text);
            }
        }

        private void comboBoxEx1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEx1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.Text == "")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillBycodepersonel(hotelDataSet.tbl_hazineh, comboBoxEx1.Text);
            }
        }
    }
}
