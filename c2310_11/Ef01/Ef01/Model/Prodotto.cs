using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Model
{
    [Table("AnagraficaArticoli")]
    public class Prodotto
    {
        public int ProdottoID { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [Column(TypeName = "decimal (9,2)")]
        public decimal PrezzoUnitario {  get; set; }
    }

}
