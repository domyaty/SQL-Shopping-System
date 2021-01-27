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
    public partial class customer : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("makeOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            
            string customername = (string)(Session["field1"]);


            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@customername", "youssef.amr"));

            SqlParameter order = cmd.Parameters.Add("@order", SqlDbType.Int);
            order.Direction = ParameterDirection.Output;
    

            SqlParameter price = cmd.Parameters.Add("@total_price", SqlDbType.Decimal);
            price.Direction = ParameterDirection.Output;

            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //Create a new label and add it to the HTML form
            Label label = new Label();
            label.Text = "  Order number " + order.Value + " has a total price " + price.Value;
            form1.Controls.Add(label);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("specifyAmount.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("chooseCredit.aspx", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("cancelOrder.aspx", true);
        }

        protected void AddTelephone(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
                the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addMobile", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            //To read the input from the user
            string customername = (string)(Session["field1"]);
            string number = TextBox2.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", customername));
            cmd.Parameters.Add(new SqlParameter("@mobile_number", number));

            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Label txt = new Label();
            txt.Text = "DONE.";
            form1.Controls.Add(txt);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCreditCard.aspx", true);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx", true);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products_acc.aspx", true);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("wishList.aspx", true);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("wishlistCreation.aspx", true);
        }
    }
}