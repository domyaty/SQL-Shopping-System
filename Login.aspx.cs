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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("userLogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
           

            //To read the input from the user
            string username = user.Text;
            string password = pass.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));

            //Save the output from the procedure
            SqlParameter count1 = cmd.Parameters.Add("@type", SqlDbType.Int);
            count1.Direction = ParameterDirection.Output;

            SqlParameter count2 = cmd.Parameters.Add("@success", SqlDbType.Bit);
            count2.Direction = ParameterDirection.Output;

            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            

            if (count2.Value.Equals(true))
            {
                if (count1.Value.ToString().Equals("0"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("Passed");

                    /*ASP.NET session state enables you to store and retrieve values for a user
                    as the user navigates ASP.NET pages in a Web application.
                    This is how we store a value in the session*/
                    Session["field1"] = username;

                    //To navigate to another webpage
                    Response.Redirect("customer.aspx", true);

                }
                else if (count1.Value.ToString().Equals("1"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("Passed");

                    /*ASP.NET session state enables you to store and retrieve values for a user
                    as the user navigates ASP.NET pages in a Web application.
                    This is how we store a value in the session*/
                    Session["field1"] = username;

                    //To navigate to another webpage
                    Response.Redirect("vendor.aspx", true);

                }
                else if (count1.Value.ToString().Equals("2"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("Passed");

                    /*ASP.NET session state enables you to store and retrieve values for a user
                    as the user navigates ASP.NET pages in a Web application.
                    This is how we store a value in the session*/
                    Session["field1"] = username;

                    //To navigate to another webpage
                    Response.Redirect("admin.aspx", true);

                }
                else if (count1.Value.ToString().Equals("3"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("Passed");

                    /*ASP.NET session state enables you to store and retrieve values for a user
                    as the user navigates ASP.NET pages in a Web application.
                    This is how we store a value in the session*/
                    Session["field1"] = username;

                    //To navigate to another webpage
                    Response.Redirect("delivery.aspx", true);

                }
            }
            else
            {
                Label txt = new Label();
                txt.Text = "Username or Password is not found.";
                form1.Controls.Add(txt);
            }
        }
    }
}