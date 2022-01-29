using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime.Entities
{
    public class Bind
    {
        public object obj;
        public string propertyName;
        public object dataSource;
        public string dataMemberName;

        public Bind(object obj, string propertyName, object dataSource, string dataMemberName)
        {
            this.obj = obj;
            this.propertyName = propertyName;
            this.dataSource = dataSource;
            this.dataMemberName = dataMemberName;
        }
    }
}
