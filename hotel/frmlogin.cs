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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_personelTableAdapter.qlogin(hotelDataSet.tbl_personel, comboBoxEx1.Text, txtpw.Text);

            if (hotelDataSet.tbl_personel.Rows.Count > 0)
            {

                Form1 fr = new Form1(comboBoxEx1.Text,lblper.Text);
                fr.Show();
                
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز ورود صحیح نیست","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
