using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class CountryMedalStanding
    {
        public int Id { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int OlympicGameId { get; set; }
        public OlympicGame OlympicGame { get; set; }
        public CountryMedalStanding() 
        { 

        }

        public CountryMedalStanding(int id, int gold, int silver, int bronze, int countryId, int olympicGameId)
        {
            Id = id;
            Gold = gold;
            Silver = silver;
            Bronze = bronze;
            CountryId = countryId;
            OlympicGameId = olympicGameId;
        }

        public override string ToString()
        {
            return $"{Country} - {Gold}-{Silver}-{Bronze}";
        }
    }
}
