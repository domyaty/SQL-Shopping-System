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
    public partial class specifyAmount : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("SpecifyAmount", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user

            string customername = (string)(Session["field1"]);
            string orderId = TextBox1.Text;
            string cash = TextBox2.Text;
            string credit = TextBox3.Text;


            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@customername", customername));
            cmd.Parameters.Add(new SqlParameter("@orderID", orderId));
            cmd.Parameters.Add(new SqlParameter("@cash", cash));
            cmd.Parameters.Add(new SqlParameter("@credit", credit));


            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Label txt = new Label();
            txt.Text = "DONE.";
            form1.Controls.Add(txt);


        }
    }
}