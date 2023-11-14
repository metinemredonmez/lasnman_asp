using System.Threading.Tasks;
using lansman.Models.TokenAuth;
using lansman.Web.Controllers;
using Shouldly;
using Xunit;

namespace lansman.Web.Tests.Controllers
{
    public class HomeController_Tests: lansmanWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}