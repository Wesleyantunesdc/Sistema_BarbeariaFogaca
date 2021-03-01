using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()//Conexao com o Banco
        {
            conexao = new SQLiteConnection("Data Source = "+Global.caminhoBanco+Global.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static DataTable dql(string sql)//Data query Language (selects)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            try
            {
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                vcon.Close();
                throw ex;
            }
        }

        public static void dml(string sql, string msgOk = null, string msgErro = null)//Data manipulation language
        {
            
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
                throw ex;
            }
        }
    }
}
