using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gtspace.Common.Contract;

namespace gtspace.Plugin.Demo1
{
	public class Class1 : IPlugin
	{

		#region IPlugin 成员

		void IPlugin.AdminPage_OnPreLoad(EventArgs e)
		{
			
		}

		void IPlugin.Application_AuthenticateRequest(object sender, EventArgs e)
		{
			
		}

		void IPlugin.Application_BeginRequest(object sender, EventArgs e)
		{
			HttpContext.Current.Response.Write("Hello");
			HttpContext.Current.Response.End();
		}

		void IPlugin.Application_End(object sender, EventArgs e)
		{
			
		}

		void IPlugin.Application_Error(object sender, EventArgs e)
		{
			
		}

		void IPlugin.Application_Start(object sender, EventArgs e)
		{
			
		}

		void IPlugin.Session_End(object sender, EventArgs e)
		{
			
		}

		void IPlugin.Session_Start(object sender, EventArgs e)
		{
			
		}

		#endregion
	}
}
