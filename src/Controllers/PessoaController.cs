using System.Collections.Generic;
using System.Data;
using System.Linq;
using SystemTeca.Models;
using Dapper;
using System;

namespace SystemTeca.Controllers
{
    public class PessoaController
    {
        #region Select
        public IEnumerable<PessoaModel> ConsultaTodos()
        {
            return Db.Dc.Connection.Query<PessoaModel>("dbo.spConsultaPessoa",
                commandType: CommandType.StoredProcedure);
        }

        public PessoaModel ConsultaPorId(int idPessoa)
        {
            return Db.Dc.Connection.Query<PessoaModel>("dbo.spConsultaPessoa",
                new
                {
                    IdPessoa = idPessoa,
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public IEnumerable<PessoaModel> ConsultaTodosAtivos()
        {
            return Db.Dc.Connection.Query<PessoaModel>("dbo.spConsultaPessoa", new { AtivoPessoa = 1 },
                commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<PessoaModel> ConsultaPorNome(string nomePessoa)
        {
            return Db.Dc.Connection.Query<PessoaModel>("dbo.spConsultaPessoa", new { NomePessoa = nomePessoa, AtivoPessoa = 1 },
                commandType: CommandType.StoredProcedure);
        }


        #endregion

        public DbResultadoAcao Inserir(PessoaModel pessoa)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spInserirPessoa",
                new
                {
                    NomePessoa = pessoa.NomePessoa,
                    NumeroTelefone = pessoa.NumeroTelefone,
                    RG = pessoa.Rg,
                    CPF = pessoa.Cpf,
                    CEP = pessoa.Cep,
                    Logradouro = pessoa.Logradouro,
                    Numero = pessoa.Numero,
                    Bairro = pessoa.Bairro,
                    Cidade = pessoa.Cidade,
                    UF = pessoa.Uf,
                    AtivoPessoa = pessoa.AtivoPessoa
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        internal object Inserir(object categoria)
        {
            throw new NotImplementedException();
        }

        public DbResultadoAcao Atualizar(PessoaModel pessoa)
        {
            return Db.Dc.Connection.Query<DbResultadoAcao>("dbo.spAtualizarPessoa",
                new
                {
                    IdPessoa = pessoa.IdPessoa,
                    NomePessoa = pessoa.NomePessoa,
                    NumeroTelefone = pessoa.NumeroTelefone,
                    RG = pessoa.Rg,
                    CPF = pessoa.Cpf,
                    CEP = pessoa.Cep,
                    Logradouro = pessoa.Logradouro,
                    Numero = pessoa.Numero,
                    Bairro = pessoa.Bairro,
                    Cidade = pessoa.Cidade,
                    UF = pessoa.Uf,
                    AtivoPessoa = pessoa.AtivoPessoa
                },
                commandType: CommandType.StoredProcedure).FirstOrDefault();
        }


    }
}
