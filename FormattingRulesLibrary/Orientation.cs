using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    class Orientation
    {
        public virtual int orient_id    // возвращает id ориентации
        {
            get;
            set;
        }

        public virtual string orientation   // возвращает ориентацию
        {
            get;
            set;
        }
    }
}
