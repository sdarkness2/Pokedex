using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Pokedex.Models
{
    public class Pokemon
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string Nome { get; set; }
        [StringLength(400)]
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        [ForeignKey("ID")]
        public int? PreEvolucao { get; set; }
        [ForeignKey("ID")]
        public int? Evolucao { get; set; }
    }
}
