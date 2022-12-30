using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class TelephoneNumberConfiguration : BaseConfigure<TelephoneNumber>
    {
        public override void Configure(EntityTypeBuilder<TelephoneNumber> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.TelephoneNo).IsRequired(true);
            builder.Property(x => x.CustomerId).IsRequired(true);

            builder.HasData(new TelephoneNumber(1, "Kişisel", "1234567", 1),
                            new TelephoneNumber(2, "İş", "7654321", 1));

            base.Configure(builder);
        }
    }
}