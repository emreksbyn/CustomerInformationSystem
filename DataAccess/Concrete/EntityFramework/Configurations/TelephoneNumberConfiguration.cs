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
            base.Configure(builder);
        }
    }
}