using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class Medal
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }
        public int AthleteId { get; set; }
        public Athlete Athlete { get; set; }
        public int OlympicGameId { get; set; }
        public OlympicGame OlympicGame { get; set; }
        public Medal() 
        { 

        }

        public Medal(int id, int type, int sportId, int athleteId, int olympicGameId)
        {
            Id = id;
            Type = type;
            SportId = sportId;
            AthleteId = athleteId;
            OlympicGameId = olympicGameId;
        }

        public override string ToString()
        {
            return $"{Athlete.FullName} - {Sport} - {Type}";
        }
    }
}
