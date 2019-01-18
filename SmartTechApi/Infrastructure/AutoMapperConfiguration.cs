using AutoMapper;
using SmartTech.Data.Entities;
using SmartTechApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTechApi.Infrastructure
{
    /// <summary>
    /// Represent the AutoMapper configuration.
    /// For more info look at https://automapper.org/
    /// </summary>

    public static class AutoMapperConfiguration
    {

        /// <summary>
        /// Initialize the configuration of auto mapper.
        /// </summary>
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentModel, Student>(MemberList.None).ReverseMap();
                //.ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))

            });
            Mapper = MapperConfiguration.CreateMapper();
        }
        // <summary>
        /// Mapper
        /// </summary>
        public static IMapper Mapper { get; private set; }

        /// <summary>
        /// Mapper configuration
        /// </summary>
        public static MapperConfiguration MapperConfiguration { get; private set; }
    }
}