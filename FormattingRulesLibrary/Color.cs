using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Color
    {
        public virtual int color_id    // возвращает id цвета
        {
            get;
            set;
        }

        public virtual string color   // возвращает название цвета
        {
            get;
            set;
        }
    }
}
