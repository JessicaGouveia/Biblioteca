using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;

namespace SystemTeca.Controllers
{
    public class ColecaoController
    {

        #region Select
        public IEnumerable<ColecaoModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<ColecaoModel>("dbo.spConsultaColecao",
                commandType: CommandType.StoredProcedure);
        }

        public ColecaoModel ConsultaPorId(int id)
        {
            return Db.Dc.Connection.Query<ColecaoModel>("dbo.spConsultaColecao", new { IdColecao = id },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<ColecaoModel> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<ColecaoModel>("dbo.spConsultaColecao", new { AtivoColecao = 1 },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<ColecaoModel> ConsultaPorNome(string nomeColecao)
        {
            return Db.Dc.Connection.Query<ColecaoModel>("dbo.spConsultaColecao", new { NomeColecao = nomeColecao, AtivoColecao = 1 },
                commandType: CommandType.StoredProcedure);
        }


        #endregion

        public DbResultadoAcao Inserir(ColecaoModel colecao)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirColecao",
                new
                {
                    NomeColecao = colecao.NomeColecao,
                    AtivoColecao = colecao.AtivoColecao

                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao Atualizar(ColecaoModel colecao)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarColecao",
                new
                {
                    IdColecao = colecao.IdColecao,
                    NomeColecao = colecao.NomeColecao,
                    AtivoColecao = colecao.AtivoColecao,
                    DeletadoColecao = colecao.DeletadoColecao,
                    QuantidadeColecao = colecao.QuantidadeColecao,
                    VolumeColecao = colecao.VolumeColecao
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
    }
}
