using Microsoft.Extensions.DependencyInjection;
using SeaBattle.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Configurations
{
    public class RepositoriesConfig
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddSingleton<IGameRepository, Repositories.GameRepository>();
        }
    }
}
