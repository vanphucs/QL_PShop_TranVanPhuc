using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace QL_PShop_TranVanPhuc.WEB.Pages
{
    public class BoDieuKhien : Controller
    {
        [Route("/authenticate")]
        public async Task<IActionResult> Authenticate([FromQuery] string user, [FromQuery] string pwd)
        {
            if (user == "admin" && pwd == "phuc1234")
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Email, "admin@pshop.com"),
                    new Claim(ClaimTypes.HomePhone, "12345678")
                };
                var userIdentity = new ClaimsIdentity(userClaims, "PShop.XacThucCookie");
                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("PShop.XacThucCookie", userPrincipal);
            }
            return Redirect("/outstandingorders");
        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/outstandingorders");
        }
    }
}
