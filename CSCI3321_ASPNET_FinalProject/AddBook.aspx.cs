using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddBook : System.Web.UI.Page
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
  
            if(txtWordCount.Text == "")
            {
                cmd.CommandText = "INSERT INTO Books(Title, Price, PublishDate, AuthorID, PublisherID, GenreID) VALUES ('" + txtTitle.Text + "', " + txtPrice.Text + ", '" + Convert.ToDateTime(txtPublishDate.Text).Date + "','" + ddlAuthor.SelectedValue + "','" + ddlPublisher.SelectedValue + "','" + ddlGenre.SelectedValue + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                
            }
            else
            {
                cmd.CommandText = "INSERT INTO Books(Title, Price, PublishDate, AuthorID, PublisherID, GenreID, WordCount) VALUES ('" + txtTitle.Text + "', '" + txtPrice.Text + "', '" + Convert.ToDateTime(txtPublishDate.Text).Date + "','" + ddlAuthor.SelectedValue + "','" + ddlPublisher.SelectedValue + "','" + ddlGenre.SelectedValue + "' ,'" + txtWordCount.Text + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Redirect("MyBooks.aspx");
        }

        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAuthors.aspx");
        }

        protected void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPublishers.aspx");
        }
    }
}