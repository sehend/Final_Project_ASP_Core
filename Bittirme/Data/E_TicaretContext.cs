using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class E_TicaretContext : DbContext
    {
        public E_TicaretContext()
        {
        }

        public E_TicaretContext(DbContextOptions<E_TicaretContext> options)
            : base(options)
        {
        }

  
      
        public virtual DbSet<TblMudur> TblMudurs { get; set; }
        public virtual DbSet<TblMusteri> TblMusteris { get; set; }
        public virtual DbSet<TblPersonel> TblPersonels { get; set; }
        public virtual DbSet<TblSati> TblSatis { get; set; }
        public virtual DbSet<Urunler> TblUrunlers { get; set; }
        public virtual DbSet<ram> ram { get; set; }
        public virtual DbSet<ssd> ssd { get; set; }
        public virtual DbSet<mouse> mouse { get; set; }
        public virtual DbSet<Ekrankarti> Ekrankarti { get; set; }

    }
}
