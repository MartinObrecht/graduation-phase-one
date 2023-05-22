﻿using PoliceDepartment.EvidenceManager.Application.Authorization;
using PoliceDepartment.EvidenceManager.Application.Authorization.UseCases;
using PoliceDepartment.EvidenceManager.Domain.Authorization;
using PoliceDepartment.EvidenceManager.Domain.Authorization.UseCases;
using PoliceDepartment.EvidenceManager.SharedKernel.Responses;
using System.Diagnostics.CodeAnalysis;

namespace PoliceDepartment.EvidenceManager.API.DependencyInjection.BusinessRules
{
    [ExcludeFromCodeCoverage]
    internal static class ApplicationExtensions
    {
        internal static IServiceCollection AddApplicationConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ILogin<LoginViewModel, BaseResponseWithValue<AccessTokenModel>>, Login>();

            return services;
        }
    }
}
