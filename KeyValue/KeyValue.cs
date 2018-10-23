using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{
    struct KeyValue
    {
        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public readonly string key;
        public readonly object value;
    }    
}
