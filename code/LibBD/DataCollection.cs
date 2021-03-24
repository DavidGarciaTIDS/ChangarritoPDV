using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBD
{
    public class DataCollection
    {
        public string Name { get; set; }
        public Types FieldType { get; set; }
        public object Value 
        { 
            get 
            {
                if (this.HasQuotes())
                {
                    return $"'{this.Value}'";
                }
                else
                {
                    return this.Value;
                }
            }

            set => Value = value;
            
        }


        //constructor

        /// <summary>
        /// Creates an obect to represent any field on the database 
        /// </summary>
        /// <param name="name">The name of the field in the table</param>
        /// <param name="fieldtype">Type of the value</param>
        /// <param name="value">data value that is to be use</param>
        public DataCollection(string name, Types fieldtype, object value)
        {
            Name = name;
            FieldType = fieldtype;
            Value = value;
        }

        public bool HasQuotes() {
        /* 
        TINYINT,
        INT,
        BIGINT,
        DOUBLE,
        FLOAT,
        MONEY,
        SMALLMONEY,
        */


            return !(this.FieldType == Types.BIGINT || this.FieldType == Types.INT ||
                this.FieldType == Types.DOUBLE || this.FieldType == Types.FLOAT || this.FieldType == Types.MONEY ||
                this.FieldType == Types.TINYINT || this.FieldType == Types.SMALLMONEY);
        }


    }
}
