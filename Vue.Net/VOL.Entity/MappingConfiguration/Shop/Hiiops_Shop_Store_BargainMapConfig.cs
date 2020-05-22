using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_BargainMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Bargain>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Bargain>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

