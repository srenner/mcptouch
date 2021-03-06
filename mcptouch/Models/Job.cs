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
    
    public partial class Job
    {
        public Job()
        {
            this.IssueItems = new HashSet<IssueItem>();
            this.Maintenances = new HashSet<Maintenance>();
            this.ShoppingLists = new HashSet<ShoppingList>();
        }
    
        public int JobID { get; set; }
        public Nullable<int> CarID { get; set; }
        public string JobDescr { get; set; }
        public Nullable<int> MileageInterval { get; set; }
        public Nullable<int> DateInterval { get; set; }
    
        public virtual ICollection<IssueItem> IssueItems { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }
    }
}
