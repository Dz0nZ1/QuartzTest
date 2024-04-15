using Microsoft.Extensions.Logging;
using Quartz;
using QuartzTest.Application.Common.Interfaces;

namespace QuartzApplication.Infrastructure.Jobs;

public class ShowUsersJob(ILogger<ShowUsersJob> logger, IUserService userService) : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        userService.AddUser();
        logger.LogInformation($"{DateTime.UtcNow}" );
        return Task.CompletedTask;
    }
}