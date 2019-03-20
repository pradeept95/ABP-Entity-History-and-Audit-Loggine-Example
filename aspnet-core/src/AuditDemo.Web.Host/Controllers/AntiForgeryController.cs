using Microsoft.AspNetCore.Antiforgery;
using AuditDemo.Controllers;

namespace AuditDemo.Web.Host.Controllers
{
    public class AntiForgeryController : AuditDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
