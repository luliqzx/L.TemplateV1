using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
  public  class BaseTEntity<TID>:BaseT<TID>
    {
        public virtual string CreateBy { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateTerminal { get; set; }
        public virtual string UpdateBy { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual string UpdateTerminal { get; set; }
        public virtual byte[] _Version { get; set; }
    }
}
