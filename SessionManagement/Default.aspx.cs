using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnLogIn_Click(object sender, EventArgs e)
		{


			

			if (txtUser.Text=="cow" && txtPassword.Text=="moo")
			{
				string user = txtUser.Text;
				string pass = txtPassword.Text;
				Global.SessionUser = txtUser.Text;
				Global.SessionPass = txtPassword.Text;

				Response.Redirect("MembersMain.aspx?u=" + txtUser.Text + "&p=" + txtPassword.Text + "&e=" + "pg0");
			}

			else if (txtUser.Text == "bee" && txtPassword.Text == "buzz")
			{
				string user = txtUser.Text;
				string pass = txtPassword.Text;
				Global.SessionUser = txtUser.Text;
				Global.SessionPass = txtPassword.Text;

				Response.Redirect("MembersMain.aspx?u=" + txtUser.Text + "&p=" + txtPassword.Text + "&e=" + "pg0");
			}

			else
			{
				lblMessage.Text = "Account not recognized";
			}
	
		}
	}
}