using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Urun")]
    public class Urun
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Barkod { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Ad { get; set; }
        public int Miktar { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        [Column(TypeName = "varchar"), StringLength(10)]
        public string AlisTarih { get; set; }
        [Column(TypeName = "varchar"), StringLength(10)]
        public string STTarih { get; set; }
        public EBirim Birim { get; set; }
        public ICollection<Tedarikci> Tedarikciler { get; set; }



    }
    public enum EBirim
    {
        Adet=1,
        Kutu,
        Gram,
        Kilo,
        Ton,
        Metre,
        MetreKare
    }

}
