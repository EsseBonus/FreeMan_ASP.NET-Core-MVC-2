using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        //[Fact]
        //public void ViewSelected()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.ReceiveForm("Adam", "London");

        //    // Assert
        //    Assert.Equal("Result", result.ViewName);
        //}

        //[Fact]
        //public void ModelObjectType()
        //{
        //    //Arrange
        //    ExampleController controller = new ExampleController();

        //    // Act
        //    ViewResult result = controller.Index();

        //    // Assert
        //    Assert.IsType<DateTime>(result.ViewData.Model);
        //}

        //[Fact]
        //public void ModelObjectTypeViewBag()
        //{
        //    //Arrange
        //    ExampleController controller = new ExampleController();

        //    // Act
        //    ViewResult result = controller.Index();

        //    // Assert
        //    Assert.IsType<string>(result.ViewData["Message"]);
        //    Assert.Equal("Hello", result.ViewData["Message"]);
        //    Assert.IsType<DateTime>(result.ViewData["Date"]);
        //}

        //[Fact]
        //public void Redirection()
        //{
        //    // Arrange
        //    ExampleController controller = new ExampleController();

        //    // Act
        //    RedirectToRouteResult result = controller.Redirect();

        //    // Assert
        //    Assert.False(result.Permanent);
        //    Assert.Equal("Example", result.RouteValues["controller"]);
        //    Assert.Equal("Index", result.RouteValues["action"]);
        //    Assert.Equal("MyID", result.RouteValues["ID"]);
        //}

        [Fact]
        public void NotFoundActionMethod()
        {
            // Arrange
            ExampleController controller = new ExampleController();

            // Act
            StatusCodeResult result = controller.Index();

            // Assert
            Assert.Equal(404, result.StatusCode);
        }
    }
}
