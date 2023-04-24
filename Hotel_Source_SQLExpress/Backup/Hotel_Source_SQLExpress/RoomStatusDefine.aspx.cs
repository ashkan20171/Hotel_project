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
using dtsRoomStatTableAdapters;

public partial class RoomStatusDefine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible = false;
        tblRoomStateTableAdapter roomAdd = new tblRoomStateTableAdapter();
        dtsRoomStat.tblRoomStateDataTable tbl = new dtsRoomStat.tblRoomStateDataTable();

        roomAdd.FillBy(tbl, TextBox1.Text.Trim());

        if (tbl.Rows.Count > 0)
        {
            Label2.Visible = true;
            Label2.Text = "این مقدار قبلا در پایگاه داده تعریف شده است";
        }
        else
        {
            roomAdd.Insert(TextBox1.Text.Trim());
            Label2.Visible = true;
            TextBox1.Text = "";
            GridView1.DataBind();
            Label2.Text = "وضعیت جدید تعریف شد.";
        }
    }
}
