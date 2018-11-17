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

        public EmprestimoModel ConsultaPorId(int idEmprestimo)
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                new
                {
                    IdEmprestimo = idEmprestimo
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<EmprestimoModel> ConsultaPorPessoa(int idPessoa)
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                new
                {
                    IdPessoa = idPessoa
                },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<EmprestimoModel> ConsultaPorMidia(int idMidia)
        {
            return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                new
                {
                    IdMidia = idMidia
                },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<EmprestimoModel> ConsultaPorNome(string nomeMidia, string nomePessoa)
        {
            if (nomeMidia != null && nomePessoa != null)
            {
                return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                    new {NomeMidia = nomeMidia, NomePessoa = nomePessoa},
                    commandType: CommandType.StoredProcedure);
            }else if (nomeMidia != null)
            {
                return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
                    new { NomeMidia = nomeMidia },
                    commandType: CommandType.StoredProcedure);
            }else if (nomePessoa != null)
            {
                return Db.Dc.Connection.Query<EmprestimoModel>("dbo.spConsultaEmprestimo",
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
