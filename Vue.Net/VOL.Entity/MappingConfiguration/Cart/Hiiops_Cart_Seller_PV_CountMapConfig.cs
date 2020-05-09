using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Cart_Seller_PV_CountMapConfig : EntityMappingConfiguration<Hiiops_Cart_Seller_PV_Count>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Cart_Seller_PV_Count>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

