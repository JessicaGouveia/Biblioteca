using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;

namespace SystemTeca.Controllers
{
    public class MidiaController
    {


        #region Select
        public IEnumerable<MidiaModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<MidiaModel>("dbo.spConsultaMidia",
                commandType: CommandType.StoredProcedure);
        }

        public MidiaModel ConsultaPorId(int idMidia, int idColecao, int idCategoria, int idOrigem)
        {
            return Db.Dc.Connection.Query<MidiaModel>("dbo.spConsultaMidia", 
                new
                {
                    IdMidia = idMidia,
                    IdColecao = idColecao,
                    IdCategoria = idCategoria,
                    IdOrigem = idOrigem
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<MidiaModel> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<MidiaModel>("dbo.spConsultaMidia", new { AtivoMidia = 1 },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<MidiaModel> ConsultaPorNome(string nomeMidia)
        {
            return Db.Dc.Connection.Query<MidiaModel>("dbo.spConsultaMidia", new { NomeMidia = nomeMidia, AtivoMidia = 1 },
                commandType: CommandType.StoredProcedure);
        }


        #endregion

        public DbResultadoAcao Inserir(MidiaModel midia)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirMidia",
                new
                {
                    NomeMidia = midia.NomeMidia ,
                    AtivoMidia = midia.AtivoMidia,
                    QuantidadeMidia = midia.QuantidadeMidia,
                    LetraAlfabeto = midia.LetraAlfabeto,
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
                    NomeMidia = midia.NomeMidia,
                    AtivoMidia = midia.AtivoMidia,
                    QuantidadeMidia = midia.QuantidadeMidia,
                    LetraAlfabeto = midia.LetraAlfabeto,
                    Numero = midia.Numero
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

    }
}
