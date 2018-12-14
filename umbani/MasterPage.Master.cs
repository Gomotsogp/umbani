using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace umbani
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void dlUtilities_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(dlUtilities.SelectedItem.Value);
        }
    }
}