using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Tedarikci")]
    public class Tedarikci
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Sektor { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string YetkiliAd { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string YetkiliSoyad { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Telefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Faks { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Mail { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string VergiNo { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Adres { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string Aciklama { get; set; }
        public ICollection<Urun> Urunler { get; set; }
    }
}
