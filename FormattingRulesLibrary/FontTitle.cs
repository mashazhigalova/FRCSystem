using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class FontTitle
    {
        public virtual int font_title_id    // возвращает id названия шрифта
        {
            get;
            set;
        }

        public virtual string font_title   // возвращает название шрифта
        {
            get;
            set;
        }
    }
}
