using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models.Domain
{
    public class Course_info
    {
        [Key]
        public string course_id { get; set; }
        public string course_name { get; set; }
        public string department { get; set; }
    }
}
