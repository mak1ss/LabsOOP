using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class Bet
    {
        [Column("BetId")]
        public int Id { get; set; }

        public float Amount { get; set; }
        public Prediction Prediciton { get; set; }
        public DateTime DateTime { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
