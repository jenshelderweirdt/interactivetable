using Microsoft.Extensions.DependencyInjection;

namespace InteractiveTableBootstrap
{
	public static class DependencyRegistration
	{
		public static IServiceCollection AddBusinessServices(this IServiceCollection services)
		{
	       // Register your business services here, e.g. services.AddTransient<IMyService, MyService>();
           
           return services;
		}
	}
}