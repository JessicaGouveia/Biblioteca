using System.Data;
using System.Linq;
using Dapper;
using SystemTeca.Models;

namespace SystemTeca
{
    public static class Usuario
    {
        
       public static LoginModel LoginUsuario { get; private set; }

       public static bool Autenticacao(string login, string senha )
       {
           var autenticacao = Db.Dc.Connection.Query<LoginModel>("dbo.spLogin", new {Login = login, Senha = senha},
               commandType: CommandType.StoredProcedure).FirstOrDefault();

           if (autenticacao != null)
           {
               LoginUsuario = autenticacao;
               return true;
           }

           return false;

       }
    }
}
