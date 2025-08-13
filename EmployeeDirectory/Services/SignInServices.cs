using EmployeeDirectory.Models.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using EmployeeDirectory.Components.Pages.Auth;
using Telerik.SvgIcons;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;
using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Authentication;

namespace EmployeeDirectory.Services
{
    public class SignInServices
    {
        private readonly IDbContextFactory<AppDbContext> _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly NavigationManager _navigation;
        public SignInServices(
            IDbContextFactory<AppDbContext> context,
            IHttpContextAccessor httpContextAccessor,
            NavigationManager navigation)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _navigation = navigation;
        }
        public async Task UserSignInAsync( UserAccount userAccount)
        {
            var claims = new List<Claim>
            {
            new Claim(ClaimTypes.Name, userAccount.UserName)
            };

            //Add policies
            var context = _context.CreateDbContext();
            var httpContext = _httpContextAccessor.HttpContext;
            var navigation = _navigation;

            var accountPosition = context.Permissions.Where(x => x.Id == userAccount.PermissionID).FirstOrDefault();
            claims.Add(new Claim("Position", accountPosition.Position));

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await httpContext!.SignInAsync(principal);
            //navigation.NavigateTo("/");
        }
    }
}
