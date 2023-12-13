using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class Game
    {
        [Column("GameId")]
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public float HomeTeamBetRate { get; set; }
        public float AwayTeamBetRate { get; set; }
        public float DrawBetRate { get; set; }
        public Prediction Result { get; set; }

        public ICollection<PlayerStatistics> PlayerStatistics { get; set; }

        public ICollection<Bet> Bets { get; set; }
    }
}
