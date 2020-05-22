using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Store_SeckillMapConfig : EntityMappingConfiguration<Hiiops_Shop_Store_Seckill>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Store_Seckill>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

