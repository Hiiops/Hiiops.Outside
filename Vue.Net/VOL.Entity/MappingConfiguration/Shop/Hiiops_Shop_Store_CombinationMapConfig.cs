using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_CombinationMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Combination>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Combination>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

