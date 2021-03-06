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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserTypeID"] != null)
        {
            if (int.Parse(Session["UserTypeID"].ToString()) == 1)
            {
                SqlDataSource1.SelectCommand = @"SELECT     TOP 100 PERCENT LinksID, LinkAddress, LinkDescription
                                                  FROM tblLinks WHERE     (LinkPermiss <> 2) AND (LinkPermiss <> 3) ORDER BY LinkSort";
            }
            else if (int.Parse(Session["UserTypeID"].ToString()) == 2)
            {
                SqlDataSource1.SelectCommand = @"SELECT     TOP 100 PERCENT LinksID, LinkAddress, LinkDescription
                                                  FROM tblLinks WHERE     (LinkPermiss <> 2) AND (LinkPermiss <> 3) AND (LinkPermiss <> 4) ORDER BY LinkSort";
            }
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT LinksID, LinkAddress, LinkDescription FROM tblLinks WHERE (LinkPermiss = 1) OR (LinkPermiss = 2) OR (LinkPermiss = 3) ORDER BY LinkSort";
        }
        cntMaker();
    }

    private void cntMaker()
    {
        float mYcn = 0;
        clsDbConnection db = new clsDbConnection();
        DataTable dt = new DataTable();

        dt = db.dbSelect("SELECT     CntID, CntCount  FROM       tblCounter  WHERE     (CntID = 1)");

        mYcn = float.Parse(dt.Rows[0][1].ToString());
        mYcn++;

        db.exeCommand("UPDATE tblCounter SET CntCount = '" + mYcn + "'  WHERE CntID = 1");

        Label1.Text = "تعداد بازدیدها: " +  mYcn.ToString();

    }

}
