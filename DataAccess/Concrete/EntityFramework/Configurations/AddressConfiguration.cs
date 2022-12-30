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


            builder.HasData(new Address(1, "Ev", "İstanbul", "Kadıköy", 1),
                            new Address(2, "İş", "İstanbul", "Ataşehir", 1));

            base.Configure(builder);
        }
    }
}