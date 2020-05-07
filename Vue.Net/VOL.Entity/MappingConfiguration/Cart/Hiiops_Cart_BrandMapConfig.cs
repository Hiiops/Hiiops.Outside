using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Cart_BrandMapConfig : EntityMappingConfiguration<Hiiops_Cart_Brand>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Cart_Brand>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

