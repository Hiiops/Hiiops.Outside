using Hiiops.Applet;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;


namespace VOL.Core.WeChat
{
    /// <summary>
    /// action 处理类
    /// </summary>
    public class ActionCollection : Dictionary<string, Action<HttpContext>>
    {
        public ActionCollection()
        { 
            Add("Porttal", PorttalAction); 
        }

        public new ActionCollection Add(string action, Action<HttpContext> handler)
        {
            if (ContainsKey(action))
                this[action] = handler;
            else
                base.Add(action, handler);

            return this;
        }

        public new ActionCollection Remove(string action)
        {
            base.Remove(action);
            return this;
        }
         
        /// <summary>
        /// 微信网关
        /// </summary>
        /// <param name="context"></param>
        private void PorttalAction(HttpContext context)
        {
            new PorttalHandler(context).Process();
        }

    }
}

