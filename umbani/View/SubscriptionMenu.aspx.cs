using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbani.Data_Access_Layer;
using umbani.Models;

namespace umbani.View
{
    public partial class SubscriptionMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private bool isSuccess;
        public void fillgrid()
        {
            DataHandler dh = new DataHandler();
           // GridView1.DataSource = dh.GetSubscription();
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*GridViewRow d = new  GridViewRowEventArgs;
            int subscriptionId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());
            Session["subscriptionID"] = subscriptionId;

            Response.Redirect("AddSub.aspx");*/
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int subscriptionId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());

                SqlDataSource1.DeleteCommand = $"delete subscription  where id = {subscriptionId}";
                SqlDataSource1.Update();
                Response.Write(@"<script language='javascript'>alert('Product updated successfully')</script>");
            }
            catch (Exception exception)
            {
                Response.Write($@"<script language='javascript'>alert('An error occured. {exception.Message}')</script>");
                Response.Redirect("error.aspx");
            }
        }

        Subscription s = new Subscription();

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int subscriptionId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());
            Session["subscriptionID"] = subscriptionId;

            Response.Redirect("AddSub.aspx");

            /*int subscriptionId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];

            //make textboxes to edit on

            TextBox txtcompany = (TextBox)row.Cells[1].Controls[0];
            TextBox txtcontac = (TextBox)row.Cells[2].Controls[0];
            TextBox txtproduct = (TextBox)row.Cells[3].Controls[0];
            TextBox txtUsers = (TextBox)row.Cells[4].Controls[0];
            TextBox txtsubendDate = (TextBox)row.Cells[5].Controls[0];
            GridView1.EditIndex = -1;*/
            /*
            SqlDataSource1.UpdateCommand = $@"update subscription
set companyid = {txtcompany.Text}, contactid = {txtcontac.Text}, productid = {txtproduct.Text}, numberofusers= {txtUsers.Text},subscriptionstartdate= {txtsubendDate.Text},where id ={subscriptionId}";
            SqlDataSource1.Update();
*/
            // isSuccess = s.UpdateSubscription(int.Parse(txtcompany.Text),int.Parse(txtcontac.Text),int.Parse(txtproduct.Text))

            Response.Write(@"<script language='javascript'>alert('Product updated successfully')</script>");
        }
    }
}