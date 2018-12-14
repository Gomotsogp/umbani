using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbani.Data_Access_Layer;


namespace umbani.View
{
    public partial class UserMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillgrid();
            int id = 0;
            id = int.Parse(Session["Authenticated"].ToString());
            if (id == 0)
            {

                Response.Redirect("Login.aspx");
            }
        }
        public void fillgrid()
        {
            DataHandler dh = new DataHandler();
           // GridView1.DataSource = dh.GetUser();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string queryString = "AddUser.aspx";
            string newWin = "window.open('" + queryString + "');";
            ClientScript.RegisterStartupScript(this.GetType(), "pop", newWin, true);
        }
    }
}