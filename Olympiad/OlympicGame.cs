using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class OlympicGame
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public bool IsWinter { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public ICollection<Sport> Sports { get; set; }
        public ICollection<CountryMedalStanding> MedalStandings { get; set; }
    }
    public OlympicGame()
    {

    }

    public OlympicGame(int id, int year, bool isWinter, string country, string city)
    {
        Id = id;
        Year = year;
        IsWinter = isWinter;
        Country = country;
        City = city;
    }
    public override string ToString()
    {
        return $"{Year} {Country}";
    }
}
