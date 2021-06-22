using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TblMusteri
    {
        [Key]
        public int Müşıd { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Ad { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Soyad { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Adress { get; set; }
        public int Tc { get; set; }
        public int Tel { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Email { get; set; }
        public int? Urunıd { get; set; }

        public virtual TblMudur TblMudurNavigation { get; set; }

       
    }
}
