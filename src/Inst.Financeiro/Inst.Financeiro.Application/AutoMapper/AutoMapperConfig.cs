using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Inst.Financeiro.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection AutoMapperConfigure(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ViewModelToModelProfile());
                mc.AddProfile(new ModelToViewModelProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }        
    }
}
