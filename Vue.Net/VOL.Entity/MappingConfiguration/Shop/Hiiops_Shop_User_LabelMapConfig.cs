using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_User_LabelMapConfig : EntityMappingConfiguration<Hiiops_Shop_User_Label>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_User_Label>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

