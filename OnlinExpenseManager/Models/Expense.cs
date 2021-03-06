//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlinExpenseManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public int ExpID { get; set; }
        public string ExpType { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<double> ExpAmount { get; set; }
        public string AccountType { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
    }
}
