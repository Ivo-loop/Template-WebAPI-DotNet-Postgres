using Application.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddServices();
    }

    internal static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserAuthenticator, UserAuthenticator>();
        services.AddScoped<IUserInactivator, UserInactivator>();
        services.AddScoped<IUserList, UserList>();
        services.AddScoped<IUserRegister, UserRegister>();
        services.AddScoped<IUserPasswordUpdater, UserPasswordUpdater>();
    }
}