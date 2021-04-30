using System;
using Xunit;
using MetricsAgent;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using MetricsManager.Enums;

namespace MetricsAgentTests
{
    public class RamMetricsControllerUnitTests
    {
        private RamMetricsController controller;

        public RamMetricsControllerUnitTests()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange


            //Act
            var result = controller.GetMetrics();

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
