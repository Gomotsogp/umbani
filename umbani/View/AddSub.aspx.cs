using System;
using System.Web;
using umbani.Data_Access_Layer;
using umbani.Models;

namespace umbani.View
{
    public partial class AddSub : System.Web.UI.Page
    {
        Company c = new Company();
        Product p = new Product();
        Contact co = new Contact();
        Subscription s = new Subscription();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*foreach (var item in c.GetCompanies())
            {
                ddlCompany.Items.Add(item.CompanyName);
            }

            foreach (var item in p.GetProducts())
            {
                ddlProduct.Items.Add(item.ProductName);
            }

            foreach (var item in co.GetContacts())
            {
                ddlContact.Items.Add(item.Name);
            }*/

            //load data from session
            HttpCookie update = Request.Cookies["subscriptionID"];
            if (update != null)
            {
               // id = int.Parse(Session["subscriptionID"].ToString());
               // id = int.Parse(Request.Cookies["subscriptionID"].Value);

                // load the data into the controls
                
                foreach (var item in s.GetSubscription(id))
                {
                    txtUsers.Text = item.NumberOfUsers.ToString();
                    txtCost.Text = item.Cost.ToString();
                    ddlContact.SelectedValue = item.ContactId.Id.ToString();
                    ddlCompany.SelectedValue = item.CompanyId.Id.ToString();
                    ddlProduct.SelectedValue = item.ProductId.Id.ToString();
                    Calendar1.SelectedDate = item.SubscriptionStartDate;
                    chkMonthly.Checked = item.Monthly;
                    chkAnnual.Checked = item.Annual;
                }
                
            }
            /*HttpCookie myCookie = new HttpCookie("updateCookie");

            myCookie.Value = id.ToString();
            myCookie.Expires = DateTime.Now.AddMinutes(1);
            Session.RemoveAll();*/
            Session.Abandon();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((ddlContact.Text !="") && (ddlCompany.Text !="") && (ddlProduct.Text!="")  && (txtCost.Text!="") && (txtUsers.Text!=""))
            {
                HttpCookie update = Request.Cookies["subscriptionID"];
                if (update != null) id = int.Parse(update.Value);

                if (id >0)
                {
                    s.UpdateSubscription(int.Parse(ddlCompany.SelectedValue), int.Parse(ddlContact.SelectedValue),
                        int.Parse(ddlProduct.SelectedValue),
                        int.Parse(txtUsers.Text), Calendar1.SelectedDate, chkAnnual.Checked, chkMonthly.Checked,
                        decimal.Parse(txtCost.Text), id);
                    Response.Write(@"<script language='javascript'>alert('subscription updated successfully')</script>");
                }
                else
                {
                    s.SaveSubscription(int.Parse(ddlCompany.SelectedValue), int.Parse(ddlContact.SelectedValue), int.Parse(ddlProduct.SelectedValue),
                        int.Parse(txtUsers.Text), Calendar1.SelectedDate, chkAnnual.Checked, chkMonthly.Checked,
                        decimal.Parse(txtCost.Text));
                    Response.Write(@"<script language='javascript'>alert('subscription saved successfully')</script>");
                }
                
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Please fill in all fields')</script>");
            }
        }
    }
}