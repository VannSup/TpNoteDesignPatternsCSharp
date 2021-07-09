using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using TpNoteDesignPatternsCSharp.DAL.Contexts;
using TpNoteDesignPatternsCSharp.DAL.Repositories;

namespace TpNoteDesignPatternsCSharp.DAL.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEquipementsRepository, EquipementsRepository>();
            services.AddTransient<IPersonnageRepository, PersonnageRepository>();

        }

        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration, string ConnectionStringName = "DefaultConnection")
        {
            try
            {
                if (configuration.GetSection("ConnectionStrings")["UseMySQL"] == null
                        || !Convert.ToBoolean(configuration.GetSection("ConnectionStrings")["UseMySQL"]))
                {
                    services.AddDbContext<IBaseDbContext, BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(ConnectionStringName)));
                }
                else
                {
                    services.AddDbContext<IBaseDbContext, BaseDbContext>(options => options.UseMySql(configuration.GetConnectionString(ConnectionStringName)
                        , mySqlOptions => mySqlOptions
                                .ServerVersion(new Version(8, 0, 20), ServerType.MySql)
                     ));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
