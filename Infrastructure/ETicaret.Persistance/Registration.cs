﻿using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Persistance.Contexts;
using ETicaret.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance
{
    public static class Registration
    {

        public static void PersistanceRegistration(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<TicaretContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
           
            serviceCollection.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            serviceCollection.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

        }



    }
}
