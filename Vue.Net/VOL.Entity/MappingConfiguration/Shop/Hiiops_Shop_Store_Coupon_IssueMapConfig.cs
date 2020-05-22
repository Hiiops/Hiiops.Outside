using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_Coupon_IssueMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Coupon_Issue>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Coupon_Issue>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

