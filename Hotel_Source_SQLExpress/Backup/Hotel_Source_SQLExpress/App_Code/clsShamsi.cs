using System;
using System.Globalization;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class clsShamsi
{
    private String dtShamsi;
    private DateTime dtMiladi;

    public clsShamsi(int _Year, int _Month, int _Day)
    {
        PersianCalendar Per = new PersianCalendar();
        dtMiladi = Per.ToDateTime(_Year, _Month, _Day, 0, 0, 0, 0);
    }

	public clsShamsi(DateTime MiladiDate)
	{
        PersianCalendar calFar1 = new PersianCalendar();
        dtShamsi = calFar1.GetYear(MiladiDate).ToString() + "/" + calFar1.GetMonth(MiladiDate).ToString("00") + "/" + calFar1.GetDayOfMonth(MiladiDate).ToString("00");
	}

    public String ShamsiDate
    {
        get
        {
            return dtShamsi;
        }
        set
        {
            dtShamsi = value;
        }
    }

    public DateTime MiladiDate
    {
        get
        {
            return dtMiladi;
        }
        set
        {
            dtMiladi = value;
        }
    }
}
