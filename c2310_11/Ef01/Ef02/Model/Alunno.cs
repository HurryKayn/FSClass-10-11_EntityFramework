using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef02.Model
{
    internal class Alunno
    {
        public int AlunnoId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }
        
        [Required]
        [MaxLength(75)]
        public string Cognome{ get; set; }
        
        public int Eta{ get; set; }
        
        [MaxLength(150)]
        public string? Email{ get; set; }
        
        [MaxLength (500)]
        public string? Notazioni{ get; set; }
        
        [Column(TypeName = "decimal  (4,2)")]
        public decimal  Altezza { get; set; }

        [NotMapped]
        [MaxLength (125)]
        public string NomeCompleto { get { return Cognome + " " + Nome; } }


    }
}
