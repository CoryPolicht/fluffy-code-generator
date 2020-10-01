using Microsoft.Extensions.DependencyInjection;

namespace Sphinx.CodeGenerator.CSharp
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureCSharpGeneration(this IServiceCollection services)
        {
            services.AddScoped<ISyntaxProvider, ConvertToCSharpSyntax>();
            return services;
        }
    }
}