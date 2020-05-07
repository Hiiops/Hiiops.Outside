using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Cart_CategoryMapConfig : EntityMappingConfiguration<Hiiops_Cart_Category>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Cart_Category>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

