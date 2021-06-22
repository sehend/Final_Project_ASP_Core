using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Urunler
    {
        public Urunler()
        {
            TblMudurs = new HashSet<TblMudur>();
        }
        [Key]
        public int UrunId { get; set; }
        public int? ramıd { get; set; }
        public int? ssdıd { get; set; }
        public int? mouseId { get; set; }
        public int? ekrankartııd { get; set; }

        public virtual ram ram { get; set; }
        public virtual ssd ssd { get; set; }
        public virtual mouse mouse { get; set; }
        public virtual Ekrankarti Xiaomi { get; set; }
        public virtual ICollection<TblMudur> TblMudurs { get; set; }
    }
}
