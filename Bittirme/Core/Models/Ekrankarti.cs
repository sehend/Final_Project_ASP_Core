using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Ekrankarti
    {
        public Ekrankarti()
        {
            Urunlers = new HashSet<Urunler>();
        }
        [Key]
        public int ekrankartıd { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        [DisplayName("image Name")]
        public string imageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile imageFile { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Aciklama { get; set; }
        public decimal? Fiyat { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
