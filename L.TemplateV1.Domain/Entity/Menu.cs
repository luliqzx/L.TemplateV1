using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class Menu : BaseTEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual string Url { get; set; }
        public virtual string Controller { get; set; }
        public virtual string Action { get; set; }
        public virtual Menu ParentMenu { get; set; }
        public virtual int Position { get; set; }
        public virtual bool Active { get; set; }

        #region Relations
        public virtual IList<RoleMenu> RoleMenus { get; set; }
        #endregion
    }
}
