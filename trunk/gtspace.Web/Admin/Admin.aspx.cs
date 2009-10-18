﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using gtspace.Web.Codes;
using gtspace.Common;
using gtspace.Common.Entity;

namespace gtspace.Web.Admin
{
	public partial class Admin : System.Web.UI.Page
	{
		/// <summary>
		/// 当前加载的页面
		/// </summary>
		protected string _load;

		/// <summary>
		/// 主导航栏
		/// </summary>
		protected string _main_nav;


		protected void Page_Load(object sender, EventArgs e)
		{
			SessionState.CurrentNavigation = Settings.RootNavigation.Childs[1];

			// 主导航栏
			foreach (Navigation nav in Settings.RootNavigation.Childs)
			{
				_main_nav += "<li><a href=\"?target=" + nav.Target + "\">" + nav.Name + "</a></li>";
			}

			// 加载页面
			_load = Request.QueryString["target"];
		}
	}
}
