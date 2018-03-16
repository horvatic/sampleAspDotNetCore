using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TestServer.Core.Controllers;
using TestServer.Core.Models;
using Xunit;

namespace TestServer.Test.HelloWorld
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void GetGreeting_SayHello_Success()
        {
            var controller = new HelloWorldController();

            var package = controller.GetHelloWorld();

            var wrapedResult = Assert.IsType<ObjectResult>(package).Value;
            var result = Assert.IsType<Talker>(wrapedResult);
            Assert.Equal("Hello World", result.Hello);
        }
    }
}
