using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class Role : BaseTEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual bool Active { get; set; }

        #region Relations
        public virtual IList<_User> Users { get; set; }
        public virtual IList<RoleMenu> RoleMenus { get; set; }
        #endregion
    }
}
