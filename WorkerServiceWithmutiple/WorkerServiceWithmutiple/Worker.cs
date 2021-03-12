using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerServiceWithmutiple
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var re = await GetDataFromAPIAsync1();
                var re1 = await GetDataFromAPIAsync2();
                var re3 = await GetDataFromAPIAsync3();
                var re4 = await GetDataFromAPIAsync4();
                await Task.Delay(500, stoppingToken);
            }
        }

        private async Task<bool> GetDataFromAPIAsync1()
        {
            _logger.LogInformation("Worker 0 : 1  running at: {time}", DateTimeOffset.Now);
            return true;
        }

        private async Task<bool> GetDataFromAPIAsync2()
        {
            _logger.LogInformation("Worker 0 : 2   running at: {time}", DateTimeOffset.Now);
            return true;
        }

        private async Task<bool> GetDataFromAPIAsync3()
        {
            _logger.LogInformation("Worker 0 : 3   running at: {time}", DateTimeOffset.Now);
            return true;
        }

        private async Task<bool> GetDataFromAPIAsync4()
        {
            _logger.LogInformation("Worker 0 : 4   running at: {time}", DateTimeOffset.Now);
            return true;
        }


    }
}
