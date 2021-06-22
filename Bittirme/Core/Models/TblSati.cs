using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TblSati
    {
        [Key]
        public int KardId { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Ad { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Soyad { get; set; }
        public int? KartNo { get; set; }
        public int? SonKulanma { get; set; }
        public int? Cvv { get; set; }
    }
}
