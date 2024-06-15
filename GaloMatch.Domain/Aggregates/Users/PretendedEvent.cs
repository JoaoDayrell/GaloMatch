
using GaloMatch.Domain.Aggregates.Users.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Domain.Aggregates.Users
{
    public class PretendedEvent : Entity
    {
        protected PretendedEvent() { }
        public User User { get; init; }
        public Guid MatchId { get; init; }
        public Sections WantedSection { get; init; }

        public Guid UserId { get; init; }
        public bool HasTicket { get; init; }

        public PretendedEvent(User user, Guid matchId, Sections wantedSection, bool hasTicket)
        {
            User = user;
            MatchId = matchId;
            WantedSection = wantedSection;
            HasTicket = hasTicket;
            UserId = user.Id;
        }
    }
}
