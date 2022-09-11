using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL.EntityManagers
{
    public class ProductManager
    {
        static DBManager dBManager = new DBManager();


        public static ProductList SelectAllProducts()
        {
            try
            {
                return DataTableToProductList(
                dBManager.ExecuteDataTable("SelectAllProducts"));
            }
            catch
            {

            }
            return new ProductList();
        }

        public static bool DeleteProductByID (int ProductID)
        {
            try
            {
                Dictionary<string, object> ParamLst = new Dictionary<string, object>()
                { ["ProductID"] = ProductID };
                if (dBManager.ExecuteNonQuery("DeleteProductByID", ParamLst) > 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }


        #region Mapping Functions
        internal static ProductList DataTableToProductList ( DataTable Dt)
        {
            ProductList PrdLst = new ProductList();
            try
            {
                if ( Dt?.Rows?.Count>0)
                {
                    foreach (DataRow Dr in Dt.Rows)
                    {
                        PrdLst.Add(DataRowToProduct(Dr));
                    }
                }
            }
            catch
            {

            }
            return PrdLst;
        }

        internal static Product DataRowToProduct (DataRow Dr)
        {
            int TempInt;
            short TempShort;
            Product Prd = new Product();
            try
            {
                Prd.ProductID = Dr.Field<int>("ProductID");

                if (int.TryParse(Dr["CategoryID"]?.ToString() ?? "0", out TempInt))
                    Prd.CategoryID = TempInt;

                if (bool.TryParse(Dr["Discontinued"]?.ToString() ?? "False", out bool TempBool))
                    Prd.Discontinued = TempBool;

                Prd.ProductName = Dr["ProductName"]?.ToString() ?? "NA";
                
                Prd.QuantityPerUnit = Dr["QuantityPerUnit"]?.ToString() ?? "NA";

                if (short.TryParse(Dr["ReorderLevel"]?.ToString() ?? "0", out TempShort))
                    Prd.ReorderLevel = TempShort;

                if (int.TryParse(Dr["SupplierID"]?.ToString() ?? "0", out TempInt))
                    Prd.SupplierID = TempInt;

                if (decimal.TryParse(Dr["UnitPrice"]?.ToString() ?? "0", out decimal TempD))
                    Prd.UnitPrice = TempD;

                if (short.TryParse(Dr["UnitsInStock"]?.ToString() ?? "0", out TempShort))
                    Prd.UnitsInStock = TempShort;
                
                if (short.TryParse(Dr["UnitsOnOrder"]?.ToString() ?? "0", out TempShort))
                    Prd.UnitsOnOrder = TempShort;

                Prd.State = EntityState.Unchanged;
            }
            catch
            {

            }
            return Prd;
        }


        #endregion
    }
}
