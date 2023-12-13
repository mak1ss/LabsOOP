using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public bool IsInjured { get; set; }

        public ICollection<PlayerStatistics> PlayerStatistics { get; set; }
    }
}
