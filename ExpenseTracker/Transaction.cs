//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int transactionId { get; set; }
        public string transactionName { get; set; }
        public System.DateTime date { get; set; }
        public int value { get; set; }
        public string transactionType { get; set; }
        public string description { get; set; }
        public string isRecurring { get; set; }
        public int UsersId { get; set; }
        public int ContactId { get; set; }
    
        public virtual User User { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
