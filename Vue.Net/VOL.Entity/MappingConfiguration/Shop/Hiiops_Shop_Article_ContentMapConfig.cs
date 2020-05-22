using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Article_ContentMapConfig : EntityMappingConfiguration<Hiiops_Shop_Article_Content>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Article_Content>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

