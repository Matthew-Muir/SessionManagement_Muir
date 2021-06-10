using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Specialized;
using System.Web.SessionState;

namespace SessionManagement
{
	public class EncryptionModule : IHttpModule
	{

		static string CreateHash(string plainTxt)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainTxt));

				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

		public void Dispose()
		{
			// nothing to dispose
		}

		public void Init(HttpApplication context)
		{
			context.BeginRequest += new EventHandler(OnBeginRequest);
			context.EndRequest += new EventHandler(OnEndRequest);
			context.Context.SetSessionStateBehavior(SessionStateBehavior.ReadOnly);
		}

		private void OnEndRequest(object sender, EventArgs e)
		{
			HttpApplication application = (HttpApplication)sender;
			HttpContext context = HttpContext.Current;

			

		}

		private void OnBeginRequest(object sender, EventArgs e)
		{

			HttpApplication application = (HttpApplication)sender;
			HttpContext context = application.Context;




			if (HttpContext.Current.Request.RawUrl.Contains("&e=pg0"))
			{
				string user = context.Request["u"];
				string pass = context.Request["p"];

				string hUser = HashBuilder.CreateHash(user);
				string hPass = HashBuilder.CreateHash(pass);



				context.Response.Redirect("MembersMain.aspx?u=" + hUser + "&p=" + hPass + "&e=" + "pg1");

			}

			


		}
	}
}