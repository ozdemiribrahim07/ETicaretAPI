using ETicaret.Application.Interfaces.AutoMapper;
using ETicaret.Mapper.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Mapper
{
    public static class Registration
    {
        public static void MapperRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }

    }
}
