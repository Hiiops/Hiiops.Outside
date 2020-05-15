using Microsoft.AspNetCore.Http;

namespace Hiiops.Applet.IServices
{
    public interface IHandelAction : VOL.Core.BaseInterface.IServices
    { 
        void DoAction(HttpContext context);
    }
}
