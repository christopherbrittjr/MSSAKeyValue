using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{
    class MyDictionary
    {
        KeyValue[] kvs = new KeyValue[16];

        int inserted = 0;

        public object this[string key]
        {
            //Look through the array, find the key
            //If no key found, throw exception
            get
            {
                for (int i = 0; i < inserted; ++i)
                {
                    if (kvs[i].key == key)
                        return kvs[i].value;
                }

                throw new KeyNotFoundException("Can't find key: " + key);
            }

            //Check for existing key and replace if found
            //Otherwise, add a key to the end
            set
            {
                for (int i = 0; i < inserted; ++i)
                {
                    if (kvs[i].key == key)
                    {
                        kvs[i] = new KeyValue(key, value);
                        return;
                    }
                }

                //Didn't find the requested key
                kvs[inserted++] = new KeyValue(key, value);
            }
        }
    }
}
