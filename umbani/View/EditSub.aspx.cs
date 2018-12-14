using System;
using umbani.Data_Access_Layer;

namespace umbani.View
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
          //  dh.updateSubscription(int.Parse(TextBox1.Text), TextBox2.Text);
        }
    }
}