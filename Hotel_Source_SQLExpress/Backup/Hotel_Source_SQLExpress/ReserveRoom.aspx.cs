using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ReserveRoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbReservedAll();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            int RoomNo = int.Parse(GridView1.SelectedValue.ToString());
            clsDbConnection db = new clsDbConnection();
            db.exeCommand("UPDATE tblRooms SET RoomStatuse = 2 WHERE RoomID = '" + RoomNo + "'");
            clsDbConnection db1 = new clsDbConnection();
            clsShamsi shd = new clsShamsi(DateTime.Now);
            String MyShamsiDate = shd.ShamsiDate;

            db1.exeCommand("INSERT INTO tblRezerveRoom VALUES ('" + int.Parse(Session["UserID"].ToString()) + "' , '" + RoomNo + "' , '" + MyShamsiDate + "')");

            clsDbConnection db2 = new clsDbConnection();
            DataTable dt2 = new DataTable();

            dt2 = db2.dbSelect("SELECT     RezrveID   FROM   tblRezerveRoom  WHERE   (CustomerID = '" + int.Parse(Session["UserID"].ToString()) + "') AND (RoomID = '" + RoomNo + "') AND (RezerveDate = N'" + MyShamsiDate + "')");

            GridView1.DataBind();
            Label2.Visible = true;
            dbReservedAll();
            Label2.Text = "عملیات رزرو با موفقیت انجام شد. کد رزرو شما: " + dt2.Rows[0][0].ToString() + " می باشد." + "<BR>" + "لطفا برای مراجعه و تحویل گیری اتاق این کد را همراه داشته باشید.";
        }
        else
        {
            Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
        }
    }

    private void dbReservedAll()
    {
        if (Session["UserName"] != null)
        {
            clsDbConnection db = new clsDbConnection();
            DataTable dt = new DataTable();
            dt = db.dbSelect("SELECT     RoomID, RoomStatuse  FROM  tblRooms WHERE     (RoomStatuse = 1)");
            Image1.Visible = false;

            if (dt.Rows.Count <= 0)
            {
                Image1.Visible = true;
            }
        }
        else
        {
            Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
        }
    }
}
