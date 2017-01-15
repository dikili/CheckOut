using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.DrinkServiceTests
{
    [TestFixture(Category = "DrinksApi")]
    public class DrinkServiceTests : BaseServiceTests
    {
        [Test]
        public void CreateDrink()
        { 
      
            var drinkModel = TestHelper.GetDrinkCreateModel();
            var response = CheckoutClient.DrinkInventoryService.CreateDrink(drinkModel);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response.Model.Should().BeTrue();
        }

        [Test]
        public void DeleteADrink()
        {

            var drinkId = TestHelper.GiveRandomDrinkId();
            var response = CheckoutClient.DrinkInventoryService.DeleteADrink(drinkId);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
           
            response.Model.Should().BeTrue();
        }



        [Test]
        public void UpdateADrink()
        {

            var drinkId = TestHelper.GiveRandomDrinkId();
            var response = CheckoutClient.DrinkInventoryService.UpdateADrink(drinkId,8);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response.Model.Should().BeTrue();
        }



        [Test]
        public void GetADrink()
        {

            var drinkId = TestHelper.GiveRandomDrinkId();
            var response = CheckoutClient.DrinkInventoryService.GetADrink(drinkId);

            response.Model.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response.Model.Id.Equals(drinkId);
        }
        [Test]
        public void GetAllDrinks()
        {
            var response = CheckoutClient.DrinkInventoryService.GetAllDrinks();

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
         
        }
    }
}
