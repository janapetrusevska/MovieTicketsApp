using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Web.Models.Identity
{
    public class ImportUserDto : UserRegistrationDto
    {
        public Role SelectedRole { get; set; }
    }
}
