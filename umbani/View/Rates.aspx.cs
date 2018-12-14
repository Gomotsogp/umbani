using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbani.Data_Access_Layer;


namespace umbani.View
{
    public partial class Rates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
           // dh.InsertRates(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        }
    }
}