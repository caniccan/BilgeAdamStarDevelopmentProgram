using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Entities
{
    [Table("Uye")]
    public class Uye : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public Rol RolID { get; set; }
        public string AdSoyad { get; set; }
        public string TelNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }
        public List<Bildirim> bildirimler { get; set; }
        public List<Yorum> Yorum { get; set; }


    }
}
