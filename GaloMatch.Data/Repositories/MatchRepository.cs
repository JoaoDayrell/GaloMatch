using GaloMatch.Domain.Aggregates.Matches;

namespace GaloMatch.Data.Repositories
{
    public class MatchRepository: RepositoryBase<Match>, IMatchRepository
    {
        public MatchRepository(DataBaseContext context) : base(context) { }
    }
}
