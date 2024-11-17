using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence.Utils
{
    public class TableUltils{
        public string? GetTableName<TEntity>(DbContext context) where TEntity : class
        {
            // Usa a API de metadados do Entity Framework Core para encontrar o nome da tabela
            var entityType = context.Model.FindEntityType(typeof(TEntity));
            if (entityType == null)
            {
                throw new InvalidOperationException($"Cannot find table name for entity type {typeof(TEntity).FullName}");
            }
            var schema = entityType.GetSchema();
            var tableName = entityType.GetTableName();
            return string.IsNullOrEmpty(schema) ? tableName : $"{schema}.{tableName}";
        }

        public string GetColumnName<T>(DbContext context, string propertyName)
        {
            var entityType = context.Model.FindEntityType(typeof(T));
            if (entityType == null)
            {
                throw new ArgumentException($"A entidade {typeof(T).Name} não foi encontrada.");
            }

            var property = entityType.FindProperty(propertyName);
            if (property == null)
            {
                throw new ArgumentException($"A propriedade {propertyName} não foi encontrada na entidade {typeof(T).Name}.");
            }

            return property.GetColumnName(StoreObjectIdentifier.Table(entityType.GetTableName(), entityType.GetSchema()));
        }
    }
}
