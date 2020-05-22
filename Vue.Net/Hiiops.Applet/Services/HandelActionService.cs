using Hiiops.Applet.IServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Core.Handler;
using VOL.Core.WeChat;

namespace Hiiops.Applet.Services
{


    public class HandelActionService : BaseService, IHandelAction, IDependency
    {
        private ActionCollection actionList = new ActionCollection();
        public HandelActionService()
        {
        }
        public static IHandelAction Instance
        {
            get { return AutofacContainerModule.GetService<IHandelAction>(); }
        }
        public void DoAction(HttpContext context)
        {
            var action = context.Request.Query["action"];
            if (action.Count <= 0)
            {
                new NotSupportedHandler(context).Process();
                return;
            }
            if (actionList.ContainsKey(action))
                actionList[action].Invoke(context);
            else
                new NotSupportedHandler(context).Process();
        }
    }
}
