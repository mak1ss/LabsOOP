using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class User
    {
        [Column("UserId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }

        public ICollection<Bet> Bets {  get; set; }
    }
}
