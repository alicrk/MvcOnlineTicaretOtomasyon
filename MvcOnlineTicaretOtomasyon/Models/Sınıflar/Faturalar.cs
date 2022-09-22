using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicaretOtomasyon.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaId { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSerino { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(6)]
        public string FaturaSırano { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(60)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]

        public string TeslimEden { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public String Saat { get; set; }

        public decimal Toplam { get; set; }

        public ICollection<FaturaKalem> faturaKalems { get; set; }
    }
}