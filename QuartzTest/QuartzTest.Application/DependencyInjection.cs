using Microsoft.Extensions.DependencyInjection;
using QuartzTest.Application.Common.Interfaces;

namespace QuartzTest.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        return serviceCollection;
    }
}