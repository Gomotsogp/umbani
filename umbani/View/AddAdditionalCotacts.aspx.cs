using System;
using umbani.Data_Access_Layer;
using umbani.Models;

namespace umbani.View
{
    public partial class AddAdditionalCotacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Contact c = new Contact();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text != "")&& (TextBox2.Text!="") && (TextBox3.Text!=""))
            {
                c.SaveContact(TextBox1.Text, TextBox2.Text, TextBox3.Text);
                Response.Write(@"<script language='javascript'>alert('Contact saved successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Please fill in all fields')</script>");
            }
        }
    }
}