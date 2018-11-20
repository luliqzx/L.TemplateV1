using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class _User : BaseTEntity<string>
    {
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual bool Active { get; set; }

        public virtual string Fullname
        {
            get
            {
                string fullName = Firstname;
                fullName = string.IsNullOrWhiteSpace(Middlename) ? fullName : fullName + " " + Middlename;
                fullName = string.IsNullOrWhiteSpace(Lastname) ? fullName : fullName + " " + Lastname;
                return fullName;
            }
        }

        #region Relations
        public virtual IList<Role> Roles { get; set; }
        #endregion
    }
}
