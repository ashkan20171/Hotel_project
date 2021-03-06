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

public partial class EditUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            textFill();
        }
    }

    private void textFill()
    {
        try
        {
            tblUsersTableAdapter tbl1 = new tblUsersTableAdapter();
            dtsUsers.tblUsersDataTable dt1 = new dtsUsers.tblUsersDataTable();
            tbl1.FillBy2(dt1, Session["UserName"].ToString());
            TextBox1.Text = dt1.Rows[0][1].ToString();
            TextBox2.TextMode = TextBoxMode.Password;
            TextBox2.Attributes.Add("Value", dt1.Rows[0][2].ToString());
            TextBox3.TextMode = TextBoxMode.Password;
            TextBox3.Attributes.Add("Value", dt1.Rows[0][2].ToString());
            TextBox4.Text = dt1.Rows[0][8].ToString();
            TextBox5.Text = dt1.Rows[0][9].ToString();
            TextBox6.Text = dt1.Rows[0][3].ToString();
            TextBox7.Text = dt1.Rows[0][4].ToString();
            TextBox8.Text = dt1.Rows[0][5].ToString();
            TextBox9.Text = dt1.Rows[0][6].ToString();
        }
        catch
        {
            Response.Redirect("Default.aspx?ID=" + DateTime.Now.Ticks.ToString());
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        tblUsersTableAdapter tb1 = new tblUsersTableAdapter();
        dtsUsers.tblUsersDataTable dt1 = new dtsUsers.tblUsersDataTable();

        clsDbConnection dbT = new clsDbConnection();
        DataTable dtt = new DataTable();

        dtt = dbT.dbSelect("SELECT UserName, UserTypeID , UserMail  FROM  tblUsers  WHERE (UserName = N'" + Session["UserName"].ToString() + "')");
        tb1.Update(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox6.Text.Trim(), TextBox7.Text.Trim(), TextBox8.Text.Trim(), TextBox9.Text.Trim(), int.Parse(dtt.Rows[0][1].ToString()), TextBox4.Text.Trim() , TextBox5.Text.Trim(), int.Parse(dtt.Rows[0][1].ToString()));
        //tb1.UpdateQuery(TextBox2.Text.Trim(), TextBox6.Text.Trim(), TextBox7.Text.Trim(), 
        //    TextBox8.Text.Trim(), TextBox9.Text.Trim(), TextBox5.Text.Trim(), 
        //    int.Parse(dtt.Rows[0][1].ToString()), dtt.Rows[0][0].ToString(), dtt.Rows[0][2].ToString());
        textFill();
        Label12.Visible = true;
        Label12.Text = "عملیات بروز رسانی اطلاعات کاربری با موفقیت انجام شد";
    }
}
