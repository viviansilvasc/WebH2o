using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebH2O
{
    public partial class Relatorios : System.Web.UI.Page
    {
        public Boolean admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            Login lX = (Login)Session["email"];
            if (!admin) Response.Redirect("Default.aspx");

        }

		protected void btnLogout_Click(object sender, EventArgs e)
		{
			HttpCookie cookie = new HttpCookie("login");
			cookie.Expires = DateTime.Now.AddYears(-1);
			Response.Cookies.Add(cookie);
			Response.Redirect("default.aspx");
		}
	}
}