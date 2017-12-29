using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Reviews_All : BasePage
{
  protected void Page_Load(object sender, EventArgs e)
  {
        SqlConnection co = new SqlConnection(
        WebConfigurationManager.ConnectionStrings["PlanetWroxConnectionString1"].ConnectionString);
        SqlCommand c = new SqlCommand("select * from Review", co);
        co.Open();
        SqlDataReader rdr = c.ExecuteReader();
        GridView1.DataSource = rdr;
        GridView1.DataBind();
        co.Close();
    }
}