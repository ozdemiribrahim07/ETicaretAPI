﻿using AutoMapper;
using AutoMapper.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Mapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {

        public static List<TypePair> typePairs = new();

        private IMapper MapperContainer;


        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> sources, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<IList<TSource>, IList<TDestination>>(sources);
        }

        

        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<TSource, TDestination>(source);
        }




        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination,object>(5, ignore);
            return MapperContainer.Map<TDestination>(source);
        }



        public IList<TDestination> Map<TDestination>(IList<object> sources, string? ignore = null)
        {
            Config<TDestination, IList<object>>(5, ignore);
            return MapperContainer.Map<IList<TDestination>>(sources);
        }





        protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
        {
            var typePair = new TypePair(typeof(TSource),typeof(TDestination));

            if (typePairs.Any(x => x.DestinationType == typePair.DestinationType && x.SourceType == typePair.SourceType) && ignore is null)
            {
                return;
            }

            typePairs.Add(typePair);

            var config = new MapperConfiguration(opt =>
            {
                foreach (var item in typePairs)
                {

                    if (ignore != null)
                    {
                        opt.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    }
                    opt.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();


                }
            });

            MapperContainer = config.CreateMapper();



        }


    }
}
