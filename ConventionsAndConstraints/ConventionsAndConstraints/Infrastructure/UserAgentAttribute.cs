using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConventionsAndConstraints.Infrastructure
{
    public class UserAgentAttribute : Attribute, IActionConstraintFactory
    {
        private string substring;
        public UserAgentAttribute(string sub) => substring = sub;

        public IActionConstraint CreateInstance(IServiceProvider services) => 
            new UserAgentConstraint((UserAgentComparer)services.GetService(
                typeof(UserAgentComparer)), substring);

        public bool IsReusable => false;

        private class UserAgentConstraint : IActionConstraint
        {
            private UserAgentComparer comparer;
            private string substring;

            public UserAgentConstraint(UserAgentComparer comp, string sub)
            {
                comparer = comp;
                substring = sub.ToLower();
            }

            public int Order { get; set; } = 0;

            public bool Accept(ActionConstraintContext context) => comparer.ContainsString(context.RouteContext
                .HttpContext.Request, substring) || context.Candidates.Count() == 1;
        }
    }

    //public class UserAgentAttribute : Attribute, IActionConstraint
    //{
    //    private string substring;

    //    public UserAgentAttribute(string sub) => substring = sub.ToLower();

    //    public int Order => 0;

    //    public bool Accept(ActionConstraintContext context) => context.RouteContext.HttpContext
    //            .Request.Headers["User-Agent"]
    //            .Any(h => h.ToLower().Contains(substring))
    //                || context.Candidates.Count() == 1;
    //}
}
