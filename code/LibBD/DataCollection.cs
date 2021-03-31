﻿using System;
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
        private object fieldValue;
        public object Value
        {
            get
            {
                if (this.HasQuotes())
                {
                    return $"'{this.fieldValue}'";
                }
                else
                {
                    return this.fieldValue;
                }

            }

            set{ fieldValue = value;}
        }


        //constructor

        /// <summary>
        /// Creates an object to represent any field on the database 
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
            VARCHAR,
            NVARCHAR,
            TEXT,
            NTEXT,
            DATE,
            DATETIME,
            TIME,
            */


            return (this.FieldType==Types.NVARCHAR || this.FieldType == Types.VARCHAR || this.FieldType == Types.TEXT || 
                    this.FieldType == Types.NTEXT || this.FieldType == Types.DATE || this.FieldType == Types.DATETIME ||
                    this.FieldType == Types.TIME );
        }


    }
}
