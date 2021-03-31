using LibPDV.App;
using LibBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPDV.Products
{
    public class Products : CRUD
    {
        
        public Products() : base("products", new List<string>() {  "name", "description", "price", "bar_code", "brand_id", "subcategory_id", "image", "measure_unit", "sku" }) 
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string BarCode { get; set; }
        public string brand { get; set; }
        public string subcategory { get; set; }
        public string metricUnit { get; set; }
        List<DataCollection> data;

        public bool Create( string name, string description,double price, string barCode, int brandId,int subCategoryId,string metricUnit, string sku) 
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("price", Types.DOUBLE, price));
            data.Add(new DataCollection("bar_code", Types.INT, barCode));
            data.Add(new DataCollection("brand_Id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_Id", Types.INT, subCategoryId));
            data.Add(new DataCollection("measure_unit", Types.VARCHAR, metricUnit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            bool res = base.Create(data);

            if (!res)
            {
                this.ERROR = BD.ERROR;
            }
            return res;
        
        }
        public bool Update(int id,string name, string description, double price, string barCode, int brandId, int subCategoryId, string metricUnit, string sku) 
        {
            data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("description", Types.VARCHAR, description));
            data.Add(new DataCollection("price", Types.DOUBLE, price));
            data.Add(new DataCollection("bar_code", Types.INT, barCode));
            data.Add(new DataCollection("brand_Id", Types.INT, brandId));
            data.Add(new DataCollection("subcategory_Id", Types.INT, subCategoryId));
            data.Add(new DataCollection("measure_unit", Types.VARCHAR, metricUnit));
            data.Add(new DataCollection("sku", Types.VARCHAR, sku));
            

            return base.Update(data, id);
        }
    }
}
