using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Cart_Seller_CollectionMapConfig : EntityMappingConfiguration<Hiiops_Cart_Seller_Collection>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Cart_Seller_Collection>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

