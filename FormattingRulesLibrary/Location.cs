using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Location
    {
        public virtual int location_id    // возвращает id положенрия на странице
        {
            get;
            set;
        }

        public virtual string location   // возвращает положеие на странице
        {
            get;
            set;
        }
    }
}
