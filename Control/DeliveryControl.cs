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
    internal class DeliveryControl
    {
        private Connection ConnectionDB;
        SqlCommand Query;

        public DeliveryControl()
        {
            ConnectionDB = new Connection();
        }
        public void AddDeliveryProduct(DeliveryProduct DeliveryProducts)
        {
            Query = new SqlCommand("Exec SP_SaveDeliveryProducts @DeliveryName, @Company, @PhoneNumber, @DeliveryDays");
            Query.Parameters.Add("@DeliveryName", SqlDbType.VarChar).Value = DeliveryProducts.Name;
            Query.Parameters.Add("@Company", SqlDbType.VarChar).Value = DeliveryProducts.Company;
            Query.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = DeliveryProducts.PhoneNumber;
            Query.Parameters.Add("@DeliveryDays", SqlDbType.VarChar).Value = DeliveryProducts.DeliveryDays;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void UpdateDeliveryProduct(DeliveryProduct DP)
        {
            Query = new SqlCommand("Exec SP_UpdateDeliveryProducts @ID, @DeliveryName, @Company, @PhoneNumber, @DeliveryDays");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = DP.ID;
            Query.Parameters.Add("@DeliveryName", SqlDbType.VarChar).Value = DP.Name;
            Query.Parameters.Add("@Company", SqlDbType.VarChar).Value = DP.Company;
            Query.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = DP.PhoneNumber;
            Query.Parameters.Add("@DeliveryDays", SqlDbType.VarChar).Value = DP.DeliveryDays;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void DeleteDeliveryProduct(DeliveryProduct DP)
        {
            Query = new SqlCommand("Exec SP_DeleteDeliveryProducts @ID");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = DP.ID;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public DataSet ShowDelivery(string QueryCommand)
        {
            Query = new SqlCommand(QueryCommand);
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }

    }
}
