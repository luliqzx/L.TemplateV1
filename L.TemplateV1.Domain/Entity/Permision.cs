using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class Permision : BaseT<string>
    {
        public virtual string Description { get; set; }

        public virtual IList<RoleMenu> RoleMenus { get; set; }
    }
}
