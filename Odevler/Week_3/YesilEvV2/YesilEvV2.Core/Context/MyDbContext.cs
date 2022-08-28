using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvV2.Core.Entities;

namespace YesilEvV2.Core.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("name=CanConn")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<AramaGecmisi> aramaGecmisi { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Urun> urun { get; set; }
        public DbSet<Duzenleme> duzenleme { get; set; }
        public DbSet<Favoriler> favoriler { get; set; }
        public DbSet<FavoriListe> favoriListe { get; set; }
        public DbSet<KaraListe> karaListe { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<RolYetki> rolYetki { get; set; }
        public DbSet<Uretici> uretici { get; set; }
        public DbSet<Uye> uye { get; set; }
        public DbSet<Bildirim> bildirim { get; set; }
        public DbSet<UrunIcerik> UrunIcerik { get; set; }
        public DbSet<AlerjikMadde> AlerjikMadde { get; set; }
        public DbSet<Hasta> Hasta { get; set; }
        public DbSet<Puan> Puan { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<YorumOnay> YorumOnay { get; set; }
        public DbSet<YorumPuan> YorumPuan { get; set; }


    }
}
