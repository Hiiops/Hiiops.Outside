using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_Product_AttrMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Product_Attr>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Product_Attr>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

