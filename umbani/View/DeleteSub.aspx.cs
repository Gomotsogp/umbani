using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbani.Data_Access_Layer;

namespace umbani.View
{
    public partial class DeleteSub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
           // dh.Delete(int.Parse(TextBox1.Text));
        }
    }
}