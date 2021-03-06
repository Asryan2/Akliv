//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vilka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.BetOffers = new HashSet<BetOffer>();
        }
    
        public int ID { get; set; }
        public int SportID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> PrematchEnd { get; set; }
        public int League { get; set; }
        public int SiteID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BetOffer> BetOffers { get; set; }
        public virtual Region Region { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Site Site { get; set; }
    }
}
