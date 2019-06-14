using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Authorization
{
    public class DelaysOperations
    {
        public static OperationAuthorizationRequirement create = new OperationAuthorizationRequirement() { Name = Constants.CreateOperations};
    }

    public class Constants
    {
        public static readonly string CreateOperations = "Create";
    }
}
