using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
        public ICollection<Medal> Medals { get; set; }
        public Sport() 
        { 

        }

        public Sport(int id, string name)
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
