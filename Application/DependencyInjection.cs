﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Application.Common.Interfaces;
using AutoMapper.Configuration;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddFluentValidation(Assembly.GetExecutingAssembly());


            return services;
        }

        public static IServiceCollection AddFluentValidation(this IServiceCollection services, Assembly assembly)
        {
            var validatorType = typeof(IValidator<>);

            var validatorTypes = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == validatorType)).ToList();

            foreach (var validator in validatorTypes)
            {
                var requestType = validator.GetInterfaces().Where(i => i.IsGenericType &&
                                                                       i.GetGenericTypeDefinition() == typeof(IValidator<>)).Select(i => i.GetGenericArguments()[0]).First();

                var validatorInterface = validatorType.MakeGenericType(requestType);

                services.AddTransient(validatorInterface, validator);
            }

            return services;
        }

       
    }
}
