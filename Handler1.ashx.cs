using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["userName"].ToString().Trim();
            string message = context.Request["message"].ToString().Trim();
            context.Response.Write(userName+message+"傻儿子们！！！");
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}