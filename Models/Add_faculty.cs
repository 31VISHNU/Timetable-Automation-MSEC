using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TTGenerator.Models
{
    public class Add_faculty
    {
        [Key]
        public string Course_Id { get; set; }
        public string Year { get; set; }
        public int Batch { get; set; }
        public string section { get; set; }
        public int Semester { get; set; }
    }
}
