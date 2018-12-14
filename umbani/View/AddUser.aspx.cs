using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using umbani.Data_Access_Layer;
using Microsoft.AspNet.Identity.Owin;
using umbani.Models;

namespace umbani.View
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            /*var user = new ApplicationUser() { UserName = txtUsername.Text, Email = txtEmail.Text,FullName = txtName.Text};
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }*/
            User u = new User();
            if ((txtName.Text!="") && (txtEmail.Text != "") && (txtUsername.Text != "") && (txtPassword.Text != "") && (txtConfirmPas.Text != ""))
            {
                if (txtConfirmPas.Text == txtPassword.Text)
                {
                    u.SaveUser(txtName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);
                    Response.Write(@"<script language='javascript'>alert('subscription updated successfully')</script>");
                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('Passwords do not match')</script>");
                }
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Please make sure all fields are filled in')</script>");
            }
        }
    }
}