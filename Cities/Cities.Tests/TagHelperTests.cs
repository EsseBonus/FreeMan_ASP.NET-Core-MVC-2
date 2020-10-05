using Cities.Infrastructure.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Cities.Tests
{
    public class TagHelperTests
    {
        [Fact]
        public void TestTagHelper()
        {
            // Arrange
            TagHelperContext context = new TagHelperContext(
                new TagHelperAttributeList(), new Dictionary<object, object>(), "myuniqueid");

            TagHelperOutput output = new TagHelperOutput("button", new TagHelperAttributeList(), (cache, encoder) => Task.FromResult<TagHelperContent>(new DefaultTagHelperContent()));

            // Act
            ButtonTagHelper tagHelper = new ButtonTagHelper
            {
                BsButtonColor = "testValue"
            };

            tagHelper.Process(context, output);

            // Assert
            Assert.Equal($"btn btn-{tagHelper.BsButtonColor}", output.Attributes["class"].Value);
        }
    }
}
