//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eDiskont_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthTokens
    {
        public int AuthTokenID { get; set; }
        public string Token { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
