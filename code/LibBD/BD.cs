using System;
using System.Collections.Generic;

namespace LibBD
{
    /// <summary>
    /// This Super Class Helps to define a CONCRETE class that will be execute a DB actions 
    /// employing this attributes to generate the ConectionString to each DBMS
    /// </summary>
    public abstract class  BD
    {
        //properties

        public static string ERROR;

        //db properties

        protected string SERVER { get; set; }
        protected string DBNAME { get; set; }
        protected string USER { get; set; }
        protected string PASSW { get; set; }
        protected string PORT { get; set; }



        /// <summary>
        /// Create a new row in the stablished table on the parameters
        /// </summary>
        /// <param name="table">The table in which the data will be added</param>
        /// <param name="data">Value that will be added to the table</param>
        /// <returns>True if the row is created. False if there's an Error</returns>
        public abstract bool Create(string table, List<DataCollection> data);
        /// <summary>
        /// Updates a Row with the ID and Date provided in the parameters, on the selected table
        /// </summary>
        /// <param name="table">The selected table to be updated</param>
        /// <param name="data">the new value to replace the old value</param>
        /// <param name="id">The ID of the row to be updated</param>
        /// <returns>True if the row is created. False if there's an Error</returns>
        public abstract bool Update(string table, List<DataCollection> data, int id);
        /// <summary>
        /// Deletes a Row with the ID and Date provided in the parameters, on the selected table
        /// </summary>
        /// <param name="table"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract bool Delete(string table, int id);
        /// <summary>
        /// Selects a row set that will be a result of a querty on the table stablish, 
        /// with the search criteria on the input
        /// </summary>
        /// <param name="fields">The fields to be given on the row set</param>
        /// <param name="table">Selected table</param>
        /// <param name="search">The search criteria and their logic</param>
        /// <returns>a list of objects that will be represent a row each on of them , and every one is List<Object></returns>
        public abstract List<Object> Read(List<string> fields, string table, List<SearchCollection> search);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="table1"></param>
        /// <param name="table2"></param>
        /// <param name="onFields">the field coditionals the will allow o generate and intersection</param>
        /// <param name="search">the field coditionals the will allow o generate and intersection</param>
        /// <returns></returns>
        public abstract List<Object> Read(List<string> fields, string table1, string table2, List<DataCollection> onFields, List<SearchCollection> search);
        /// <summary>
        /// Retrieves the complete row set of a table, order by the field in the input parameters
        /// </summary>
        /// <param name="table">Table from which the data will be retrieved</param>
        /// <param name="order">the field to be order by (ASC, DESC)</param>
        /// <returns>a list of objects that will be represent a row each on of them , and every one is List<Object></returns>
        public abstract List<Object> Index(string table,OrderBy order);
        /// <summary>
        /// Opens the connection to the SERVER stablished by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Connect();
        /// <summary>
        /// Closes the connection to the SERVER stablished by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Disconnect();
    }
}
