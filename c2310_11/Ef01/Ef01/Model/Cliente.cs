using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Model
{
    public  class Cliente
    {
        public int ClienteID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nome{ get; set; }
        [Required]
        [MaxLength(50)]
        public string Cognome{ get; set; }
        [MaxLength(50)]
        public string? Indirizzo { get; set; }
        [MaxLength(5)]
        public string? Cap { get; set; }
        [MaxLength(50)]
        public string? Localita{ get; set; }
        [MaxLength(2)]
        public string? Prov{ get; set; }
        [MaxLength(16)]
        public string CodiceFiscale{ get; set; }
        [MaxLength(11)]
        public string PartitaIva{ get; set; }
        [MaxLength(150)]
        public string? EMail {  get; set; }
        //------------------------------
        [NotMapped]
        public string NomeCompleto
        {
            get
            {
                return Cognome + " " + Nome;
            }
        }
        [Column(TypeName ="decimal (13,2)")]
        public decimal Fatturato {  get; set; }
        
    }
}
