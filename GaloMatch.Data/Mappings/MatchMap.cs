using GaloMatch.Domain.Aggregates.Matches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GaloMatch.Data.Mappings
{
    public class MatchMap :IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.ToTable("Matches");
            builder.HasKey(x => x.Id);
        }
    }
}
