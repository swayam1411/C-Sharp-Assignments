using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmManagement.Models
{
    [Table("tblCustomer")]
    public class Customers
    {
        [Key]
        public long AccountNo { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<decimal> Balance { get; set; }
    }
}