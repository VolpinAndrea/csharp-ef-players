using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    [Table("player")]
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }

        [Required]
        [Column("nome")]
        public string Name { get; set; }

        [Required]
        [Column("cognome")]
        public string Surname { get; set; }

        public int Punteggio { get; set; }

        [Column("partite_vinte")]
        public int Vinte { get; set; } 

        [Column("partite_giocate")]
        public int Giocate { get; set; }

        public string TeamID { get; set; }
        public Team Team { get; set; }



        public override string ToString()
        {
            return "Nome: " + Name + "\nCognome: " + Surname + "\nPunteggio: " + Punteggio + "\nVittorie" + Vinte + "/" + Giocate;
        }

        /*public void SetNome(string nome)
        {
            Player.Name.crud(nome);
        }
        public void SetCognome(string nome)
        {
            Cognome.set(nome);
        } */

    }

    
}
