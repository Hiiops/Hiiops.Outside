using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_Coupon_Issue_UserMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Coupon_Issue_User>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Coupon_Issue_User>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

