//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mcptouch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guestbook
    {
        public int GuestbookID { get; set; }
        public Nullable<int> CarID { get; set; }
        public Nullable<int> FromUserID { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
    }
}
