using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Cadastro(String nome, String telefone)
        {
            // TODO: Criar um crud/comandos ---SqlCommand 
            cmd.CommandText = "insert into ex (nome, telefone) values(@nome, @telefone) ";
            // TODO: inserir parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            // TODO: conectar com o banco de dados -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                // TODO: executar o comando escrito 
                cmd.ExecuteNonQuery();
                // TODO: desconectar
                conexao.desconectar();
                // TODO: mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Houve um problema, não foi cadastrado";
            }



        }
    }
}
