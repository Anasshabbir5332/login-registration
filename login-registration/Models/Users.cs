using Microsoft.AspNetCore.Identity;


namespace login_registration.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
