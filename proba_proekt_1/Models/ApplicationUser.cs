﻿using Microsoft.AspNetCore.Identity;

namespace proba_proekt_1.Models
{
    public class ApplicationUser : IdentityUser
    {
 
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }

}
