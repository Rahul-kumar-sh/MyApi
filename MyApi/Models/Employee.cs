using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ?Name { get; set; }

        [Required]
        [EmailAddress]
        [Column(TypeName = "varchar(50)")]
        public string? Email { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string? PhoneNo { get; set; }

        [Required]
        public DateTime? HireDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
