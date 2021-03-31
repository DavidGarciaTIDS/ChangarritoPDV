﻿using System;
using System.Collections.Generic;
using LibBD;

namespace LibPDV.App
{
    public abstract class CRUD
    {
        protected string table { get; set; }

        protected List<string> fieldList { get; set; }

        public string ERROR { get; set; }

        //hard coded database connection
        //BD libBD = new SqlServer("localhost","DBpdv","root","toor");
        BD libBD = new LibBD.MySql("127.0.0.1","db_pdvuth2021", "PurPur", "Pur123");

        protected CRUD(string Table, List<string> FieldList) 
        {
            this.table = Table;
            this.fieldList = FieldList;
        }
        protected bool Create( List<DataCollection> data) 
        {
            return libBD.Create(this.table,data);
        }
        protected bool Update( List<DataCollection> data, int id) 
        {
            return libBD.Update(this.table,data,id);
        }
        protected bool Delete( int id) 
        {
            return libBD.Delete(this.table,id);
        }
        protected List<List<object>> index(OrderBy order) 
        {
            return libBD.Index(this.table,order);
        }
        protected List<List<object>> Read(List<string> fieldlist, List<SearchCollection>search) 
        {
            return libBD.Read(fieldlist,this.table,search);
        }
        protected List<List<Object>> Read(List<string> fields, string table2, List<string> onFields, List<SearchCollection> search)
        {
            return libBD.Read(fields,this.table,table2,onFields,search);
        }
    }
}
