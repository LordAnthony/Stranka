using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Role : IdentityRole
    {
        public virtual List<RoleNadleznost> UlogeNadleznosti { get; set; }
    }   
}
