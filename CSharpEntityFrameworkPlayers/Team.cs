using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    [Table("team")]
    public class Team
    {
        [Key]
        public string TeamID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Allenatore { get; set; }

        [Required]
        public string Cita { get; set; }

        [Required]
        public string Colore { get; set; }


        public List<Player> Tesserati { get; set; }
    }
}
