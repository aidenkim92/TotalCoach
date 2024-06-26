namespace TotalCoachCodingTestProject.Helpers{
    public static class MediatRDependencyHandler
    {
        public static IServiceCollection RegisterRequestHandlers(
        this IServiceCollection services)
        {
            return services
                .AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(MediatRDependencyHandler).Assembly));
        }
    }
}   