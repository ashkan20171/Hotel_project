using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1(string us,string per)
        {
            InitializeComponent();
            lblus.Text = us;
            lblper.Text = per;
        }

        private void اطلاعاتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomer fr = new frmcustomer();
            fr.Show();
        }

        private void ثبتاتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmroom().Show();
        }

        private void رزرواتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmreserve("").Show();
        }

        private void اطلاعاتکارکنانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpersonel fr = new frmpersonel();
            fr.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmhazineh().Show();
        }

        private void اتاقهایخالیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.FillByflag(hotelDataSet.tbl_room);
            rptroomfree rpt = new rptroomfree();
            rpt.SetDataSource(hotelDataSet);

            report fr = new report();
            fr.Owner = this;
            fr.crystalReportViewer1.ReportSource = rpt;
            fr.Show();

            
        }

        private void tbl_roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_reserve' table. You can move, or remove it, as needed.
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            if (lblper.Text=="1")
            {
                menuStrip1.Visible = true;
            }
            if (lblper.Text=="2")
            {
                menuStrip2.Visible = true;
            }
            if (lblper.Text=="3")
            {
                menuStrip3.Visible=true;
            }
            else
            {

            }
	{
		 
	}

        }

        private void لیستصورتوضعیتماهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreportbet2date fr = new frmreportbet2date();
            fr.Show();
        }
    }
}
