﻿using Framework.Core.Contracts.Data.Commands;
using Framework.Core.Contracts.Data.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Framework.Endpoints.Extentions.DependencyInjection;

public static class AddDataAccessExtentsions
{
    public static IServiceCollection AddDataAccess(
        this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddRepositories(assembliesForSearch).AddUnitOfWorks(assembliesForSearch);

    public static IServiceCollection AddRepositories(this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddWithTransientLifetime(assembliesForSearch, typeof(ICommandRepository<,>), typeof(IQueryRepository));

    public static IServiceCollection AddUnitOfWorks(this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddWithTransientLifetime(assembliesForSearch, typeof(IUnitOfWork));
}

