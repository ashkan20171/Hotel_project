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
    public partial class frm_roomupdate : Form
    {
        public frm_roomupdate(string code)
        {
            InitializeComponent();
            txtcode.Text = code;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_roomupdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
             string flagroom = "2";
            if (checkBox1.Checked == true)
            {
                flagroom = "1";
            }
          
            tbl_roomTableAdapter.UpdateQuery(int.Parse(txttakht.Text), int.Parse(txtmasahat.Text), decimal.Parse(txtgheymat.Text), txtemkanat.Text, txttozihat.Text, flagroom, txtcode.Text);
            this.Close();
        }
    }
}
