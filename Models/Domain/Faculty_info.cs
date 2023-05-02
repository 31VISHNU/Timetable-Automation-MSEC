using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models.Domain
{
    public class Faculty_info
    {
        [Key]
        public string faculty_id { get; set; }
        public string faculty_name { get; set; }
        public int faculty_phno { get; set; }
        public string faculty_email { get; set; }
        public string faculty_dept { get; set; }
    }
}
