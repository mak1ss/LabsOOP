using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3_.P03_FootballBetting.Data.Models
{
    public class Position
    {
        [Column("PositionId")]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Player> Players {  get; set; }
    }
}
