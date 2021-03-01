using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public partial class FormFinanceiroContador : Form
    {
        DateTime dataInicial;
        DateTime dataFinal;
        Decimal bruto = 0;
        Decimal desconto = 0;
        Decimal liquido = 0;

        public FormFinanceiroContador()
        {
            InitializeComponent();
            mtb_inicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            mtb_final.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            AtualizarDgv();
            tb_acrescimo.Text = "0";
            tb_desconto.Text = "0";
        }


        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dataInicial = Convert.ToDateTime(mtb_inicial.Text);
            dataFinal = Convert.ToDateTime(mtb_final.Text);
            if (dataInicial.CompareTo(dataFinal) <= 0)
            {
                string dataIni = Util.FormatarInsercaoData(mtb_inicial.Text);
                string dataFin = Util.FormatarInsercaoData(mtb_final.Text);
                if (dataIni != "" && dataFin != "")
                {
                    DataTable dt = obterDadosFinanceiros();
                    dgv_financeiro.DataSource = dt;
                    dgv_financeiro.Columns[0].Width = 30;
                    dgv_financeiro.Columns[1].Width = 65;
                    dgv_financeiro.Columns[2].Width = 85;
                    dgv_financeiro.Columns[3].Width = 60;
                    dgv_financeiro.Columns[4].Width = 127;
                    dgv_financeiro.Columns[5].Width = 130;
                    dgv_financeiro.Columns[6].Width = 50;
                    dgv_financeiro.Columns[7].Width = 65;

                    int totalLinhas = dt.Rows.Count;
                    for (int i = 0; i < totalLinhas; i++)
                    {
                        if (dt.Rows[i].Field<string>("Categoria").ToString() != "Despesa")
                        {
                            bruto += Convert.ToDecimal(dt.Rows[i].Field<string>("Valor").ToString());
                        }
                        else
                        {
                            desconto += Convert.ToDecimal(dt.Rows[i].Field<string>("Valor"));
                        }

                    }
                    setarValoresCampos();

                    this.bruto = 0;
                    this.desconto = 0;
                    this.liquido = 0;
                }

            }
            else
            {
                MessageBox.Show(dataInicial + "/" + dataFinal);
                DialogResult res = MessageBox.Show("A data de inicio tem que ser antes ou igual a data de fim.", "Erro (Datas invalidas)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void setarValoresCampos()
        {
            tb_valorBruto.Text = "R$ " + bruto.ToString("F");
            tb_qtnCortes.Text = obterQuantidadeCortes().ToString();
            tb_totalCortes.Text = "R$ " + obterTotalCortes();
            tb_totalVendas.Text = "R$ " + obterTotalVendas();
            tb_totalOutros.Text = "R$ " + obterTotalOutros();
            lb_valorBruto.Text = "R$ " + bruto.ToString("F");
            lb_desconto.Text = "R$ " + desconto.ToString("F");
            lb_valorLiquido.Text = "R$ " + (bruto - desconto).ToString("F");
        }

        private int obterQuantidadeCortes()
        {
           int numeroLinhas = dgv_financeiro.RowCount;
            int totalCortes = 0;
            DataTable dt = (DataTable) dgv_financeiro.DataSource;
            for (int i=0; i < numeroLinhas; i++)
            {
                if (dt.Rows[i].Field<string>("Categoria") == "Serviço")
                {
                    totalCortes++;
                }
            }
            return totalCortes;
        }

        private String obterTotalCortes()
        {
            int numeroLinhas = dgv_financeiro.RowCount;
            Decimal totalCortes = 0;
            DataTable dt = (DataTable)dgv_financeiro.DataSource;
            for (int i = 0; i < numeroLinhas; i++)
            {
                if (dt.Rows[i].Field<string>("Categoria") == "Serviço")
                { 
                    totalCortes += Convert.ToDecimal(dt.Rows[i].Field<string>("valor"));
                }
            }
            return totalCortes.ToString("F");
        }

        private String obterTotalVendas()
        {
            int numeroLinhas = dgv_financeiro.RowCount;
            Decimal totalVendas = 0;
            DataTable dt = (DataTable)dgv_financeiro.DataSource;
            for (int i = 0; i < numeroLinhas; i++)
            {
                if (dt.Rows[i].Field<string>("Categoria") == "Venda")
                {
                    totalVendas += Convert.ToDecimal(dt.Rows[i].Field<string>("valor"));
                }
            }
            return totalVendas .ToString("F");
        }

        private String obterTotalOutros()
        {
            int numeroLinhas = dgv_financeiro.RowCount;
            Decimal totalOutros = 0;
            DataTable dt = (DataTable)dgv_financeiro.DataSource;
            for (int i = 0; i < numeroLinhas; i++)
            {
                if (dt.Rows[i].Field<string>("Categoria") != "Venda" && dt.Rows[i].Field<string>("Categoria") != "Serviço" && dt.Rows[i].Field<string>("Categoria") != "Despesa")
                {
                    totalOutros += Convert.ToDecimal(dt.Rows[i].Field<string>("valor"));
                }
            }
            return totalOutros.ToString("F");
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarDgv();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter dados, verifique os campos de data!", "Erro (Datas)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable obterDadosFinanceiros()
        {
            DataTable dt = new DataTable();
            try
            {
                string nome = tb_filtro.Text;
                string dataIni = Util.FormatarInsercaoData(mtb_inicial.Text);
                string dataFin = Util.FormatarInsercaoData(mtb_final.Text);
                string sql = String.Format(@"SELECT N_IDFINANCEIRO as 'ID', D_DATA as 'Data', T_BARBEIRO as 'Barbeiro', T_CATEGORIA as 'Categoria', T_CLIENTE as 'Cliente', T_DESCRICAO as 'Descrição'," +
                    " D_VALOR as 'Valor', T_TIPOPAGAMENTO as 'Pagamento'FROM tb_financeiro WHERE T_BARBEIRO LIKE '{0}%' AND D_DATA BETWEEN '{1}' AND '{2}' ORDER BY D_DATA", nome.Trim(),dataIni,dataFin);
               dt = Banco.dql(sql);
               return dt;
            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter dados!\nVerifique as datas", "Erro (Financeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
            
        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                mtb_inicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
                mtb_final.Text = monthCalendar1.SelectionEnd.ToShortDateString();
                AtualizarDgv();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter dados, verifique os campos de data!", "Erro (Datas)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            if (validarCamposCalculo())
            {
                realizarCalculo();
                zerarCampos();
            }
        }

        private bool validarCamposCalculo()
        {
            try
            {
                if (tb_acrescimo.Text == "")
                {
                    tb_acrescimo.Text = "0";
                }
                Convert.ToDecimal(tb_acrescimo.Text);
            }
            catch (Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao setar acrescimo, verifique o campo de acrescimo!", "Erro (campo invalido)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                if (tb_desconto.Text == "")
                {
                    tb_desconto.Text = "0";
                }
                Convert.ToDecimal(tb_desconto.Text);
            }
            catch (Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao setar desconto, verifique o campo de desconto!", "Erro (campo invalido)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToDecimal(tb_porcentagem.Text);
            }
            catch (Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao setar porcentagem, verifique o campo de porcentagem!", "Erro (campo invalido)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void realizarCalculo()
        {
            double porcentagem = Convert.ToDouble(tb_porcentagem.Text);
            double bruto = Convert.ToDouble(tb_valorBruto.Text.Replace("R$ ",""));
            double acrescimo = Convert.ToDouble(tb_acrescimo.Text);
            double desconto = Convert.ToDouble(tb_desconto.Text);
            bruto += acrescimo - desconto;

            double total = bruto * (porcentagem*0.01);

            DialogResult res = MessageBox.Show("Valor total: R$" + bruto.ToString("F") +
                "\nPorcentagem em cima do valor total: "+tb_porcentagem.Text +
                "%\nValor final:  R$ " + total.ToString("F") , 
                "Resultado do Calculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void zerarCampos()
        {
            tb_acrescimo.Text = "0";
            tb_desconto.Text = "0";
        }

        private void FinanceiroContador_Load(object sender, EventArgs e)
        {

        }

        private void mtb_inicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtb_final_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
