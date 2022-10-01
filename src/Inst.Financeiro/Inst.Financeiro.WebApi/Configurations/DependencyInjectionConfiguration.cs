using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.Application.Services;
using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Services;
using Inst.Financeiro.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Inst.Financeiro.WebApi.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IPessoaAppService, PessoaAppService>();

            services.AddScoped<IPessoaService, PessoaService>();

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            return services;
        }
    }
}
