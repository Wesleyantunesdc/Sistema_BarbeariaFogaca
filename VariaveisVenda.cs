using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaFogaca
{
    class VariaveisVenda
    {
        public static int idBarbeiro = Util.idBarberio;
        public static int idProduto = 0;
        public static int idCliente = 0;
        public static string nomeProduto = "";
        public static decimal preco = 0;
        public static int quantidadeDisponivel = 0;
        public static string dataVenda = "";
        public static string pagamento = "Outros";
        public static decimal total = 0;
    }
}
