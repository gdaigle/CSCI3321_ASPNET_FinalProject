using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddPublishers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if(txtAddress.Text == "" && txtCity.Text == "" && txtPostal.Text == "" && txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if(txtAddress.Text == "" && txtCity.Text == "" && txtPostal.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtAddress.Text == "" && txtCity.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, PostalCode) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtPostal.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtAddress.Text == "" && txtPostal.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, City) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtCity.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtAddress.Text == "" && txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, PostalCode, City) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPostal.Text + "', '" + txtCity.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                else if (txtAddress.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, PostalCode, City) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtPostal.Text + "', '" + txtCity.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtCity.Text == "" && txtPostal.Text == "" && txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtCity.Text == "" && txtPostal.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtCity.Text == "" && txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, PostalCode, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPostal.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtCity.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, PostalCode, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtPostal.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtPostal.Text == "" && txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, City, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtCity.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtPostal.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, Phone, City, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "', '" + txtCity.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (txtPhone.Text == "")
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, City, PostalCode, Address) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtCity.Text + "', '" + txtPostal.Text + "', '" + txtAddress.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    cmd.CommandText = "INSERT INTO Publishers(PublisherName, Country, City, PostalCode, Address, Phone) VALUES ('" + txtPublisherName.Text + "', '" + txtCountry.Text + "', '" + txtCity.Text + "', '" + txtPostal.Text + "', '" + txtAddress.Text + "', '" + txtPhone.Text + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }



                Response.Redirect("AddBook.aspx");
            }
        }
    }
}