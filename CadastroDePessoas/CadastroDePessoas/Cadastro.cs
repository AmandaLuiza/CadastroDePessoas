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
        public String mensagem;
        public Cadastro(String nome, String telefone)
        {
            // TODO: Criar um crud/comandos ---SqlCommand 
            cmd.CommandText = "";
            // TODO: inserir parametros
            // TODO: conectar com o banco de dados -- Conexao
            // TODO: executar o comando escrito 
            // TODO: desconectar
            // TODO: mostrar mensagem de erro ou sucesso -- variavel
        }
    }
}
