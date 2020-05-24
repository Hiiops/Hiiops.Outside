using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_CacheMapConfig : EntityMappingConfiguration<Hiiops_Shop_Cache>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Cache>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

