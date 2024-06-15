using GaloMatch.Domain.Aggregates.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Data.Mappings
{
    public class PretendedEventMap :IEntityTypeConfiguration<PretendedEvent>
    {
        public void Configure(EntityTypeBuilder<PretendedEvent> builder)
        {
            builder.ToTable("PretendedEvents");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne().HasForeignKey<PretendedEvent>(x => x.UserId);
        }



    }
}
