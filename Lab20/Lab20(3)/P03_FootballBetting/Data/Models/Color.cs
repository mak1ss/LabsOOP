using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Team> PrimaryColorKitTeams { get; set; }
        public ICollection<Team> SecondaryColorKitTeams { get; set; }

    }
}
