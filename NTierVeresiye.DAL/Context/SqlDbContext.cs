using NTierVeresiye.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.DAL.Context
{
    public class SqlDbContext:DbContext
    {    
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
    }
}
