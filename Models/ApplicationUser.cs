using Microsoft.AspNetCore.Identity;

namespace MonCourriel.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string LastName { get; set; }
        public string FisrtName { get; set; }
        public string UserName { get; set; }
        public string Tel { get; set; }
    }
}
