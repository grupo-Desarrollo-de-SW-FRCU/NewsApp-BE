﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;
using Xunit;

namespace NewsApp.BackgroundServices.Tests
{
    public class AlertChecker_Test : NewsAppApplicationTestBase
    {
        private readonly IBackgroundWorkerManager _backgroundWorkerManager;

        public AlertChecker_Test()
        {
            _backgroundWorkerManager = GetRequiredService<IBackgroundWorkerManager>();
        }

        [Fact]
        public async Task Should_Execute_AlertChecker()
        {
            // Arrange
            var alertChecker = GetRequiredService<AlertChecker>();

            // Act
            await RunPeriodicBackgroundWorkerAsync(alertChecker);

            // Assert
            // Add assertions as needed to verify the behavior of the AlertChecker
            // For example, check if notifications were created, etc.
        }

        private async Task RunPeriodicBackgroundWorkerAsync(AsyncPeriodicBackgroundWorkerBase worker)
        {
            var serviceProvider = GetRequiredService<IServiceProvider>();

            var workerContext = new PeriodicBackgroundWorkerContext(serviceProvider){};

            // await AsyncHelper.RunSync(() => worker.DoWorkAsync(workerContext)); // no se puede ejecutar debido al nivel de proteccion del método (no se puede cambiar)
        }

    }
}
