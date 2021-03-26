using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public class Util
    {
        public static int idBarberio = 0;
        public static string nomeBarbeiro = "";
        public static string formatarValor(string valorDescrito)
        {

            string ValorPreFormatado = valorDescrito.Trim();
            
            if (ValorPreFormatado.Contains(','))
            {
                return ValorPreFormatado.Replace(',', '.');
            }
            else
            {
                return valorDescrito;
            }

        }

        public static Decimal AtriburirDesconto(string valorInicial, string desconto)
        {
            try
            {
                Decimal value = Convert.ToDecimal(valorInicial);
                Decimal desc= Convert.ToDecimal(desconto.Replace('.',','));
                if(desc <= value){

                    return  value - desc;
                    
                }
                else
                {
                    MessageBox.Show("Erro ao dar desconto, o valor de desconto não pode ser maior que o valor inicial!");
                    return 0;
                }
            }catch (Exception)
            {
                MessageBox.Show("Erro ao dar desconto, verifique a formatação do campo de desconto!");
                return 0;
            }
        }

        public static void zerarVariaveisServico()
        {
            VariaveisServico.idCorte = 0;
            VariaveisServico.idCliente = 0;
            VariaveisServico.nomeCliente = "";
            VariaveisServico.total = 0;
            VariaveisServico.pagamento = "";
            VariaveisServico.dataServico = "";
        }

        public static void zerarVariaveisVenda()
        {
            VariaveisVenda.idProduto = 0;
            VariaveisVenda.idCliente = 0;
            VariaveisVenda.nomeProduto = "";
            VariaveisVenda.preco = 0;
            VariaveisVenda.quantidadeDisponivel = 0;
            VariaveisVenda.dataVenda = "";
            VariaveisVenda.pagamento = "Outros";
            VariaveisVenda.total = 0;
        }

        public static void zerarVariaveisEntrada()
        {
            VariaveisEntrada.cliente = "Escolha o cliente...";
            VariaveisEntrada.data = "";
            VariaveisEntrada.descricao = "";
            VariaveisEntrada.tipoPagamento = "Dinheiro";
            VariaveisEntrada.valor = 0;
        }

        public static string FormatarInsercaoData(string data)
        {
            try
            {
                string dia = data.Substring(0, 2);
                string mes = data.Substring(3, 2);
                string ano = data.Substring(6, 4);
                return String.Format(ano + "-" + mes + "-" + dia);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao formatar data!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }


        public static string formatarExibicaoData(string data)
        {
            try
            {
                if(data.IndexOf('/')== 4 || data.IndexOf('-') == 4)
                {
                    string ano = data.Substring(0, 4);
                    string mes = data.Substring(5, 2);
                    string dia = data.Substring(8, 2);
                    return String.Format(dia + "-" + mes + "-" + ano);
                }
                else
                {
                    string dia = data.Substring(0, 2);
                    string mes = data.Substring(3, 2);
                    string ano = data.Substring(6, 4);
                    return String.Format(dia + "/" + mes + "/" + ano);
                }
                
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao formatar data!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

    }

}
