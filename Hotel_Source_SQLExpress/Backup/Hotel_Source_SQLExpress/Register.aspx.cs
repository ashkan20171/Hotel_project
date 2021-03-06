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
using dtsUsersTableAdapters;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            Session.Clear();
            Response.Redirect("Register.aspx?ID=" + DateTime.Now.Ticks.ToString());
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        tblUsersTableAdapter UserAdd = new tblUsersTableAdapter();
        dtsUsers.tblUsersDataTable tbl1 = new dtsUsers.tblUsersDataTable();
        dtsUsers.tblUsersDataTable tbl2 = new dtsUsers.tblUsersDataTable();
        Label10.Visible = false;
        Label11.Visible = false;
        Label12.Visible = false;

        UserAdd.FillBy(tbl1, TextBox1.Text.Trim());
        UserAdd.FillBy1(tbl2, TextBox4.Text.Trim());

        if (tbl1.Rows.Count <= 0 && tbl2.Rows.Count <= 0)
        {
            UserAdd.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox6.Text.Trim(),
                TextBox7.Text.Trim(), TextBox8.Text.Trim(), TextBox9.Text.Trim(), 2,
                TextBox4.Text.Trim(), TextBox5.Text.Trim());
            Label12.Visible = true;
            Label11.Text = "ثبت نام انجام شد. می توانید با نام کاربری وارد سیستم شوید.";
            if (CheckBox1.Checked == true)
            {
                clsDbConnection db = new clsDbConnection();
                DataTable dt = new DataTable();

                dt = db.dbSelect("SELECT UserID, UserName, UserTypeID FROM tblUsers WHERE     (UserName = '" + TextBox1.Text.Trim() + "')");
                 

                if (dt.Rows.Count <= 0)
                {
                    Label12.Visible = true;
                    Label12.Text = "نام کاربری در پایگاه داده ثبت نشده است";
                }
                else
                {
                    Session.Add("UserName", dt.Rows[0][1].ToString());
                    Session.Add("UserTypeID", dt.Rows[0][2].ToString().Trim());
                    Session.Add("UserID", dt.Rows[0][0].ToString());
                    Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
                }
            }

            txtClear();

        }
        else
        {
            if (tbl1.Rows.Count > 0)
            {
                Label10.Visible = true;
                Label10.Text = "نام کاربری تکراری است";
            }
            if (tbl2.Rows.Count > 0)
            {
                Label11.Visible = true;
                Label11.Text = "آدرس ایمیل تکراری است";
            }
        }
    }

    private void txtClear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtClear();
    }
}
