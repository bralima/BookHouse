using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Livraria
{
    internal class CadastroCliente
    {
        public string IDCliente {  get; set; }
        public string ClienteNome { get; set; }
        public string ClienteSobrenome { get; set; }
        public string ClienteSexo { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteTelefone { get; set; }
        public string ClienteSenha { get; set; }

        readonly string strConexao = @"Server=localhost;Database=master;Trusted_Connection=True;";

        private const string strINSERT = "INSERT INTO tb_Cliente (Nome, SobreNome, Sexo, Email, Telefone, Senha) " +
                    "VALUES(@Nome, @SobreNome, @Sexo, @Email, @Telefone, @Senha); ";
        private const string strSELECT = "SELECT * FROM tb_Cliente; ";

        public const string strUPDATE = "UPDATE tb_Cliente SET Nome = @Nome, SobreNome = @SobreNome, Sexo = @Sexo, Email = @Email, Telefone = @Telefone, Senha = @Senha WHERE ID=@ID ";
        public CadastroCliente()
        {
            using(SqlConnection oConn = new SqlConnection(strConexao))
            {
                string sSQL = " IF OBJECT_ID(N'dbo.tb_Cliente', N'U') IS NULL   " +
                                "   CREATE TABLE dbo.tb_Cliente(                " +
                                "       ID int identity primary key,  " +
                                "       Nome varchar(15),                " +
                                "       Sobrenome varchar(30),           " +
                                "       Sexo varchar(2) ,                    " +
                                "       Email varchar(30),             " +
                                "       Telefone varchar(100),                " +
                                "       Senha varchar(50),              " +
                                "   )";
                oConn.Open();
                using (SqlCommand oCmd = new SqlCommand(sSQL, oConn))
                {
                    oCmd.ExecuteNonQuery();
                    oConn.Close();
                }
            }
        }
        public void Gravar(int ID)
        {
            using (SqlConnection oConn = new SqlConnection(strConexao))
            {
                using (SqlCommand oCmd = new SqlCommand(((ID == 0) ? strINSERT : strUPDATE), oConn))
                {
                    oCmd.Parameters.AddWithValue("@Nome", ClienteNome);
                    oCmd.Parameters.AddWithValue("@Sobrenome", ClienteSobrenome);
                    oCmd.Parameters.AddWithValue("@Sexo", ClienteSexo);
                    oCmd.Parameters.AddWithValue("@Email", ClienteEmail);
                    oCmd.Parameters.AddWithValue("@Telefone", ClienteTelefone);
                    oCmd.Parameters.AddWithValue("@Senha", ClienteSenha);

                    if (ID != 0)
                    {
                        oCmd.Parameters.AddWithValue("@ID", ID);
                    }

                    oConn.Open();
                    oCmd.ExecuteNonQuery();
                    oConn.Close();

                }
            }
        }
        public DataTable Listar()
        {

            DataTable dtRet = new DataTable();

            using (SqlConnection oConnection = new SqlConnection(strConexao))
            {
                using (SqlCommand oCommand = new SqlCommand(strSELECT, oConnection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(oCommand);

                    oConnection.Open();
                    da.Fill(dtRet);
                    oConnection.Close();
                }
            }
            return dtRet;
        }
    }
}
