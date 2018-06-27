using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ColeKine.Modelos
{
    public partial class UserDetails
    {

        public UserDetails()
        {
        }


        [Key]
        public int Id_UserDetails { get; set; }


        public string UserName { get; set; }

        public DateTime? LastModified { get; set; }
        
        public bool? Inactive { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        public bool isSysAdmin { get; set; }


        public virtual IdentityUser IdentityUsers { get; set; }


    }
}