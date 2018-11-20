using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class RoleMenu
    {
        public virtual Role Role { get; set; }
        public virtual Menu Menu { get; set; }

        #region Relations
        public virtual IList<Permision> Permisions { get; set; }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                RoleMenu RoleMenu = obj as RoleMenu;
                if (RoleMenu.Role == Role && RoleMenu.Menu == Menu)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (Role._ID + "|" + Menu._ID).GetHashCode();
            return i;
        }
    }
}
