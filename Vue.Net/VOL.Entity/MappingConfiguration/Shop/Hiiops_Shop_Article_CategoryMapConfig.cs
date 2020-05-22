using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Article_CategoryMapConfig : EntityMappingConfiguration<Hiiops_Shop_Article_Category>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Article_Category>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

