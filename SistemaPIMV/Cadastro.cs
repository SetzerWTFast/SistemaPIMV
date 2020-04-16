using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPIMV
{ 
    class CadastroCliente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastroCliente (String nome,
                            String cpf,
                            String rg,
                            String apelido,
                            String zona,
                            String observacao,
                            String tipo,
                            String cep,
                            String logradouro,
                            String endereco,
                            String numero,
                            String complemento,
                            String bairro,
                            String cidade,
                            String uf,
                            String referencia,
                            String ddd,
                            String telefone,
                            String nomeContato)
        {
            cmd.CommandText = "INSERT INTO tbl_Clientes (nome, data, cpf, rg, apelido, zona, observacao, tipo, cep, logradouro, endereco, numero, complemento, bairro, cidade, uf, referencia, ddd, telefone, nomeContato) " +
                              "VALUES (@nome, @data, @cpf, @rg, @apelido, @zona, @observacao, @tipo, @cep, @logradouro, @endereco, @numero, @complemento, @bairro, @cidade, @uf, @referencia, @ddd, @telefone, @nomeContato)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", DateTime.Now);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@apelido", apelido);
            cmd.Parameters.AddWithValue("@zona", zona);
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@referencia", referencia);
            cmd.Parameters.AddWithValue("@ddd", ddd);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@nomeContato", nomeContato);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
    }

    class CadastroProdutos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastroProdutos(String fabrica, 
                                String barra, 
                                String descricao, 
                                String unidade, 
                                String utilizacao
                                )
        {
            cmd.CommandText = "INSERT INTO tbl_Produtos(data, fabrica, barra, descricao, unidade, utilizacao) " +
                              "VALUES (@data, @fabrica, @barra, @descricao, @unidade, @utilizacao)";

            cmd.Parameters.AddWithValue("@data", DateTime.Now);
            cmd.Parameters.AddWithValue("@fabrica", fabrica);
            cmd.Parameters.AddWithValue("@barra", barra);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@unidade", unidade);
            cmd.Parameters.AddWithValue("@utilizacao", utilizacao);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }
    }

    class AlugarProduto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public AlugarProduto(String codigoCliente, String cliente, String codigoProduto, String produto, String dataRetira, String dataDevolucao, String local, String observacao, int alugado)
        {
            cmd.CommandText = "INSERT INTO tbl_AlugarProdutos(idCliente, cliente, idProduto, produto, dataRetira, dataDevolucao, local, observacao. alugado) " +
                              "VALUES (@idCliente, @cliente, @idProduto, @produto, @dataRetira, @dataDevolucao, @local, @observacao, @alugado)";

            cmd.Parameters.AddWithValue("@idCliente", codigoCliente);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@idProduto", codigoProduto);
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Parameters.AddWithValue("@dataRetira", DateTime.Now);
            cmd.Parameters.AddWithValue("@dataDevolucao", dataDevolucao);
            cmd.Parameters.AddWithValue("@local", local);
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@alugado", alugado);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Produto Alugado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }
    }

    class CadastrarUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastrarUsuario(String login, String senha)
        {
            cmd.CommandText = "INSERT INTO tbl_Login(login, senha) VALUES(@login, @senha)";

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Usuário Cadastrado, entre com o mesmo";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }

    }

    class AlterarSenha
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public AlterarSenha(String usuario, String senha)
        {
            cmd.CommandText = "UPDATE tbl_Login SET senha = @senha WHERE login = @login";

            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Senha alterada com sucesso, entre com o mesmo";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
    }
}
