using System;
using Microsoft.Extensions.DependencyInjection;
using Sphinx.CodeGenerator.Application.UseCases;
using Sphinx.CodeGenerator.Application.UseCases.Boundaries.CreateNameSpace;

namespace Sphinx.CodeGenerator.Application
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<ICreateNameSpace, CreateNameSpaceUseCase>();
            
            return services;
        }
    }
}