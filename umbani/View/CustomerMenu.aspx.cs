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
    public partial class CustomerMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrid();
            }

            int id = 0;
            id =int.Parse(Session["Authenticated"].ToString());
            if (id==0)
            {

                Response.Redirect("Login.aspx");
            }


        }

        private bool isSUccess;
        public void fillgrid()
        {
            /*DataHandler dh = new DataHandler();
          //  GridView1.DataSource = dh.GetCustomer();
            GridView1.DataBind();*/
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string queryString = "AddCompany.aspx";
            string newWin = "window.open('" + queryString + "');";
            ClientScript.RegisterStartupScript(this.GetType(), "pop", newWin, true);
        }
        Company c = new  Company();
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            isSUccess= c.DeleteCompany(id);
            if (isSUccess)
            {
                Response.Write(@"<script language='javascript'>alert('Company deleted successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Company deletion failed')</script>");
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]?.Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox txtName = (TextBox)row.Cells[1].Controls[0];
            //DropDownList contact = row.FindControl("contactlist") as DropDownList;
            TextBox txtContact = (TextBox)row.Cells[2].Controls[0];
            TextBox txtPhone = (TextBox)row.Cells[2].Controls[0];
            TextBox txtEMail = (TextBox)row.Cells[3].Controls[0];
            GridView1.EditIndex = -1;
            
            isSUccess =c.UpdateCompany(txtName.Text,int.Parse(txtContact.Text));
            if (isSUccess)
            {
                Response.Write(@"<script language='javascript'>alert('Company updated successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Company update failed')</script>");
            }
        }
    }
}