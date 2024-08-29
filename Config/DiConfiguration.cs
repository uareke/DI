using DI.Services.Interfaces;
using DI.Services;
using System.Runtime.CompilerServices;
using System.Reflection;
using DI.Attributes;
using DI.Enum;

namespace DI.Config
{
    public static class DiConfiguration
    {
        public static IServiceCollection ResolveDependencias(this  IServiceCollection services)
        {
            var serviceAssembly = typeof(IHelperService).Assembly;
            var registrationsService =
                from type in serviceAssembly.GetExportedTypes()
                where type.Namespace.StartsWith("DI.Services")
                && !type.IsAbstract
                from service in type.GetInterfaces()
                select new { service, implementation = type };

            foreach (var regService in registrationsService)
            {
                var tipoInjecaoAttr = regService.service.GetCustomAttribute<TipoInjecaoAttribute>();

                if (tipoInjecaoAttr != null)
                {
                    switch (tipoInjecaoAttr.Tipo)
                    {
                        case EnumTipoInjecao.Scoped:
                            services.AddScoped(regService.service, regService.implementation);
                            break;
                        case EnumTipoInjecao.Transient:
                            services.AddTransient(regService.service, regService.implementation);
                            break;
                        case EnumTipoInjecao.Singleton:
                            services.AddSingleton(regService.service, regService.implementation);
                            break;
                        default:
                            throw new ArgumentException($"Tipo de injeção '{tipoInjecaoAttr.Tipo}' não é válido para {regService.service.Name}");
                    }
                }
                else
                {
                    services.AddScoped(regService.service, regService.implementation);
                }
            }

                return services;
        }
    }
}
