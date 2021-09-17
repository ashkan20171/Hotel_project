using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsDbConnection db = new clsDbConnection();
        DataTable dt = new DataTable();

        dt = db.dbSelect("SELECT UserID, UserName, UserTypeID FROM tblUsers WHERE     (UserName = '" + TextBox1.Text.Trim() + "') AND (UsePassChar = '" + TextBox2.Text.Trim() + "')");

        if (dt.Rows.Count <= 0)
        {
            Response.Write("<script>alert('نام کاربری و یا کلمه عبور صحیح وارد نشده است')</script>");
        }
        else
        {
            Session.Add("UserName", dt.Rows[0][1].ToString());
            Session.Add("UserTypeID", dt.Rows[0][2].ToString().Trim());
            Session.Add("UserID", dt.Rows[0][0].ToString());
            Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            clsDbConnection db = new clsDbConnection();
            DataTable dt = new DataTable();

            dt = db.dbSelect("SELECT UserID, UserName, UserTypeID FROM tblUsers WHERE     (UserName = '" + TextBox1.Text.Trim() + "') AND (UsePassChar = '" + TextBox2.Text.Trim() + "')");

            if (dt.Rows.Count <= 0)
            {
                Response.Write("<script>alert('نام کاربری و یا کلمه عبور صحیح وارد نشده است')</script>");
            }
            else
            {
                Session.Add("UserName", dt.Rows[0][1].ToString());
                Session.Add("UserTypeID", dt.Rows[0][2].ToString().Trim());
                Session.Add("UserID", dt.Rows[0][0].ToString());
                Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
            }
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            clsDbConnection db = new clsDbConnection();
            DataTable dt = new DataTable();

            dt = db.dbSelect("SELECT UserID, UserName, UserTypeID FROM tblUsers WHERE     (UserName = '" + TextBox1.Text.Trim() + "') AND (UsePassChar = '" + TextBox2.Text.Trim() + "')");

            if (dt.Rows.Count <= 0)
            {
                Response.Write("<script>alert('نام کاربری و یا کلمه عبور صحیح وارد نشده است')</script>");
            }
            else
            {
                Session.Add("UserName", dt.Rows[0][1].ToString());
                Session.Add("UserTypeID", dt.Rows[0][2].ToString().Trim());
                Session.Add("UserID", dt.Rows[0][0].ToString());
                Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
            }
        }
    }
}
