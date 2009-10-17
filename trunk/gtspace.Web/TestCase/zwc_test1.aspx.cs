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
using gtspace.Common;
using System.IO;

namespace gtspace.Web.TestCase
{
	public partial class zwc_test1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			// 加载插件
			try
			{
				Directory.CreateDirectory(Settings.RootPath + @"bin\addons");
				Directory.CreateDirectory(Settings.RootPath + @"Admin\AddOns\Default");
				File.Copy(@"D:\Temp\AddOn\gtspace.AddOn.Default.dll", Settings.RootPath + @"bin\addons\gtspace.AddOn.Default.dll", true);
				File.Copy(@"D:\Temp\AddOn\index.aspx", Settings.RootPath + @"Admin\AddOns\Default\index.aspx", true);
				HyperLink1.NavigateUrl = "~/Admin/AddOns/Default/index.aspx";
			}
			catch (Exception ex)
			{
				Label1.Text = "加载失败 : " + ex.Message;
				return;
			}
			Label1.Text = "加载成功";
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			// 卸载插件

			try
			{
				Directory.Delete(Settings.RootPath + @"bin\addons", true);
				Directory.Delete(Settings.RootPath + @"Admin\AddOns\Default", true);
			}
			catch (Exception ex)
			{
				Label1.Text = "卸载失败 : " + ex.Message;
				return;
			}
			Label1.Text = "卸载成功";
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			// 设置Session
			Session["Demo"] = "this data is from session.";
		}

		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender(e);

			Label2.Text = Session["Demo"] as string;
		}
	}
}
