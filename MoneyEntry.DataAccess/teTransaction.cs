//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyEntry.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class teTransaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<byte> CategoryId { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public Nullable<System.DateTime> ModifiedDt { get; set; }
        public int PersonId { get; set; }
        public Nullable<bool> Reconciled { get; set; }
        public Nullable<decimal> RunningTotal { get; set; }
        public string TransactionDesc { get; set; }
        public Nullable<byte> TypeId { get; set; }
    
        public virtual tdCategory tdCategory { get; set; }
        public virtual tdType tdType { get; set; }
        public virtual tePerson tePerson { get; set; }
    }
}
