using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class clsDbConnection
{
    SqlConnection con;
    public SqlCommand cmd;
    DataTable dt;
    SqlDataAdapter da;

	public clsDbConnection()
	{
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelConString"].ConnectionString);
        cmd = new SqlCommand();
        dt = new DataTable();
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);
	}

    public DataTable dbSelect(string sql)
    {
        cmd.CommandText = sql;
        con.Open();
        da.Fill(dt);
        con.Close();
        return dt;
    }

    public void exeCommand(string strName)
    {
        try
        {
            cmd.CommandText = strName;
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch { }
        finally
        {
            con.Close();
        }

    }

}
