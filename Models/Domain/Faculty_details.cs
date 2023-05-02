using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models.Domain
{
    public class Faculty_details
    {
        [Key]
        public int Sno { get; set; }    
        public string Staff_id { get; set; }
        public string Course_id { get; set; }
        public string Staff_Name { get; set; }
        public int Total_classes { get; set; }
        public string section {get; set; }
        public int Class_year { get; set; }
    }
}
