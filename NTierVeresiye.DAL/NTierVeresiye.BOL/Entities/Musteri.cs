using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Musteri")]
    public class Musteri
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Soyad { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Unvan { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Telefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Faks { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Mail { get; set; }
        [Column(TypeName = "char"), StringLength(11)]
        public string TC { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string Adres { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]
        public string Aciklama { get; set; }
        



    }
}
