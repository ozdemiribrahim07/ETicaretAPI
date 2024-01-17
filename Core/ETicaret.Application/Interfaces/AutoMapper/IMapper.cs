using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        IList<TDestination> Map<TDestination,TSource>(IList<TSource> sources, string? ignore = null);

        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);

        //

        TDestination Map<TDestination>(object sources, string? ignore = null);

        IList<TDestination> Map<TDestination>(IList<object> sources, string? ignore = null);

    }
}
