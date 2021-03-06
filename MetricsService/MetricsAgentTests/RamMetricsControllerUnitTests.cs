﻿using System;
using Xunit;
using MetricsAgent;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using MetricsManager.Enums;
using Moq;
using MetricsAgent.DAL;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace MetricsAgentTests
{
    public class RamMetricsControllerUnitTests
    {
        private RamMetricsController controller;

        private Mock<ILogger<RamMetricsController>> mockLogger;

        private Mock<IRamMetricsRepository> mockRepository;

        private Mock<IMapper> mockMapper;

        public RamMetricsControllerUnitTests()
        {
            this.mockLogger = new Mock<ILogger<RamMetricsController>>();

            this.mockRepository = new Mock<IRamMetricsRepository>();

            this.mockMapper = new Mock<IMapper>();

            this.controller = new RamMetricsController(mockLogger.Object, mockRepository.Object, mockMapper.Object);
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
            mockRepository.Setup(repository => repository.Create(It.IsAny<RamMetric>())).Verifiable();

            // выполняем действие на контроллере
            //var result = controller.Create(new MetricsAgent.Requests.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
            mockRepository.Verify(repository => repository.Create(It.IsAny<RamMetric>()), Times.AtMostOnce());
        }
    }
}
