using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_ArticleMapConfig : EntityMappingConfiguration<Hiiops_Shop_Article>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Article>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

