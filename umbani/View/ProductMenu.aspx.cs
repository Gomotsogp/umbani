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
    public partial class ProductMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private bool isSuccess;
         public void fillgrid()
        {
            /*DataHandler dh = new DataHandler();
           // GridView1.DataSource = dh.GetProduct();
            GridView1.DataBind();*/
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Product  p = new Product();

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            
            //make textboxes to edit on

            TextBox txtName = (TextBox)row.Cells[1].Controls[0];
            TextBox txtAnnual = (TextBox)row.Cells[2].Controls[0];
            TextBox txtmonthly = (TextBox)row.Cells[3].Controls[0];
            GridView1.EditIndex = -1;
            SqlDataSource1.UpdateCommand = $@"update product
set name ={txtName.Text} ,annualcost = {txtAnnual.Text}, monthlycost = {txtmonthly.Text}
where id ={productId}";
            SqlDataSource1.Update();
           // isSuccess = p.UpdateProduct(txtName.Text,decimal.Parse(txtAnnual.Text), decimal.Parse(txtmonthly.Text),productId);
            //if (isSuccess)
            //{
                Response.Write(@"<script language='javascript'>alert('Product updated successfully')</script>");
            //}
            //else
            //{
                //Response.Write(@"<script language='javascript'>alert('Company update failed')</script>");
            //}
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int companyid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());

                SqlDataSource1.DeleteCommand = $"delete product  where id = {companyid}";
                SqlDataSource1.Update();
                Response.Write(@"<script language='javascript'>alert('Product updated successfully')</script>");
            }
            catch (Exception exception)
            {
                Response.Write($@"<script language='javascript'>alert('An error occured. {exception.Message}')</script>");
                Response.Redirect("error.aspx");
            }
            
        }
    }
}