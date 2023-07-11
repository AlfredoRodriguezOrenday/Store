using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUDSTORE.Control
{
    internal class Connection
    {
        SqlConnection ConnectionDB;
        private string StringConnection = "server= LAPTOP-3989L6UR; database= StoreMini; integrated security = true";
        public SqlConnection SetConnection()
        {
             return ConnectionDB = new SqlConnection(StringConnection);
        }
        /*
         * @Query This function require an Object with the Query that will be executed. 
         * */

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

        public SqlDataReader ExecuyteQueryWithReturnDataReader(string Query)
        {
            SqlDataReader Reader;
            SqlCommand ExecuteQuery = new SqlCommand(Query);
            ExecuteQuery.Connection = SetConnection();
            ConnectionDB.Open();
            Reader = ExecuteQuery.ExecuteReader();
            ConnectionDB.Close();
            return Reader;
        }

    }
}
