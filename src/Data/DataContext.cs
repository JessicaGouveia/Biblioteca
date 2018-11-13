using System;
using System.Data.SqlClient;
using System.Data;

namespace SystemTeca.Data
{
    public class DataContext : IDisposable
    {
        private static string ConnectionString =
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca_2;Data Source=DESKTOP-KI2AEK2\\SQLEXPRESS";

        public SqlConnection Connection { get; private set; }

        public DataContext()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();

        }
    }
}
