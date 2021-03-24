using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibBD
{
    public class SqlServer : BD
    {
        //Attributes of SQLServer

        SqlConnection con;
        SqlCommand com;
        //SqlDataReader dr;

        //ConectionString
        string connectionString;

        //Constructor
        public SqlServer(string server, string db, string user, string pwd, string port="1433") 
        {
            //initialize attributes
            this.SERVER = server;
            this.DBNAME = db;
            this.USER = user;
            this.PASSW = pwd;
            this.PORT = port;

            //
            this.connectionString = $"Server={this.SERVER},{this.PORT};Database={this.DBNAME};User Id={this.USER};Password={this.PASSW};";
            //intanciate the connection
            this.con = new SqlConnection(this.connectionString);
        }


        //BND actions
        public override bool Connect()
        {
            bool res = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else if (con.State == ConnectionState.Broken)
                {
                    con.Close();
                    con.Open();
                }
                res = true;
            }
            catch (SqlException Sqlex) 
            {
                BD.ERROR = "SQL Error while openning Sql Server Connection " + Sqlex;
            }

            catch (Exception ex)
            {
                BD.ERROR = "Error while openning Sql Server Connection " + ex;
            }


            return res;
        }

        public override bool Disconnect()
        {
            bool res = false;
            try
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                
                res = true;
            }
            catch (SqlException Sqlex)
            {
                BD.ERROR = "SQL Error while closing Sql Server Connection " + Sqlex;
            }

            catch (Exception ex)
            {
                BD.ERROR = "Error while closing Sql Server Connection " + ex;
            }


            return res;
        }

        public override bool Create(string table, List<DataCollection> data)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(string table, int id)
        {
            throw new NotImplementedException();
        }

        public override List<object> Index(string table, OrderBy order)
        {
            throw new NotImplementedException();
        }

        public override List<object> Read(List<string> fields, string table, List<SearchCollection> search)
        {
            throw new NotImplementedException();
        }

        public override List<object> Read(List<string> fields, string table1, string table2, List<DataCollection> onFields, List<SearchCollection> search)
        {
            throw new NotImplementedException();
        }

        public override bool Update(string table, List<DataCollection> data, int id)
        {
            throw new NotImplementedException();
        }
    }
}
