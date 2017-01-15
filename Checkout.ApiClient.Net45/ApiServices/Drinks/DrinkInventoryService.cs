using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Drinks
{
    public class DrinkInventoryService
    {
        public HttpResponse<bool> CreateDrink(DrinkCreate requestModel)
        {
            var drinkCreateUri = string.Format(ApiUrls.DrinksCreateUrl,requestModel.DrinkName,requestModel.Quantity);
            return new ApiHttpClient().PostRequest<bool>(drinkCreateUri, AppSettings.DrinkAuthKey, requestModel);
        }

        public HttpResponse<bool> DeleteADrink(int Id)
        {
            var drinkRemoveUri = string.Format(ApiUrls.DrinkDeleteUrl, Id);
            return new ApiHttpClient().DeleteRequest<bool>(drinkRemoveUri, AppSettings.DrinkAuthKey);
        }

        public HttpResponse<bool> UpdateADrink(int Id,int quantity)
        {
            var drinkUpdateUri = string.Format(ApiUrls.DrinkUpdateUrl, Id,quantity);
            return new ApiHttpClient().PutRequest<bool>(drinkUpdateUri, AppSettings.DrinkAuthKey);
        }

        public HttpResponse<DrinkResp> GetADrink(int Id)
        {
            var drinkGetUri = string.Format(ApiUrls.DrinkGetUrl, Id);
            return new ApiHttpClient().GetRequest<DrinkResp>(drinkGetUri, AppSettings.DrinkAuthKey);
        }

        public HttpResponse<IEnumerable<DrinkResp>> GetAllDrinks()
        {
            var drinkAllUri = string.Format(ApiUrls.DrinkAllUrl);
            return new ApiHttpClient().GetRequest<IEnumerable<DrinkResp>>(drinkAllUri, AppSettings.DrinkAuthKey);
        }

    }
}
