using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;
using SystemTeca.Queries;

namespace SystemTeca.Controllers
{
    public class MidiaController
    {

        #region Select
        public IEnumerable<MidiaQuery> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia",
                commandType: CommandType.StoredProcedure);
        }

        public MidiaQuery ConsultaPorId(int idMidia)
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia", 
                new
                {
                    IdMidia = idMidia
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<MidiaQuery> ConsultaPorCategoria(int idCategoria)
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia",
                new
                {
                    IdCategoria = idCategoria
                },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<MidiaQuery> ConsultaPorColecao(int idColecao)
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia",
                new
                {
                    IdColecao = idColecao
                },
                commandType: CommandType.StoredProcedure);
        }


        public IEnumerable<MidiaQuery> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia", new { AtivoMidia = 1 },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<MidiaQuery> ConsultaPorNome(string nomeMidia)
        {
            return Db.Dc.Connection.Query<MidiaQuery>("dbo.spConsultaMidia", new { NomeMidia = nomeMidia, AtivoMidia = 1 },
                commandType: CommandType.StoredProcedure);
        }

        #endregion

public DbResultadoAcao Inserir(MidiaModel midia)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirMidia",
                new
                {
                    IdColecao = midia.IdColecao,
                    IdCategoria = midia.IdCategoria,
                    IdOrigem = midia.IdOrigem,
                    NomeMidia = midia.NomeMidia ,
                    AtivoMidia = midia.AtivoMidia,
                    QuantidadeMidia = midia.QuantidadeMidia,
                    LetradoAlfabeto = midia.LetraAlfabeto,
                    Numero = midia.Numero

                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao Atualizar(MidiaModel midia)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarMidia",
                new
                {
                    IdMidia = midia.IdMidia,
                    IdColecao = midia.IdColecao,
                    IdCategoria = midia.IdCategoria,
                    IdOrigem = midia.IdOrigem,
                    NomeMidia = midia.NomeMidia,
                    AtivoMidia = midia.AtivoMidia,
                    QuantidadeMidia = midia.QuantidadeMidia,
                    LetradoAlfabeto = midia.LetraAlfabeto,
                    Numero = midia.Numero
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

    }
}
