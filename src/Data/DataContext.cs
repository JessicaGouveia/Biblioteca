﻿using System;
using System.Data.SqlClient;
using System.Data;

namespace SystemTeca.Data
{
    public class DataContext : IDisposable
    {
<<<<<<< HEAD
        private static string ConnectionString = "Data Source=DESKTOP-E1JHOO7\\SQLEXPRESS;Initial Catalog=Biblioteca;Persist Security Info=True;User ID=aluno;Password=1234;MultipleActiveResultSets=True";

=======
        private static string ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca_2;Data Source=DESKTOP-KI2AEK2\SQLEXPRESS";
>>>>>>> master

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
