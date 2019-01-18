using SmartTech.Data.Entities;
using SmartTechApi.Infrastructure;
using SmartTechApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTechApi.Extensions
{
    public static class MappingExtension
    {
        /// <summary>
        /// Map Student to model.
        /// </summary>
        /// <param name="entity">The Student instance.</param>
        /// <returns></returns>
        public static StudentModel ToModel(this Student entity)
        {
            return entity.MapTo<Student, StudentModel>();
        }



        /// <summary>
        /// Map Student model to Entity
        /// </summary>
        /// <param name="model">The  Student model.</param>
        /// <returns></returns>
        public static Student ToEntity(this StudentModel model)
        {
            return model.MapTo<StudentModel, Student>();
        }
       

        /// <summary>
        /// Generic method for mapping source to destination 
        /// with created instance of destination class
        /// </summary>
        /// <typeparam name="TSource">The source class</typeparam>
        /// <typeparam name="TDestination">The destination class</typeparam>
        /// <param name="source">The source instance</param>
        /// <param name="destination">The created destination instance.</param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        /// <summary>
        /// Generic method for mapping source to destination.
        /// </summary>
        /// <typeparam name="TSource">The source class</typeparam>
        /// <typeparam name="TDestination">Th destination class.</typeparam>
        /// <param name="source">The source instance.</param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }
    }
}