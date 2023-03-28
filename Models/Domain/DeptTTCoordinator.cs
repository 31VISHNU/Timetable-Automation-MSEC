using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TTGenerator.Models.Domain
{
    public class DeptTTCoordinator
    {
        [Key]
        public string Staff_id { get; set; }
        public string Course_id { get; set; }
        public string Staff_Name { get; set; }
        public int Total_classes { get; set; }
    }
}


