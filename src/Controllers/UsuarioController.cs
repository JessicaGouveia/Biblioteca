using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;

namespace SystemTeca.Controllers
{
    public class UsuarioController
    {

        #region Select
        public IEnumerable<UsuarioModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<UsuarioModel>("dbo.spConsultaUsuario",
                commandType: CommandType.StoredProcedure);
        }

        public UsuarioModel ConsultaPorId(int id)
        {
            return Db.Dc.Connection.Query<UsuarioModel>("dbo.spConsultaUsuario", new { IdPessoa = id },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<UsuarioModel> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<UsuarioModel>("dbo.spConsultaUsuario", new { UsuarioAtivo = 1 },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<UsuarioModel> ConsultaPorNome(string loginUsuario)
        {
            return Db.Dc.Connection.Query<UsuarioModel>("dbo.spConsultaUsuario", new { LoginUsuario = loginUsuario, UsuarioAtivo = 1 },
                commandType: CommandType.StoredProcedure);
        }


        #endregion

        public DbResultadoAcao Inserir(UsuarioModel usuario)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirUsuario",
                new
                {
                    LoginUsuario = usuario.LoginUsuario,
                    SenhaUsuario = usuario.SenhaUsuario,
                    UsuarioAtivo = usuario.UsuarioAtivo

                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao Atualizar(UsuarioModel usuario)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarUsuario",
                new
                {
                    IdPessoa = usuario.IdPEssoa,
                    LoginUsuario = usuario.LoginUsuario,
                    SenhaUsuario = usuario.SenhaUsuario,
                    UsuarioAtivo = usuario.UsuarioAtivo
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
    }
}
