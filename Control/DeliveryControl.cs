using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDSTORE.Model;
using System.Data;

namespace CRUDSTORE.Control
{
    /// <summary>
    /// This class is used to do different actions like Create, Read, Update and Delete. 
    /// </summary>
    internal class DeliveryControl
    {
        /// <value>The propiety ConnectionDB is used to access his methods. </value>
        private Connection ConnectionDB;
        /// <value> The property Query is used to create Querys. </value>
        SqlCommand Query;

        public DeliveryControl()
        {
            ConnectionDB = new Connection();
        }
        /// <summary>
        /// This function is used to save register in the database.
        /// </summary>
        /// <param name="DeliveryProducts">It's an object of kind DeliveryProducts that have the parameters to save.</param>
        public void AddDeliveryProduct(DeliveryProduct DeliveryProducts)
        {
            Query = new SqlCommand("Exec SP_SaveDeliveryProducts @DeliveryName, @Company, @PhoneNumber, @DeliveryDays");
            Query.Parameters.Add("@DeliveryName", SqlDbType.VarChar).Value = DeliveryProducts.Name;
            Query.Parameters.Add("@Company", SqlDbType.VarChar).Value = DeliveryProducts.Company;
            Query.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = DeliveryProducts.PhoneNumber;
            Query.Parameters.Add("@DeliveryDays", SqlDbType.VarChar).Value = DeliveryProducts.DeliveryDays;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        /// <summary>
        /// This function is used to update a register in the database.
        /// </summary>
        /// <param name="DeliveryProducts">It's an object of kind DeliveryProducts that have the parameters to update a register.</param>
        public void UpdateDeliveryProduct(DeliveryProduct DeliveryProducts)
        {
            Query = new SqlCommand("Exec SP_UpdateDeliveryProducts @ID, @DeliveryName, @Company, @PhoneNumber, @DeliveryDays");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = DeliveryProducts.ID;
            Query.Parameters.Add("@DeliveryName", SqlDbType.VarChar).Value = DeliveryProducts.Name;
            Query.Parameters.Add("@Company", SqlDbType.VarChar).Value = DeliveryProducts.Company;
            Query.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = DeliveryProducts.PhoneNumber;
            Query.Parameters.Add("@DeliveryDays", SqlDbType.VarChar).Value = DeliveryProducts.DeliveryDays;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        /// <summary>
        /// This function is used to delete a register in the database.
        /// </summary>
        /// <param name="DeliveryProducts">It's an object of kind DeliveryProducts that have the parameter to delete a register.</param>
        public void DeleteDeliveryProduct(DeliveryProduct DeliveryProducts)
        {
            Query = new SqlCommand("Exec SP_DeleteDeliveryProducts @ID");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = DeliveryProducts.ID;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        /// <summary>
        /// This function can do Querys to see information of the database.
        /// </summary>
        /// <param name="QueryCommand">It's a string that will be have a Query to return anything.</param>
        /// <returns></returns>

        public DataSet ShowDelivery(string QueryCommand)
        {
            Query = new SqlCommand(QueryCommand);
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }

    }
}
