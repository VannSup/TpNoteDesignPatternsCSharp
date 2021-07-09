using Microsoft.Extensions.DependencyInjection;

namespace TpNoteDesignPatternsCSharp.BLL.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddManagers(this IServiceCollection services)
        {
            services.AddTransient<IEquipementManager, EquipementManager>();
            services.AddTransient<IPersonnageManager, PersonnageManager>();
        }
    }

}
