using System;
using System.Security.Claims;
using System.Security.Principal;

namespace CalendarNotes.Web.ExtentionMethod
{
    public static class IdentityExtentions
    {
        public static int? GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
                throw new ArgumentNullException(nameof(principal));

            return principal.FindFirst(ClaimTypes.NameIdentifier) == null ? (int?)null : Convert.ToInt32(principal.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        public static int? GetUserId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.NameIdentifier);
            return claim == null ? (int?)null : Convert.ToInt32(claim.Value);
        }
    }
}
