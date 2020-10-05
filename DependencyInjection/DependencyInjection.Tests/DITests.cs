using DependencyInjection.Controllers;
using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DependencyInjection.Tests
{
   public class DITests
    {
        [Fact]
        public void ControllerTest()
        {
            // Arrange
            Product[] data = new[] { new Product { Name = "Test", Price = 100 } };
            Mock<IRepository> mock = new Mock<IRepository>();

            mock.SetupGet(m => m.Products).Returns(data);

            HomeController controller = new HomeController(mock.Object);

            // Act
            ViewResult result = controller.Index();

            // Assert
            Assert.Equal(data, result.ViewData.Model);
        }
    }
}
