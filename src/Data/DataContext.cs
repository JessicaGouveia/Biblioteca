using System;
using System.Data.SqlClient;
using System.Data;

namespace SystemTeca.Data
{
    public class DataContext : IDisposable
    {
        private static string ConnectionString =
            "Data Source=DESKTOP-9CDCQIJ\\SQLEXPRESS;Initial Catalog=Biblioteca;Persist Security Info=True;User ID=aluno;Password=1234;MultipleActiveResultSets=True";


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
