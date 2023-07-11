using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUDSTORE.Model;

namespace CRUDSTORE.Control
{
    internal class ProductControl
    {
        SqlCommand Query;
        private Connection ConnectionDB;
        public ProductControl()
        {
            ConnectionDB = new Connection();
        }
        public void SaveProduct(Product Products)
        {
            Query = new SqlCommand("Exec SP_SaveProducts @ProductName, @Description, @Size, @Price, @Available, @Photo, @IdDelivery");
            Query.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = Products.Name;
            Query.Parameters.Add("@Description", SqlDbType.VarChar).Value = Products.Description;
            Query.Parameters.Add("@Size", SqlDbType.Float).Value = Products.Size;
            Query.Parameters.Add("@Price", SqlDbType.Float).Value = Products.Price;
            Query.Parameters.Add("@Available", SqlDbType.Float).Value = Products.Available;
            Query.Parameters.Add("@Photo", SqlDbType.Image).Value = Products.Photo;
            Query.Parameters.Add("@IdDelivery", SqlDbType.Int).Value = Products.IdDelivery;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void UpdateProduct(Product Products)
        {
            Query = new SqlCommand("Exec SP_UpdateProducts @ID, @ProductName, @Description, @Size, @Price, @Available, @Photo, @IdDelivery");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = Products.ID;
            Query.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = Products.Name;
            Query.Parameters.Add("@Description", SqlDbType.VarChar).Value = Products.Description;
            Query.Parameters.Add("@Size", SqlDbType.Float).Value = Products.Size;
            Query.Parameters.Add("@Price", SqlDbType.Float).Value = Products.Price;
            Query.Parameters.Add("@Available", SqlDbType.Float).Value = Products.Available;
            Query.Parameters.Add("@Photo", SqlDbType.Image).Value = Products.Photo;
            Query.Parameters.Add("@IdDelivery", SqlDbType.Int).Value = Products.IdDelivery;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void DeleteProduct(Product Products)
        {
            Query = new SqlCommand("Exec SP_DeleteProducts @ID");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = Products.ID;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public DataSet ShowProducts(string QueryCommand)
        {
            Query = new SqlCommand(QueryCommand);
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }
    }
}
