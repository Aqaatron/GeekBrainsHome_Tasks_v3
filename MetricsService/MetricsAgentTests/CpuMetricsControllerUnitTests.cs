using System;
using Xunit;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using MetricsManager.Enums;
using Moq;
using Microsoft.Extensions.Logging;
using MetricsAgent.DAL;
using AutoMapper;

namespace MetricsAgentTests
{
    public class CpuMetricsControllerUnitTests
    {
        private CpuMetricsController controller;

        private Mock<ILogger<CpuMetricsController>> mockLogger;

        private Mock<ICpuMetricsRepository> mockRepository;

        private Mock<IMapper> mockMapper;

        public CpuMetricsControllerUnitTests()
        {
            this.mockLogger = new Mock<ILogger<CpuMetricsController>>();

            this.mockRepository = new Mock<ICpuMetricsRepository>();

            this.mockMapper = new Mock<IMapper>();

            this.controller = new CpuMetricsController(mockLogger.Object, mockRepository.Object, mockMapper.Object);
        }

        //[Fact]
        //public void GetMetricsFromAgent_ReturnsOk()
        //{
        //    //Arrange
        //    var fromTime = new DateTimeOffset(new DateTime(2021, 05, 12, 06, 32, 00));
        //    var toTime = new DateTimeOffset(new DateTime(2021, 05, 12, 07, 32, 00));

        //    //Act
        //    var result = controller.GetMetrics(fromTime, toTime);

        //    // Assert
        //    _ = Assert.IsAssignableFrom<IActionResult>(result);
        //}

        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mockRepository.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // выполняем действие на контроллере
            //var result = controller.Create(new MetricsAgent.Requests.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mockRepository.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
    }
}
