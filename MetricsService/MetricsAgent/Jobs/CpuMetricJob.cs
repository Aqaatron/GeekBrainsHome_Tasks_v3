﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsAgent.DAL;
using Quartz;

namespace MetricsAgent.Jobs
{
    public class CpuMetricJob : IJob
    {
            private ICpuMetricsRepository _repository;

            public CpuMetricJob(ICpuMetricsRepository repository)
            {
                _repository = repository;
            }

            public Task Execute(IJobExecutionContext context)
            {
                // теперь можно записать что-то при помощи репозитория

                return Task.CompletedTask;
            }
    }
}
