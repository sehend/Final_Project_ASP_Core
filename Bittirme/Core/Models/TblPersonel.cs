
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
    public class TblPersonel
    {
        [Key]
        public int Personelıd { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [DisplayName("image Name")]
        public string imageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile imageFile { get; set; }





        [Column(TypeName = "nvarchar(max)")]
        public string Ad { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Soyad { get; set; }
        public int Tc { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Adress { get; set; }
        public int Tel { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Email { get; set; }
        public decimal? PersonelMaas { get; set; }
        public int? Müdürıd { get; set; }
        public int? Kategoriıd { get; set; }

      
        public virtual TblMudur MüdürıdNavigation { get; set; }
    }
}
