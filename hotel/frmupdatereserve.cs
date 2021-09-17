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
    public partial class frmupdatereserve : Form
    {
        public frmupdatereserve(string code)
        {
            InitializeComponent();
            txtcode.Text = code;
        }

        private void frmupdatereserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_reserve' table. You can move, or remove it, as needed.
            this.tbl_reserveTableAdapter.FillBycode(this.hotelDataSet.tbl_reserve,txtcode.Text);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbl_roomTableAdapter.upflag(cmbmoshtari.Text, txtcode.Text);
            }
            if (checkBox1.Checked==false)
            {
                  tbl_roomTableAdapter.upflag("1", txtcode.Text);
            }
            tbl_reserveTableAdapter.UpdateQuery(txtdate1.Text, txtdate2.Text, cmbotagh.Text, cmbmoshtari.Text, txtmadrak.Text, decimal.Parse(txtjamekol.Text), 0, decimal.Parse(txtpardakhti.Text), txtcode.Text);
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
