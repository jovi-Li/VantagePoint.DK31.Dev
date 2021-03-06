using Microsoft.Extensions.DependencyInjection;
using Serenity;
using System;

namespace VantagePoint.AppServices
{
    public class DependencyResolver : IDependencyResolver
    {
        private IServiceProvider provider;

        public DependencyResolver(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public TService Resolve<TService>() where TService : class
        {
            return provider.GetRequiredService<TService>();
        }

        public TService TryResolve<TService>() where TService : class
        {
            return provider.GetService<TService>();
        }
    }
}