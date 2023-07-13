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
    /// <summary>
    /// This class is used to do different actions like Create, Read, Update and Delete Products. 
    /// </summary>
    internal class ProductControl
    {
        /// <values>This propiety is used to create Querys. </value>
        SqlCommand Query;
        /// <values>This propiety is used to create an object kind Connection to use his methods. </value>
        private Connection ConnectionDB;
        public ProductControl()
        {
            ConnectionDB = new Connection();
        }
        /// <summary>
        /// This method save products in the database.
        /// </summary>
        /// <param name="Products">It's an object kind Product that have the parameters to save a product.</param>
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
        /// <summary>
        /// This method update products in the database.
        /// </summary>
        /// <param name="Products">It's an object kind Product that have the parameters to update a product.</param>
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
        /// <summary>
        /// This method delete products in the database.
        /// </summary>
        /// <param name="Products">It's an object kind Product that have the parameters to delete a product.</param>
        public void DeleteProduct(Product Products)
        {
            Query = new SqlCommand("Exec SP_DeleteProducts @ID");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = Products.ID;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }
        /// <summary>
        /// This method show products from the database.
        /// </summary>
        /// <param name="QueryCommand">It's a string that will be have a Query to return anything.</param>
        public DataSet ShowProducts(string QueryCommand)
        {
            Query = new SqlCommand(QueryCommand);
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }
    }
}
