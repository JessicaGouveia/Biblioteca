using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;

namespace SystemTeca.Controllers
{
    public class EmprestimoController
    {
        #region Select
        public IEnumerable<EmprestimoModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                commandType: CommandType.StoredProcedure);
        }

        public EmprestimoModel ConsultaPorId(int idEmprestimo, int idMidia, int idPessoa)
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                new
                {
                    IdEmprestimo = idEmprestimo,
                    IdMidia = idMidia,
                    IdPessoa = idPessoa
                    
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<EmprestimoModel> ConsultaPorNome(string nomeMidia, string nomePessoa)
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo", new { NomeMidia = nomeMidia, NomePessoa = nomePessoa },
                commandType: CommandType.StoredProcedure);
        }


        #endregion

        public DbResultadoAcao InserirEmprestimo(EmprestimoModel emprestimo)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirEmprestimo",
                new
                {
                    IdMidia = emprestimo.IdMidia ,
                    IdPessoa = emprestimo.IdPessoa,
                    QtdEmprestada = emprestimo.QtdEmprestada,
                    Observacao = emprestimo.Observacao,
                    IdOperadorEmprestimo = emprestimo.IdOperadorEmprestimo
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public DbResultadoAcao InserirDevolucao(EmprestimoModel emprestimo)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInsereEmprestimoDevolucao",
                new
                {
                    IdEmprestimo = emprestimo.IdEmprestimo,
                    QuantidadeDevolvida = emprestimo.QtdDevolvida,
                    Observacao = emprestimo.Observacao,
                    IdOperadorDevolucao = emprestimo.IdOperadorDevolucao
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
    }
}
