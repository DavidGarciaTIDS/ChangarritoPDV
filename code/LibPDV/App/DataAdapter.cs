using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBD;

namespace LibPDV.App
{
    public class DataAdapter : DataCollection
    {
        public DataAdapter(string name, Types fieldtype, object value) : base(name, fieldtype, value)
        {
        }
    }


}
