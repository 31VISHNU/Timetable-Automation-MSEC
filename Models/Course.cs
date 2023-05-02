using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models
{
    public class Course
    {
        [Key]
        public string Course_Id { get; set; }
        public string Course_name { get; set; }
    }
}
