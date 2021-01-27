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
    public partial class viewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewproduct();
        }
        void viewproduct()
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("vendorviewProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;





            string c = Session["field1"].ToString();
            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@vendorname", c));


            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                //Get the value of the attribute name in the Company table
                int serial_number = rdr.GetInt32(rdr.GetOrdinal("serial_no"));
                //Get the value of the attribute field in the Company table
                string Vendor_UN = rdr.GetString(rdr.GetOrdinal("vendor_username"));
                //Get the value of the attribute field in the Company table
                string ProductName = rdr.GetString(rdr.GetOrdinal("product_name"));
                //Get the value of the attribute field in the Company table
                string Category = rdr.GetString(rdr.GetOrdinal("category"));
                //Get the value of the attribute field in the Company table
                string ProductDescription = rdr.GetString(rdr.GetOrdinal("product_description"));
                //Get the value of the attribute field in the Company table
                decimal Price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                //Get the value of the attribute field in the Company table
                string Color = rdr.GetString(rdr.GetOrdinal("color"));


                //Create a new label and add it to the HTML form
                Label lbl_seriall_no = new Label();
                lbl_seriall_no.Text = serial_number + ",";
                form1.Controls.Add(lbl_seriall_no);

                //Create a new label and add it to the HTML form
                Label lbl_Username = new Label();
                lbl_Username.Text = Vendor_UN + ",";
                form1.Controls.Add(lbl_Username);

                //Create a new label and add it to the HTML form
                Label lbl_Product_name = new Label();
                lbl_Product_name.Text = ProductName + ",";
                form1.Controls.Add(lbl_Product_name);

                //Create a new label and add it to the HTML form
                Label lbl_category = new Label();
                lbl_category.Text = Category + ",";
                form1.Controls.Add(lbl_category);

                //Create a new label and add it to the HTML form
                Label lbl_product_desc = new Label();
                lbl_product_desc.Text = ProductDescription + ",";
                form1.Controls.Add(lbl_product_desc);

                //Create a new label and add it to the HTML form
                Label lbl_price = new Label();
                lbl_price.Text = Price + ",";
                form1.Controls.Add(lbl_price);


                Label lbl_colour = new Label();
                lbl_colour.Text = Color + "  <br /> <br />";
                form1.Controls.Add(lbl_colour);
            }
            //this is how you retrive data from session variable.
            string field1 = (string)(Session["field1"]);
            Response.Write(field1);

        }
    }
}