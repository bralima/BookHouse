using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Livraria
{
    class CadastroLugar
    {
        public int EnderecoID { get; set; }
        public string UsuarioEndereco { get; set; }
        public string UsuarioCidade { get; set; }
        public string UsuarioEstado { get; set; }

        readonly string strConexao = @"Server=localhost;Database=master;Trusted_Connection=True;";

        private const string strINSERT = "INSERT INTO tb_Endereco (Endereco, Cidade, Estado) " +
                                         "VALUES(@Endereco, @Cidade, @Estado); ";

        private const string strSELECT = "SELECT * FROM tb_Endereco; ";

        private const string strDELETE = "DELETE FROM tb_Endereco WHERE ID = @ID";

        public const string strUPDATE = "UPDATE tb_Endereco SET Endereco = @Endereco, Cidade = @Cidade, Estado = @Estado WHERE ID=@ID ";

        public CadastroLugar()
        {

            using (SqlConnection oConn = new SqlConnection(strConexao))
            {
                string sSQL = " IF OBJECT_ID(N'dbo.tb_Endereco', N'U') IS NULL   " +
                                "   CREATE TABLE dbo.tb_Endereco(                " +
                                "       ID      int identity primary key,       " +
                                "       Endereco    varchar(50),                    " +
                                "       Cidade    varchar(20),                    " +
                                "       Estado    varchar(100),                    " +
                                "   )";
                oConn.Open();
                using (SqlCommand oCmd = new SqlCommand(sSQL, oConn))
                {
                    oCmd.ExecuteNonQuery();
                    oConn.Close();
                }
            }

        }

        public void ResetarBaseDados()
        {
            using (SqlConnection oConn = new SqlConnection(strConexao))
            {
                string sSQL = " IF OBJECT_ID(N'dbo.tb_Endereco', N'U') IS NOT NULL   " +
                                "   DROP TABLE dbo.tb_Endereco ";
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
                    oCmd.Parameters.AddWithValue("@Endereco", UsuarioEndereco);
                    oCmd.Parameters.AddWithValue("@Cidade", UsuarioCidade);
                    oCmd.Parameters.AddWithValue("@Estado", UsuarioEstado);

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

        public void Excluir(int nID)
        {
            using (SqlConnection oConnection = new SqlConnection(strConexao))
            {
                using (SqlCommand oCommand = new SqlCommand(strDELETE, oConnection))
                {
                    oCommand.Parameters.AddWithValue("@ID", nID);

                    oConnection.Open();
                    oCommand.ExecuteNonQuery();
                    oConnection.Close();
                }
            }

        }
    }
}
