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
    public partial class editProduct : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("EditProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user

            string x = Session["field1"].ToString();

            string serial = serial_number.Text.ToString();

            string Product_name = productName.Text;
            string category = cat.Text;
            string product_description = Produc_desc.Text;
            string Price = Pr.Text.ToString();
            String color = Cl.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@vendorname", x));
            cmd.Parameters.Add(new SqlParameter("@serialnumber", serial));

            if (Product_name == "")
                cmd.Parameters.Add(new SqlParameter("@product_name", DBNull.Value));
            else
                cmd.Parameters.Add(new SqlParameter("@product_name", Product_name));

            if (category == "")
                cmd.Parameters.Add(new SqlParameter("@category", DBNull.Value));
            else
                cmd.Parameters.Add(new SqlParameter("@category", category));
            if (product_description == "")
                cmd.Parameters.Add(new SqlParameter("@product_description", DBNull.Value));
            else
                cmd.Parameters.Add(new SqlParameter("@product_description", product_description));
            if (Price == "")
                cmd.Parameters.Add(new SqlParameter("@price", DBNull.Value));
            else
                cmd.Parameters.Add(new SqlParameter("@price", Price));


            if (color == "")
                cmd.Parameters.Add(new SqlParameter("@color", DBNull.Value));
            else
                cmd.Parameters.Add(new SqlParameter("@color", color));



            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}