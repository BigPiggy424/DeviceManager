using System.Threading.Tasks;
using DeviceManagement.Models.TokenAuth;
using DeviceManagement.Web.Controllers;
using Shouldly;
using Xunit;

namespace DeviceManagement.Web.Tests.Controllers
{
    public class HomeController_Tests: DeviceManagementWebTestBase
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