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
    
    public partial class uspGetJobsForCarDetails2_Result
    {
        public int JobID { get; set; }
        public Nullable<int> CarID { get; set; }
        public string JobDescr { get; set; }
        public Nullable<int> MileageInterval { get; set; }
        public Nullable<int> DateInterval { get; set; }
        public int TimesPerformed { get; set; }
        public Nullable<System.DateTime> LastPerformedDate { get; set; }
        public Nullable<int> LastPerformedMileage { get; set; }
        public string DateIntervalText { get; set; }
        public int ShoppingListCount { get; set; }
    }
}
