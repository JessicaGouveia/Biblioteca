using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using SystemTeca.Queries;
using Dapper;

namespace SystemTeca.Controllers
{
    public class EmprestimoController
    {
        #region Select
        public IEnumerable<EmprestimoQuery> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<EmprestimoQuery> ConsultaTodosNaoDevolvido()
        {
            return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                new { Devolvido = false },
                commandType: CommandType.StoredProcedure);
        }

        public EmprestimoQuery ConsultaPorId(int idEmprestimo)
        {
            return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                new
                {
                    IdEmprestimo = idEmprestimo
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<EmprestimoQuery> ConsultaPorPessoa(int idPessoa)
        {
            return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                new
                {
                    IdPessoa = idPessoa
                },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<EmprestimoQuery> ConsultaPorMidia(int idMidia)
        {
            return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                new
                {
                    IdMidia = idMidia
                },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<EmprestimoQuery> ConsultaPorNome(string nomeMidia, string nomePessoa)
        {
            if (nomeMidia != null && nomePessoa != null)
            {
                return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                    new {NomeMidia = nomeMidia, NomePessoa = nomePessoa},
                    commandType: CommandType.StoredProcedure);
            }else if (nomeMidia != null)
            {
                return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                    new { NomeMidia = nomeMidia },
                    commandType: CommandType.StoredProcedure);
            }else if (nomePessoa != null)
            {
                return Db.Dc.Connection.Query<EmprestimoQuery>("dbo.spConsultaEmprestimo",
                    new { NomePessoa = nomePessoa },
                    commandType: CommandType.StoredProcedure);
            }

            return null;
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
                    IdOperadorEmprestimo = Usuario.LoginUsuario.IdPessoa
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
                    IdOperadorDevolucao = Usuario.LoginUsuario.IdPessoa
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
    }
}
