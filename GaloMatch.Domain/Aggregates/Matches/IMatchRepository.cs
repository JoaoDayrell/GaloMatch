using GaloMatch.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Domain.Aggregates.Matches
{
    public interface IMatchRepository :IRepositoryBase<Match>
    {
    }
}
