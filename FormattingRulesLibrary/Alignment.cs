using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    class Alignment
    {
        public virtual int align_id    // возвращает id выранивания
        {
            get;
            set;
        }

        public virtual string align   // возвращает выравнивание
        {
            get;
            set;
        }
    }
}
