using System;
using umbani.Data_Access_Layer;
using umbani.Models;

namespace umbani.View
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            id = int.Parse(Session["Authenticated"].ToString());
            if (id == 0)
            {

                Response.Redirect("Login.aspx");
            }
        }
        Product p = new Product();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((txtName.Text !="") && (txtMonthly.Text != "") && (txtMonthly.Text != ""))
            {
                p.SaveProduct(txtName.Text, decimal.Parse(txtAnnualCost.Text), decimal.Parse(txtMonthly.Text));
                Response.Write(@"<script language='javascript'>alert('Product saved successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Please fill in all fields')</script>");
            }
        }
    }
}