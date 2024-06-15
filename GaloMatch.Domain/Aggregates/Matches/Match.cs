using GaloMatch.Domain.Aggregates.Matches.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Domain.Aggregates.Matches
{
    public class Match : Entity, IAggregateRoot
    {
        public DateTime Date { get; init; }
        public string Location { get; init; }
        public string Name { get; init; }   
        public string Description { get; init; }
        public string? TicketUrl { get; init; }  
        public string Opponent { get; init; }
        public  Tournaments Tournament { get; init; }

        public Match(DateTime date, string location, string name, string description,
            string? ticketUrl, string opponent, Tournaments tournament)
        {
            Date = date;
            Location = location;
            Name = name;
            Description = description;
            TicketUrl = ticketUrl;
            Opponent = opponent;
            Tournament = tournament;
        }
    }
}
