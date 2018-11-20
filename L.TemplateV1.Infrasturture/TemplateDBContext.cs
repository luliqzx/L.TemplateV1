using L.TemplateV1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Infrasturture
{
    public class TemplateDBContext : DbContext
    {
        public DbSet<_User> _Users { get; set; }
        //public DbSet<Role> Roles { get; set; }

    }
}
