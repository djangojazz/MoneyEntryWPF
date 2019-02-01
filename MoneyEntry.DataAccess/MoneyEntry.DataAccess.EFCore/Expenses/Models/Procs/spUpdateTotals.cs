using System.ComponentModel.DataAnnotations;

namespace MoneyEntry.DataAccess.EFCore.Expenses.Models
{
    public sealed class spUpdateTotals
    {
        [Key]
        public int RowsUpdated { get; set; }
    }
}
