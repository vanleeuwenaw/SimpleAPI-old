using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();

        [Fact]
        public void GetMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Anthony", returnValue.Value);
        }



        [Fact]
        public void Test1()
        {

        }
    }
}
