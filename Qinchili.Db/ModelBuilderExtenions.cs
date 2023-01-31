using Microsoft.EntityFrameworkCore;
using Qinchili.Db.Configurations;
using System.Reflection;

namespace Qinchili.Db
{
    public static class ModelBuilderExtenions
    {
        public static void AddEntityConfigurations(this ModelBuilder builder, Assembly assembly, string context)
        {
            var mappingTypes = assembly.GetMappingTypes(typeof(IEntityMappingConfiguration<>), context);

            foreach (var config in mappingTypes.Select(Activator.CreateInstance).Cast<IEntityConfiguration>())
            {
                config.Map(builder);
            }
        }

        private static IEnumerable<Type> GetMappingTypes(this Assembly assembly, Type mappingInterface, string context)
        {
            return assembly.GetTypes().Where(type => !type.GetTypeInfo().IsAbstract && type.GetInterfaces().Any(i => i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == mappingInterface) && type.Namespace.Contains(context));
        }
    }
}
