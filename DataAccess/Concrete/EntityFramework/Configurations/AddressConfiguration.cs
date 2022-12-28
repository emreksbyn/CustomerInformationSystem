using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class AddressConfiguration : BaseConfigure<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.City).IsRequired(true);
            builder.Property(x => x.District).IsRequired(true);
            builder.Property(x => x.CustomerId).IsRequired(true);
            base.Configure(builder);
        }
    }
}