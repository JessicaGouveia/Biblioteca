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
    public class CategoriaController
    {
        #region select
        public IEnumerable<CategoriaModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<CategoriaModel>("dbo.spConsultaCategorias",
            commandType: CommandType.StoredProcedure);
        }

        public CategoriaModel ConsultaPorId(int id)
        {
            return Db.Dc.Connection.Query<CategoriaModel>("dbo.spConsultaCategorias", new {IdCategoria = id},
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<CategoriaModel> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<CategoriaModel>("dbo.spConsultaCategorias", new { AtivoCategoria = 1},
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<CategoriaModel> ConsultaPorNome(string nomeCategoria)
        {
            return Db.Dc.Connection.Query<CategoriaModel>("dbo.spConsultaCategorias", new { NomeCategoria = nomeCategoria, AtivoCategoria = 1 },
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        public DbResultadoAcao Inserir(CategoriaModel categoria)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirCategoria",
                new {NomeCategoria = categoria.NomeCategoria, AtivoCategoria = categoria.AtivoCategoria},
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao Atualizar(CategoriaModel categoria)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarCategoria",
                new
                {
                    IdCategoria = categoria.IdCategoria, NomeCategoria = categoria.NomeCategoria, AtivoCategoria = categoria.AtivoCategoria,
                    DeletadoCategoria = categoria.DeletadoCategoria},
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        
    }
}
