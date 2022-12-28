using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class BaseConfigure<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder) { }
    }
}