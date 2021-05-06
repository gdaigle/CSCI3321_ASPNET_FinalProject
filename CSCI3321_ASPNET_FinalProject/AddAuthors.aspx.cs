using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddAuthors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if(rblGender.SelectedIndex == -1 && txtBirthday.Text == "")
            {
                cmd.CommandText = "INSERT INTO Authors(LastName, FirstName) VALUES ('" + txtLastName.Text + "', '" + txtFirstName.Text + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if(rblGender.SelectedIndex == -1)
            {
                cmd.CommandText = "INSERT INTO Authors(LastName, FirstName, BirthDate) VALUES ('" + txtLastName.Text + "', '" + txtFirstName.Text + "', '" + Convert.ToDateTime(txtBirthday.Text).Date + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (txtBirthday.Text == "")
            {
                cmd.CommandText = "INSERT INTO Authors(LastName, FirstName, Gender) VALUES ('" + txtLastName.Text + "', '" + txtFirstName.Text + "', '" + rblGender.SelectedValue.ToString() + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

                cmd.CommandText = "INSERT INTO Authors(LastName, FirstName, Gender, BirthDate) VALUES ('" + txtLastName.Text + "', '" + txtFirstName.Text + "', '" + rblGender.SelectedValue.ToString() + "','" + Convert.ToDateTime(txtBirthday.Text).Date + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            

            Response.Redirect("AddBook.aspx");
        }
        }
    }