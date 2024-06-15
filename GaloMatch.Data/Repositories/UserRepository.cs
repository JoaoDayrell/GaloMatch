using GaloMatch.Domain.Aggregates.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Data.Repositories
{
    public class UserRepository :RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataBaseContext context) : base(context) { }
    }
}
