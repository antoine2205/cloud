using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using RailDelay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Authorization
{
    public class DelayIsOwnerAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Delay>
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DelayIsOwnerAuthorizationHandler(UserManager<IdentityUser> UserManager)
        {
            _userManager = UserManager;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Delay resource )
        {
            if(context.User == null)
            {
                return Task.CompletedTask;
            }

            if (resource.OwnerID == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
