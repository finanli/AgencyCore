using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AgencyCore.Models
{
    public class Projeler
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(30)]
        public string CustomerName { get; set; }
        public string Description { get; set; }

    }
}
