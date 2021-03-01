using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaFogaca
{
    public class VariaveisServico
    {
        public static int idBarbeiro = Util.idBarberio;
        public static int idCorte = 0;
        public static int idCliente = 0;
        public static string nomeCliente = "";
        public static decimal total = 0;
        public static string pagamento = "";
        public static string dataServico = "";
        public static List<string> cortes = new List<string>();
    }
}
