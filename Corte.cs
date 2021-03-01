using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public class Corte
    {
        public string nome;
        public string valor;
        public Corte(string corte, string valor){
            this.nome = corte;
            this.valor  = valor;
        }
    }
}
