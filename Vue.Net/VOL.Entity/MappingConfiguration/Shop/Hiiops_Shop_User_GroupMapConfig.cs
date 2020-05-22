using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_User_GroupMapConfig : EntityMappingConfiguration<Hiiops_Shop_User_Group>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_User_Group>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

