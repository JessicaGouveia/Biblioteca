using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemTeca.Models;
using Dapper;

namespace SystemTeca.Controllers
{
    public class OrigemController
    {

        #region Select

        public IEnumerable<OrigemModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<OrigemModel>("dbo.spConsultaOrigem",
                commandType: CommandType.StoredProcedure);
        }

        public OrigemModel ConsultaPorId(int id)
        {
            return Db.Dc.Connection.Query<OrigemModel>("dbo.spConsultaOrigem", new { IdOrigem = id },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<OrigemModel> ConsultaPorNome(string nomeOrigem)
        {
            return Db.Dc.Connection.Query<OrigemModel>("dbo.spConsultaOrigem", new { NomeOrigem = nomeOrigem },
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        public DbResultadoAcao Inserir(OrigemModel origem)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirOrigem",
                new {NomeOrigem = origem.NomeOrigem},
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao Atualizar(OrigemModel origem)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarOrigem",
                new { IdOrigem = origem.IdOrigem, NomeOrigem = origem.NomeOrigem },
                commandType: CommandType.StoredProcedure).FirstOrDefault();

        }
    }
}
