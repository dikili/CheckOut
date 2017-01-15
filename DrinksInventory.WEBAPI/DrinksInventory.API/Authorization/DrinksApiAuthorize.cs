using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using IAuthorizationFilter = System.Web.Http.Filters.IAuthorizationFilter;

namespace DrinksInventory.API.Authorization
{
    public class DrinksApiAuthorize: System.Web.Http.AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {

            try
            {
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string username = decodedToken.Substring(0, decodedToken.IndexOf(":"));
                string password = decodedToken.Substring(decodedToken.IndexOf(":") + 1);

                if (username.ToUpper() == "CHECKOUT" && password.ToUpper() == "ME") return true;
            }
            catch (Exception ex)
            {
                
            }

            return false;


        }


    }
}


