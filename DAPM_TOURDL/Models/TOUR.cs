//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAPM_TOURDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOUR()
        {
            this.SPTOURs = new HashSet<SPTOUR>();
        }
    
        public string ID_TOUR { get; set; }
        public string TenTour { get; set; }
        public int GiaTour { get; set; }
        public string MoTa { get; set; }
        public string HinhTour { get; set; }
        public string TinhThanh { get; set; }
        public string LoaiTour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPTOUR> SPTOURs { get; set; }

/*        public static implicit operator TOUR(TOUR v) => throw new NotImplementedException();
*/    }
}
