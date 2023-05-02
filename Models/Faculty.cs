using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models
{
    public class Faculty
    {
        [Key]
        public string Faculty_id { get; set; }
        public string Faculty_name { get; set; }
    }
}
