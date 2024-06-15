using GaloMatch.Domain.Aggregates.Matches;
using GaloMatch.Domain.Aggregates.Users;

namespace GaloMatch.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {

        IMatchRepository Matches { get; }
        IUserRepository Users { get; }

        Task<bool> CommitAsync();
    }
}
