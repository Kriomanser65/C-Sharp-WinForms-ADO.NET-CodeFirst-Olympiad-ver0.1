using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class Athlete
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }
        public ICollection<Medal> Medals { get; set; }
        public Athlete() 
        { 

        }

        public Athlete(int id, string fullName, DateTime birthDate, string photo, int countryId, int sportId)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            Photo = photo;
            CountryId = countryId;
            SportId = sportId;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
