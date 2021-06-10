using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class ThirdPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var hUser = HashBuilder.CreateHash(Context.Request["u"]);
            var hPass = HashBuilder.CreateHash(Context.Request["p"]);
            lblUser.Text = $"Your user name {Context.Request["u"]} had a hashed value of {hUser}.";
            Label2.Text = $"Your password {Context.Request["p"]} had a hashed value of {hPass}.";
        }
    }
}