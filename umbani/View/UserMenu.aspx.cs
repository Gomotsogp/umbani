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
    }
}