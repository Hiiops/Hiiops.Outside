using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_Wechat_KeyMapConfig : EntityMappingConfiguration<Hiiops_Shop_Wechat_Key>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_Wechat_Key>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

