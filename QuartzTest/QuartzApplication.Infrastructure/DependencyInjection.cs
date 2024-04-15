using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Quartz;
using QuartzApplication.Infrastructure.Jobs;
using QuartzApplication.Infrastructure.Services;
using QuartzTest.Application.Common.Interfaces;

namespace QuartzApplication.Infrastructure;

public static class DependencyInjection
{
 
 [Obsolete("Obsolete")]
 public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
 {
  
  serviceCollection.AddQuartz(options =>

    {
     var jobKey = JobKey.Create(nameof(ShowUsersJob));
     options.UseMicrosoftDependencyInjectionJobFactory();
     
     options.AddJob<ShowUsersJob>(jobKey)
      .AddTrigger(trigger =>
       trigger.ForJob(jobKey)
        
        // .WithCronSchedule("0 6 23 * * ?"));
        
        .WithSimpleSchedule(
        schedule => 
         schedule.WithIntervalInSeconds(5)
        .RepeatForever()));
    }
   
    );
  
  serviceCollection.AddQuartzHostedService();
   serviceCollection.AddScoped<IUserService, UserService>();
  return serviceCollection;
 }
}