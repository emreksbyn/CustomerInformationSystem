using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class CustomerConfiguration : BaseConfigure<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Surname).IsRequired(true);
            builder.Property(x => x.TcNo).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(false);
            base.Configure(builder);
        }
    }
}
