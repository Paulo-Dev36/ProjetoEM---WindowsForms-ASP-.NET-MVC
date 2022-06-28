using EM.Domain;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        string ConexaoStr;

        public RepositorioAluno()
        { 
            ConexaoStr = "User=SYSDBA; Password=masterkey;Database=C:\\Users\\pvini\\source\\repos\\Escolar Manager\\Banco\\BANCOESCOLARMANAGERTESTE.FB4;" +
                                                                                                  "character set=Iso8859_1; DataSource=Localhost;Port=3054";

        }

        public FbConnection conexao;

        public FbConnection ConexaoBanco()
        {
            try
            {
                conexao = new FbConnection(ConexaoStr);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falha na conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            return conexao;
        }

        public override void Add(Aluno aluno)

        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();
            const string insert = @"INSERT INTO ALUNOS (MATRICULA, NOME, SEXO, NASCIMENTO, CPF) 
                                   VALUES(@Matricula, @Nome, @Sexo, @Nascimento, @CPF)";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = insert;

            cmd.Parameters.AddWithValue(@"Matricula", aluno.Matricula);
            cmd.Parameters.AddWithValue(@"Nome", aluno.Nome);
            cmd.Parameters.AddWithValue(@"Sexo", (int)aluno.Sexo);
            cmd.Parameters.AddWithValue(@"Nascimento", aluno.Nascimento);
            cmd.Parameters.AddWithValue(@"CPF", aluno.CPF);
            cmd.ExecuteNonQuery();
        }

        public override void Remove(Aluno aluno)
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();

            var delete = $@"DELETE FROM ALUNOS WHERE MATRICULA = {aluno.Matricula}";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = delete;

            cmd.ExecuteNonQuery();
        }

        public override void Update(Aluno aluno)
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();

            var update = $@"UPDATE ALUNOS
                                    SET NOME = @Nome, SEXO = @Sexo, NASCIMENTO = @Nascimento, CPF = @Cpf
                                    WHERE MATRICULA = {aluno.Matricula}";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = update;

            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Sexo", (int)aluno.Sexo);
            cmd.Parameters.AddWithValue("@Nascimento", aluno.Nascimento);
            cmd.Parameters.AddWithValue("@Cpf", aluno.CPF);
            cmd.ExecuteNonQuery();
        }

        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();
            var alunos = (List<Aluno>)GetAll();

            return alunos.AsQueryable().Where(predicate).ToList();
        }

        public override IEnumerable<Aluno> GetAll()
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();

            var lista = $@"SELECT * FROM ALUNOS
                           ORDER BY ALUNOS.MATRICULA";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = lista;

            var cmdDt = new FbDataAdapter(cmd);
            var dataTable = new DataTable();
            cmdDt.Fill(dataTable);

            List<Aluno> alunos = new List<Aluno>();

            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                var aluno = new Aluno()
                {
                    Matricula = (int)dataTable.Rows[i][0],
                    Nome = dataTable.Rows[i][1].ToString(),
                    Sexo = (EnumeradorSexo)dataTable.Rows[i][2],
                    Nascimento = (DateTime)dataTable.Rows[i][3],
                    CPF = dataTable.Rows[i][4].ToString(),
                };
                alunos.Add(aluno);
            }
            return alunos;
        }

        public Aluno GetByMatricula(int matricula)
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();

            var selectMatricula = $@"SELECT * FROM ALUNOS WHERE MATRICULA = {matricula}";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = selectMatricula;

            var cmdDt = new FbDataAdapter(cmd);
            var dtble = new DataTable();
            cmdDt.Fill(dtble);

            return ( dtble.Rows.Count > 0) ? new Aluno()
            {
                Matricula = (int)dtble.Rows[0][0],
                Nome = dtble.Rows[0][1].ToString(),
                Sexo = (EnumeradorSexo)dtble.Rows[0][2],
                Nascimento = (DateTime)dtble.Rows[0][3],
                CPF = dtble.Rows[0][4].ToString()
            } : null;
        }
        
        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            conexao = new FbConnection(ConexaoStr);
            conexao.Open();

            var selectNome = $@"SELECT * FROM ALUNOS WHERE UPPER(NOME) LIKE UPPER('%{parteDoNome}%')";
            var cmd = conexao.CreateCommand();
            cmd.CommandText = selectNome;

            var cmdDt = new FbDataAdapter(cmd);
            var dtble = new DataTable();
            cmdDt.Fill(dtble);

            List<Aluno> alunos = new List<Aluno>();

            for(int i = 0; i < dtble.Rows.Count; i++)
            {
                var aluno = new Aluno()
                {
                    Matricula = (int)dtble.Rows[i][0],
                    Nome = dtble.Rows[i][1].ToString(),
                    Sexo = (EnumeradorSexo)dtble.Rows[i][2],
                    Nascimento = (DateTime)dtble.Rows[i][3],
                    CPF = dtble.Rows[i][4].ToString()
                };
                alunos.Add(aluno);
            }
            return alunos;
        }
    }
}
