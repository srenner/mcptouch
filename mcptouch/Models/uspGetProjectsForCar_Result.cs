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
    
    public partial class uspGetProjectsForCar_Result
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescr { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public Nullable<decimal> RunningCost { get; set; }
        public bool Completed { get; set; }
        public string CompletionDate { get; set; }
    }
}
