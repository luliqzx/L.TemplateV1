using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Entity
{
    public class BaseT<TID>
    {
        public virtual TID _ID { get; set; }
    }
}
