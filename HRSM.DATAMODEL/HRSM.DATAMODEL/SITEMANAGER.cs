//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRSM.DATAMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SITEMANAGER
    {
        public System.Guid RID { get; set; }
        public string NAME { get; set; }
    
        public virtual GUARDSITE GUARDSITE { get; set; }
        public virtual CONTACTINFO CONTACTINFO { get; set; }
    }
}
