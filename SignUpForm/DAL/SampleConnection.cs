using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SampleConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=KELLGGNCPU0229\SQLEXPRESS;Initial Catalog=SampleExercise;Integrated Security=True");
        public SampleConnection()
        {

        }
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
              sqlConnection.Open();
            }


        }
        private void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();

            }

        }
        public void ExecuteNonQuery(string query)
        {
            Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            Close();
        }
    }
}
