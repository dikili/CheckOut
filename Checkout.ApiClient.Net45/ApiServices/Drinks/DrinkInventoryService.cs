using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Drinks
{
    class DrinkInventoryService
    {
        public HttpResponse<DrinkCreatedResp> CreateDrink( DrinkCreate requestModel)
        {
            var createCardUri = string.Format(ApiUrls.Cards);
            return null;//new ApiHttpClient().PostRequest<DrinkCreate>(createCardUri, AppSettings.SecretKey, requestModel);
        }
    }
}
