using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_Product_ReplyMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Product_Reply>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Product_Reply>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

