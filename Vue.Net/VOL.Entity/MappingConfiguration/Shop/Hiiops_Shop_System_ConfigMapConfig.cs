using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Hiiops_Shop_System_ConfigMapConfig : EntityMappingConfiguration<Hiiops_Shop_System_Config>
    {
        public override void Map(EntityTypeBuilder<Hiiops_Shop_System_Config>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

