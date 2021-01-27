using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class AddCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("AddCreditCard", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string user = Session["user"].ToString();
            cmd.Parameters.Add(new SqlParameter("@customername", user));
            cmd.Parameters.Add(new SqlParameter("@creditcardnumber", CreditCardNo.Text));
            cmd.Parameters.Add(new SqlParameter("@cvv", Cvv.Text));
            cmd.Parameters.Add(new SqlParameter("@expirydate", ExDate.Text));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}