using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbani.Data_Access_Layer;
using umbani.Models;

namespace umbani.View
{
    public partial class AddCompany : System.Web.UI.Page
    {
        Company c = new Company();
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = 0;
            id = int.Parse(Session["Authenticated"].ToString());
            if (id == 0)
            {

                Response.Redirect("Login.aspx");
            }
            foreach (var item in c.GetCompanies())
            {
                ddlContact.Items.Add(item.ContactId.Name);
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && ddlContact.SelectedIndex >0 )
            {
                c.SaveCompany(txtName.Text, ddlContact.SelectedIndex);
                Response.Write(@"<script language='javascript'>alert('Company saved successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Please enter a company name or select a contact')</script>");
            }
        }

        protected void ddlContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in c.GetCompanies())
            {
                if (ddlContact.Text.Contains(item.ContactId.Name))
                {
                    txtContactEMail.Text = item.ContactId.Email;
                    txtContactPhone.Text = item.ContactId.Number;
                }
            }
        }

        
    }
}