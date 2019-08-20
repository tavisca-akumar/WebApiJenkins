using System;
using Xunit;
using WebApplication1.Controllers;

namespace WebApplicationInterfaceTests
{
    public class UnitTest1
    {
        ValuesController ValuesController = new ValuesController();

        [Fact]
        public void Test1()
        {
            var result = ValuesController.Get("hello");
            Assert.Equal("hi", result);

        }

        [Fact]

        public void Test2()
        {
            var result = ValuesController.Get("hi");
            Assert.Equal("hello", result);
        }
    }

    
}
