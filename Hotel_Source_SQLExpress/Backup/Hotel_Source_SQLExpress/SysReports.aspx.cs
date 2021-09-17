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

public partial class SysReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsDbConnection db = new clsDbConnection();
        DataTable dt = new DataTable();

        dt = db.dbSelect(@"SELECT     DERIVEDTBL.TT1 AS TedadeKarbaran, DERIVEDTBL_1.TT2 AS TedadeOtaghHa, DERIVEDTBL_2.TT3 AS OtaghhaieRezerveShode, 
                           DERIVEDTBL_3.TT4 AS OtaghhaieTahvilShodeh, DERIVEDTBL_4.TT5 AS OtaghhaieAzad, DERIVEDTBL_5.TT6 AS DariaftieKol, 
                           DERIVEDTBL_6.TT7 AS BazDidha FROM         (SELECT     COUNT(UserID) AS TT1 FROM         dbo.tblUsers) DERIVEDTBL CROSS JOIN
                          (SELECT     COUNT(RoomID) AS TT2 FROM         tblRooms) DERIVEDTBL_1 CROSS JOIN (SELECT     COUNT(RoomID) AS TT3
                             FROM         tblRooms GROUP BY RoomStatuse HAVING      (RoomStatuse = 2)) DERIVEDTBL_2 CROSS JOIN (SELECT     COUNT(RoomID) AS TT4
                             FROM         tblRooms  GROUP BY RoomStatuse HAVING      (RoomStatuse = 3)) DERIVEDTBL_3 CROSS JOIN (SELECT     COUNT(RoomID) AS TT5
                             FROM         tblRooms GROUP BY RoomStatuse  HAVING      (RoomStatuse = 1)) DERIVEDTBL_4 CROSS JOIN (SELECT     SUM(TotalDebtPayment) AS TT6
                             FROM         tblEECus) DERIVEDTBL_5 CROSS JOIN (SELECT     CntCount AS TT7 FROM   tblCounter GROUP BY CntCount) DERIVEDTBL_6");

        Label8.Text = dt.Rows[0][0].ToString();
        Label9.Text = dt.Rows[0][1].ToString();
        Label10.Text = dt.Rows[0][2].ToString();
        Label11.Text = dt.Rows[0][3].ToString();
        Label12.Text = dt.Rows[0][4].ToString();
        Label14.Text = dt.Rows[0][5].ToString();
        Label15.Text = dt.Rows[0][6].ToString();
    }
}
