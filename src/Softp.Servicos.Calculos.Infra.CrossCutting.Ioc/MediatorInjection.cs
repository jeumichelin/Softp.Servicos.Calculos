using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Softp.Servicos.Calculos.Infra.CrossCutting.Ioc{
        public static class MediatorInjection
    {
        private static Assembly DomainAssembly => AppDomain.CurrentDomain.Load("Softp.Servicos.Calculos.Domain");

        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(DomainAssembly);
        }
    }
}