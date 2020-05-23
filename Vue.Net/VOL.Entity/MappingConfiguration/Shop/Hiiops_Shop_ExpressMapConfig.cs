using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_ExpressMapConfig : EntityMappingConfiguration<Hiiops_Shop_Express>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Express>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

