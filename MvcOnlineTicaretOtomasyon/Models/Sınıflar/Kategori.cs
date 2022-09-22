using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicaretOtomasyon.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int KategoryId { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string KategoryAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}