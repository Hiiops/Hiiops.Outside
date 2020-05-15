using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using VOL.Core.Extensions;
using VOL.Core.Handler;
using VOL.Core.Utilities;

namespace Hiiops.Applet
{
    public class PorttalHandler : Handler
    {
        public WebResponseContent webResponseContent { get; private set; }

        public PorttalHandler(Microsoft.AspNetCore.Http.HttpContext context)
           : base(context)
        {
            this.webResponseContent = new WebResponseContent().Error("未知错误");
        }
        public override void Process()
        {
            try {
                webResponseContent = new WebResponseContent().OK();
            }
            catch(Exception e){
                webResponseContent = new WebResponseContent().Error(e.Message);
            }
            finally
            {
                WriteJson(webResponseContent.ToJson());
            }
        }
          
    }
}
