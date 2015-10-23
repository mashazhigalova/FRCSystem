using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    class PaperFormat
    {
        public virtual int paper_format_id    // возвращает id формата бумаги
        {
            get;
            set;
        }

        public virtual string paper_format   // возвращает формат бумаги
        {
            get;
            set;
        }

        public virtual double width    // возвращает ширину
        {
            get;
            set;
        }

        public virtual double heigth    // возвращает высоту
        {
            get;
            set;
        }
    }
}
