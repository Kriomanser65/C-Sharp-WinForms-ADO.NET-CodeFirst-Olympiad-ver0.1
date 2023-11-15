using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
        public ICollection<CountryMedalStanding> MedalStandings { get; set; }
        public Country()
        {

        }

        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
