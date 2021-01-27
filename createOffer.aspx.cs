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
    public partial class createOffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addOffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user

            string offer_amount = offer_A.Text;
            string EXP_date = Expiry_Date.Text.ToString();


            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@offeramount", offer_amount));
            cmd.Parameters.Add(new SqlParameter("@expiry_date", EXP_date));


            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("applyOffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user

            string offer_id = offer_ID.Text.ToString();
            string serial_ID_P = serial_id.Text.ToString();


            //pass parameters to the stored procedure
            string username = Session["field1"].ToString();

            cmd.Parameters.Add(new SqlParameter("@vendorname", username));
            cmd.Parameters.Add(new SqlParameter("@offerid", offer_id));
            cmd.Parameters.Add(new SqlParameter("@serial", serial_ID_P));






            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("checkandremoveExpiredoﬀer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user

            string offer_id = OFFERID.Text.ToString();

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@offerid", offer_id));

            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}