//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YesilEv.UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favoriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Favoriler()
        {
            this.FavoriListes = new HashSet<FavoriListe>();
        }
    
        public int ID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public string FavorilerAdi { get; set; }
    
        public virtual Urun Urun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriListe> FavoriListes { get; set; }
    }
}
