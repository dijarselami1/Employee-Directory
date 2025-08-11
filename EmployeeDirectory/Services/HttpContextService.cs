using Microsoft.AspNetCore.Http;

namespace EmployeeDirectory.Services
{
    public class HttpContextService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public HttpContextService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

    }
}
