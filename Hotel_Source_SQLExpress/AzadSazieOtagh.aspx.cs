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

public partial class AzadSazieOtagh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dropFill();
        }
    }

    private void dropFill()
    {
        clsDbConnection db = new clsDbConnection();
        DataTable dt = new DataTable();

        dt = db.dbSelect("SELECT     TOP 100 PERCENT RoomID, RoomNumber  FROM   tblRooms  WHERE     (RoomStatuse = 3) ORDER BY RoomID DESC");
        DropDownList1.DataSource = dt;

        DropDownList1.DataTextField = "RoomNumber";
        DropDownList1.DataValueField = "RoomID";
        DropDownList1.DataBind();

        //DropDownList1.Items.Add("انتخاب مشتری");
        DropDownList1.Items.Insert(0 ,new ListItem("انتخاب کد اتاق", "2"));
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
        try
        {
            clsDbConnection db = new clsDbConnection();

            String p1, p2, p3;
            p1 = TextBox3.Text.Substring(0, 4);
            p2 = TextBox3.Text.Substring(5, 2);
            p3 = TextBox3.Text.Substring(8, 2);
            clsShamsi shd = new clsShamsi(int.Parse(p1), int.Parse(p2), int.Parse(p3));

            db.exeCommand(@"UPDATE tblEECus SET ExitDate = '" + shd.MiladiDate.ToShortDateString().Replace("/", "-").Trim() + "' , StayNights = '" + int.Parse(TextBox4.Text.Trim()) + "' , PriceOfPerNight = CONVERT(money, '" + Decimal.Parse(TextBox5.Text.Trim()) + "') , ToTalPriceOfStay = CONVERT(money, '" + Decimal.Parse(TextBox6.Text.Trim()) + "') , PriceOfOtherServices = CONVERT(money, '" + Decimal.Parse(TextBox7.Text.Trim()) + "') , DiscountOfCustomer = CONVERT(money, '" + Decimal.Parse(TextBox8.Text.Trim()) + "') , TotalDebtPayment = CONVERT(money, '" + Decimal.Parse(TextBox9.Text.Trim()) + "') , TasviehBit = CONVERT(int, '1') WHERE RoomID='" + int.Parse(DropDownList1.SelectedValue.ToString()) + "' AND TasviehBit=0");
            clsDbConnection db1 = new clsDbConnection();
            db1.exeCommand("UPDATE tblRooms SET RoomStatuse = 1 WHERE RoomID = '" + int.Parse(DropDownList1.SelectedValue.ToString()) + "'");

            dropFill();
            Label12.Visible = true;
            Label12.Text = "عملیات تسویه حساب با موفقیت ثبت شد.";
            txtClear();
        }
        catch
        {
            Label12.Visible = true;
            Label12.Text = "اشکالی در عملیات ثبت به وجود آمده است";
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DateTime dat1, dat2;
            int DiferDays = 0;
            txtClear();
            clsDbConnection db = new clsDbConnection();
            DataTable dt = new DataTable();

            dt = db.dbSelect("SELECT     RoomID, EnteredDate, FirstPayment  FROM  tblEECus  WHERE     (TasviehBit = 0) AND (RoomID = '" + int.Parse(DropDownList1.SelectedValue.ToString()) + "')");
            clsShamsi dts = new clsShamsi(DateTime.Parse(dt.Rows[0][1].ToString()));
            dat1 = DateTime.Parse(dt.Rows[0][1].ToString());
            dat2 = DateTime.Now;
            TimeSpan Difer = dat2.Subtract(dat1);
            DiferDays = int.Parse(Difer.Days.ToString());
            TextBox4.Text = DiferDays.ToString();

            TextBox1.Text = dts.ShamsiDate;
            TextBox2.Text = dt.Rows[0][2].ToString();
            dts = new clsShamsi(DateTime.Now);
            TextBox3.Text = dts.ShamsiDate;

            db = new clsDbConnection();
            dt = new DataTable();
            dt = db.dbSelect("SELECT     RoomID, PriceOfPerNight  FROM  tblRooms WHERE     (RoomID = '" + int.Parse(DropDownList1.SelectedValue.ToString()) + "')");
            TextBox5.Text = dt.Rows[0][1].ToString();

            TextBox6.Text = Convert.ToString(Decimal.Parse(TextBox4.Text.Trim()) * Decimal.Parse(TextBox5.Text.Trim()));
            TextBox7.Text = "0";
            TextBox8.Text = "0";
        }
        catch
        {
            txtClear();
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Decimal Kosoorat, Bedehiha , TotalDebt;
        Kosoorat = Decimal.Parse(TextBox2.Text.Trim()) + Decimal.Parse(TextBox8.Text.Trim());
        Bedehiha = Decimal.Parse(TextBox6.Text.Trim()) + Decimal.Parse(TextBox7.Text.Trim());
        TotalDebt = Bedehiha - Kosoorat;
        TextBox9.Text = TotalDebt.ToString();
    }
}
