using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace MasterTrainer.DataAccess.Extensions
{
    public static class PropertyConfigurationExtensions
    {
        public static PrimitivePropertyConfiguration IsUnique(this PrimitivePropertyConfiguration property, string constraintName = null)
        {
            if (!string.IsNullOrWhiteSpace(constraintName))
            {
                return property.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UC_" + constraintName) { IsUnique = true }));
            }
            return property.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
        }
    }
}
