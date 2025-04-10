using Entities.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HackerSpace.Data.DataServices
{
    public class EvaluationRequestDataService
    {
        private ApplicationDbContext _context;

        private AuthenticationStateProvider _authSateProvider;
        private IHttpContextAccessor _httpContextAccessor;

        public EvaluationRequestDataService(ApplicationDbContext context, AuthenticationStateProvider authStateProvider, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _authSateProvider = authStateProvider;
            _httpContextAccessor = httpContextAccessor;
        }

        public async void AddEvaluationRequestAsync(EvaluationRequest evaluationRequest)
        {
            //ClaimsPrincipal principal = _httpContextAccessor!.HttpContext!.User;
            //if (principal != null && principal.Identity != null && principal.Identity.IsAuthenticated)
            //{
            //    // Return a user object with the username and claims
            //    var userClaims = principal.Claims.Select(c => new Claim { Type = c.Type, Value = c.Value }).ToList();
            //    //return new User
            //    //{
            //    //    Username = principal.Identity!.Name,
            //    //    Claims = userClaims
            //    //};
            //}
            //else
            //{
            //    // Return an empty user object
            //    //return new User();
            //}


            //AuthenticationState authState = await _authSateProvider.GetAuthenticationStateAsync();
            //ClaimsPrincipal? claims = authState.User;
            //claims.Identity.

            //_context.Add(evaluationRequest);
            //await _context.SaveChangesAsync();
        }
    }
}
