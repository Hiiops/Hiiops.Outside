using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_PinkMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Pink>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Pink>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

