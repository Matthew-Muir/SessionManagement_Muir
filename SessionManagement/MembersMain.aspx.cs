using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
	public partial class MembersMain : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			string user = Global.SessionUser;
			string pass = Global.SessionPass;

			lblUser.Text = "Hello, " + user + ", your password is " + pass;

		}

		protected void NextPage_Click(object sender, EventArgs e)
		{
			string user = Global.SessionUser;
			string pass = Global.SessionPass;

			Response.Redirect("ThirdPage.aspx?u=" + user + "&p=" + pass);


		}
	}
}