/// Author : 曾文超
/// Create Date : 2009年7月14日
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gtspace.Common
{
    /// <summary>
    /// 前台JavaScript帮助器, 提供JavaScript格式化输出
    /// </summary>
    public class JavaScriptHelper
    {
        /// <summary>
        /// 描述 : 创建一个JavaScript表示的提示框代码, 将这些代码放到Html流里去就可以实现在客户端里弹出一个提示框的了
        ///          比如 : Label1.Text = MakeAlertForm("Hello");
        /// 创建人 : 曾文超
        /// 时间 : 2009年4月30日
        /// </summary>
        /// <param name="Message">提示消息</param>
        /// <returns>JavaScript代码</returns>
        public string MakeAlertForm(string Message)
        {
            return MakeJavaScript("alert(\"" + Message + "\");");
        }

        /// <summary>
        /// 构件一个客户端的重定向脚本
        /// </summary>
        /// <param name="url">绝对或相对地址</param>
        /// <returns></returns>
        public string MakeRedirectAction(string url)
        {
            return MakeJavaScript("window.location=\"" + url + "\"");
        }

        /// <summary>
        /// 创建一个打开一个面板的脚本
        /// </summary>
        /// <param name="panelId">容器的Id</param>
        /// <returns></returns>
        public string MakeOpenPanel(string panelId)
        {
            return MakeJavaScript("OpenPanel('" + panelId + "');");
        }

        /// <summary>
        /// 构件一段JavaScritp代码, 用<scritp></scritp>打包
        /// </summary>
        /// <param name="code">代码</param>
        /// <returns></returns>
        public string MakeJavaScript(string code)
        {
            return "<script language=\"javascript\">" + code +"</script>";
        }
    }
}
