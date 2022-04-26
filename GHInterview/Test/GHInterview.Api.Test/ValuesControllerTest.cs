using GHInterview.Controllers;
using GHInterview.Domain;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace GHInterview.Api.Test
{
    public class ValuesControllerTest
    {
        [Fact]
        public void Get_GivenValidId_ReturnsOk()
        {
            //Arrange
            var expectedStr = "Hello World!";
            var id = 1;
            var serviceMock = new Mock<IValueService>();
            serviceMock.Setup(x => x.GetValue()).Returns(expectedStr);

            var target = new ValuesController(serviceMock.Object);

            //Act
            var result = target.Get(id) as OkObjectResult;

            //Assert
            var expectedStatusCode = 200;
            Assert.Equal(expectedStatusCode, result?.StatusCode);
            Assert.Equal(expectedStr, result?.Value);
        }
    }
}