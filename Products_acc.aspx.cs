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
    public partial class Products_acc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("ShowProductsbyPrice", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                //Get the value of the attribute name in the Company table
                int SerialNo = rdr.GetInt32(rdr.GetOrdinal("serial_no"));
                //Get the value of the attribute field in the Company table
                string productname = rdr.GetString(rdr.GetOrdinal("product_name"));
                string category = rdr.GetString(rdr.GetOrdinal("category"));
                string productDesc = rdr.GetString(rdr.GetOrdinal("product_description"));
                decimal finalPrice = rdr.GetDecimal(rdr.GetOrdinal("final_price"));
                decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                string color = rdr.GetString(rdr.GetOrdinal("color"));
                Boolean available = rdr.GetBoolean(rdr.GetOrdinal("available"));
                int rate = rdr.GetInt32(rdr.GetOrdinal("rate"));
                //Create a new label and add it to the HTML form
                Label lbl_SerialNo = new Label();
                lbl_SerialNo.Text = SerialNo.ToString() + " , " + " ";
                form1.Controls.Add(lbl_SerialNo);





                Label lbl_Productname = new Label();
                lbl_Productname.Text = productname + " , " + " ";
                form1.Controls.Add(lbl_Productname);

                Label lbl_Category = new Label();
                lbl_Category.Text = category + " , " + " ";
                form1.Controls.Add(lbl_Category);




                Label lbl_produDesc = new Label();
                lbl_produDesc.Text = productDesc + " , " + " ";
                form1.Controls.Add(lbl_produDesc);


                Label lbl_finalpr = new Label();
                lbl_finalpr.Text = finalPrice + " , " + " ";
                form1.Controls.Add(lbl_finalpr);

                Label lbl_price = new Label();
                lbl_price.Text = price + " , " + " ";
                form1.Controls.Add(lbl_price);

                Label lbl_color = new Label();
                lbl_color.Text = color + " , " + " ";
                form1.Controls.Add(lbl_color);

                Label lbl_available = new Label();
                lbl_available.Text = available + " , " + " ";
                form1.Controls.Add(lbl_available);




                Label lbl_rate = new Label();
                lbl_rate.Text = rate.ToString() + "  <br /> <br />";
                form1.Controls.Add(lbl_rate);


            }

            //this is how you retrive data from session variable.
            string field1 = (string)(Session["field1"]);
            Response.Write(field1);
        }

        void addwishlist()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("AddtoWishlist", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            String username = Session["field1"].ToString();
            cmd.Parameters.Add(new SqlParameter("@customername", username));
            cmd.Parameters.Add(new SqlParameter("@wishlistname", Wishlistname.Text));
            cmd.Parameters.Add(new SqlParameter("@serial", Serial1.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            addwishlist();
        }

        protected void cart_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addToCart", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            String username = Session["field1"].ToString();
            cmd.Parameters.Add(new SqlParameter("@customername", username));
            cmd.Parameters.Add(new SqlParameter("@serial", serialNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}