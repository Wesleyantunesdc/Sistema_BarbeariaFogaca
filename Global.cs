 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaFogaca
{
    public class Global
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_barbearia.db";
        public static string caminhoBanco = caminho + @"\banco\";
    }
}
