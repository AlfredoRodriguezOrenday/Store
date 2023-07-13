using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CRUDSTORE.Model;

namespace CRUDSTORE.Control
{
        /// <summary>
        /// This class is used to connect with the database and provide two methods to execute Sql commands.
        /// </summary>
    internal class Connection
    {
        /// <value> The property ConnectionDB will be used to create a Connection with Sql.</value>
        SqlConnection ConnectionDB;

        /// <value> The property stringConnectios is used to save the path of the database.</value>
        private string StringConnection = "server= LAPTOP-3989L6UR; database= StoreMini; integrated security = true";
        
        /// <summary>
        /// This function do a connection with the database.
        /// </summary>
        /// <returns>An object SqlConnection with the path of the database.</returns>
        public SqlConnection SetConnection()
        {
             return ConnectionDB = new SqlConnection(StringConnection);
        }

        /// <summary>
        /// Query This function require a SqlCommand named Query that will be executed with commands that don't return data. 
        /// </summary>
        /// <param name="Query">It's a SqlCommand</param>

        public void ExecuteQueryWithOutReturnData(SqlCommand Query)
        {

            try
            {
                SqlCommand ExecuteQuery = Query;
                ExecuteQuery.Connection = SetConnection();
                ConnectionDB.Open();
                ExecuteQuery.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show("It was an Error: " + ex.Message);
            }
            finally{
                ConnectionDB.Close();
            }
        }

        /// <summary>
        /// Query This function require a SqlCommand named Query that will be executed with commands that return data and used in the Views. 
        /// </summary>
        /// <param name="Query">It's a SqlCommand</param>

        public DataSet ExecuteQueryWithReturnData(SqlCommand Query)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            try
            {
                SqlCommand ExecuteQuery = Query;
                ExecuteQuery.Connection = SetConnection();
                Adapter.SelectCommand = ExecuteQuery;
                ConnectionDB.Open();
                Adapter.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("It was an Error: " + ex.Message);
                return DS;
            }
            finally
            {
                ConnectionDB.Close();
            }
        }
    }
}
