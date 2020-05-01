using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_CartMapConfig : EntityMappingConfiguration<Hiiops_Cart>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Cart>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

