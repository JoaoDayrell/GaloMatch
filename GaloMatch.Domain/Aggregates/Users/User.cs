using GaloMatch.Domain.Aggregates.Users.Enuns;
using GaloMatch.Domain.Aggregates.Users;

namespace GaloMatch.Domain.Aggregates.Users
{
    public class User : Entity, IAggregateRoot
    {
        public string Name { get; init; }
        public string PhoneNumber { get; init; }
        public DateTime BirthDate { get; init; }
        public bool IsClubMember { get; init; }
        public string Email { get; init; }
        public Sections FavoriteSection { get; init; }
        public Sex Sex { get; init; }

        public ICollection<PretendedEvent> Events { get; init; }

        public User(string name, string phoneNumber, DateTime birthDate, bool isClubMember, string email, Sections favoriteSection)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            IsClubMember = isClubMember;
            Email = email;
            FavoriteSection = favoriteSection;
            Sex = Sex;
            Events = new List<PretendedEvent>();
        }
    }
}
