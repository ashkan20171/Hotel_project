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
    public partial class frmreportbet2date : Form
    {
        public frmreportbet2date()
        {
            InitializeComponent();
        }

        private void frmreportbet2date_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_reserve' table. You can move, or remove it, as needed.
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            tbl_reserveTableAdapter.FillBydate(hotelDataSet.tbl_reserve, date1.Text, date2.Text);

            reportBET2date rpt = new reportBET2date();
            rpt.SetDataSource(hotelDataSet);

            report frm = new report();
            frm.Owner = this;

            frm.crystalReportViewer1.ReportSource = rpt;

            frm.Show();

        }
    }
}
