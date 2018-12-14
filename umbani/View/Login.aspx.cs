using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using umbani.Models;


namespace umbani.View
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                  //  StatusText.Text = string.Format("Hello {0}!!", User.Identity.GetUserName());
                    //LoginStatus.Visible = true;
                   // LogoutButton.Visible = true;
                }
                else
                {
                   // LoginForm.Visible = true;
                }
            }
        }

        private User u = new User();
        protected void SignIn(object sender, EventArgs e)
        {
            /*if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(username.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        break;
                    case SignInStatus.LockedOut:
                        Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}",
                                Request.QueryString["ReturnUrl"],
                                RememberMe.Checked),
                            true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        FailureText.Text = "Invalid login attempt";
                        ErrorMessage.Visible = true;
                        break;
                }
            }*/

            foreach (var user in u.GetUsers())
            {
                if ((user.Username == txtUserName.Text) && (user.Password== txtPassword.Text))
                {
                    Session["Authenticated"] = user.Id;
                    Response.Redirect("CustomerMenu.aspx");
                    break;
                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('Invalid User Credentials')</script>");
                }
            }

        }

        protected void SignOut(object sender, EventArgs e)
        {
            /*var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("LogOutScreen.aspx");*/

        }

    }
}