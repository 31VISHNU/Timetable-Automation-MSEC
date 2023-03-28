using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TTGenerator.Models.Domain
{
    public partial class Login_credentials
    {
        [Key] 
        [StringLength(4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public string login_id { get; set; }
        public string password_l { get; set; }
    }
}
