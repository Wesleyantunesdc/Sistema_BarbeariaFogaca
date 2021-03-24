using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public partial class FormFinanceiro : Form
    {
        DateTime dataInicial;
        DateTime dataFinal;
        Decimal total = 0;
        Decimal prejuizo = 0;
        Decimal lucro = 0;

        string nomeCliente = "";
        int qtnProdutosVendidos = 0;
        public FormFinanceiro()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_Load(object sender, EventArgs e)
        {
            mtb_inicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            mtb_final.Text = monthCalendar1.SelectionEnd.ToShortDateString();
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
                    DataTable dt =  obterDadosFinanceiro(dataIni, dataFin);
                    dgv_financeiro.DataSource = dt;
                    dgv_financeiro.Columns[0].Width = 40;
                    dgv_financeiro.Columns[1].Width = 70;
                    dgv_financeiro.Columns[2].Width = 90;
                    dgv_financeiro.Columns[3].Width = 60;
                    dgv_financeiro.Columns[4].Width = 105;
                    dgv_financeiro.Columns[5].Width = 87;
                    dgv_financeiro.Columns[6].Width = 60;
                    dgv_financeiro.Columns[7].Width = 65;

                    int totalLinhas = dt.Rows.Count;
                    for(int i =0; i < totalLinhas; i++)
                    {
                        if(dt.Rows[i].Field<string>("Categoria").ToString() != "Despesa")
                        {
                            total += Convert.ToDecimal(dt.Rows[i].Field<string>("Valor").ToString());
                        }
                        else
                        {
                            prejuizo += Convert.ToDecimal(dt.Rows[i].Field<string>("Valor"));
                        }
                        
                    }
                   
                    lb_total.Text = "R$ " + total.ToString("F");
                    lb_saida.Text = "R$ " + prejuizo.ToString("F");
                    lb_lucro.Text = "R$ " + (total - prejuizo).ToString("F");

                    this.total = 0;
                    this.prejuizo = 0;
                    this.lucro = 0;
                }

            }
            else
            {
                MessageBox.Show(dataInicial + "/" + dataFinal);
                DialogResult res = MessageBox.Show("A data de inicio tem que ser antes ou igual a data de fim.", "Erro (Datas invalidas)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Obter todos os dados do financeiro
        private DataTable obterDadosFinanceiro(string dataIni, string dataFin)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = String.Format(@"SELECT N_IDFINANCEIRO as 'ID', D_DATA as 'Data', T_BARBEIRO as 'Barbeiro',T_CATEGORIA as 'Categoria', T_CLIENTE as 'Cliente', T_DESCRICAO as 'Descrição', D_VALOR as 'Valor', T_TIPOPAGAMENTO as 'Pagamento'
                FROM tb_financeiro WHERE D_DATA BETWEEN '{0}' AND '{1}' ORDER BY D_DATA",dataIni,dataFin);
                dt = Banco.dql(sql);
                return dt;
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter dados!","Erro (Financeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
             
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            //A função não pode ser excluida
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            mtb_inicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            mtb_final.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            AtualizarDgv();
        }

        private void btn_verificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                AtualizarDgv();
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter dados, verifique os campos de data!","Erro (Datas)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Despesa_Click(object sender, EventArgs e)
        {
            FormDespesa formDespesa = new FormDespesa();
            formDespesa.ShowDialog();
            AtualizarDgv();
        }

        private void btn_adcionarServico_Click(object sender, EventArgs e)
        {
            FormServicos formServicos = new FormServicos();
            formServicos.ShowDialog();
            AtualizarDgv();
        }

        private void btn_adicionarvenda_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.ShowDialog();
            AtualizarDgv();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_financeiro.SelectedRows.Count > 0)
            {
                string id = dgv_financeiro.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show("Deseja excluir o item[" + id + "] selecionado ?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {
                    this.nomeCliente = dgv_financeiro.SelectedRows[0].Cells[4].Value.ToString();
                    string sql = "Delete from tb_financeiro WHERE N_IDFINANCEIRO = " + id;
                    RestaurarDados(id);
                    Banco.dml(sql);
                    
                }
            }
            AtualizarDgv();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RestaurarDados(string id)
        {
            try
            {
                string sql = "SELECT * FROM tb_financeiro WHERE N_IDFINANCEIRO = "+id;
                DataTable dt = Banco.dql(sql);

                string categoria = dt.Rows[0].Field<string>("T_CATEGORIA");
                this.nomeCliente = dt.Rows[0].Field<string>("T_CLIENTE");
                string nomeProduto = dt.Rows[0].Field<string>("T_DESCRICAO");
                

                if (categoria == "Serviço")
                {
                    sql = "UPDATE tb_clientes SET N_QUANTIDADECORTES = N_QUANTIDADECORTES -1 WHERE T_NOMECLIENTE = '" + nomeCliente+"'";
                    Banco.dml(sql);
                }else if(categoria == "Venda")
                {
                    this.qtnProdutosVendidos = int.Parse(dt.Rows[0].Field<Int64>("N_QUANTIDADEVENDIDA").ToString());
                    sql = String.Format("UPDATE tb_produtos SET N_QUANTIDADE = N_QUANTIDADE + {0} WHERE T_NOMEPRODUTO = '{1}'", qtnProdutosVendidos,nomeProduto);
                    Banco.dml(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar dados!");
            }
            this.nomeCliente = "";
            this.qtnProdutosVendidos = 0;
        }

        private void btn_addEntrada_Click(object sender, EventArgs e)
        {
            FormAdicionarPagamento formAdicionarPagamento = new FormAdicionarPagamento();
            formAdicionarPagamento.ShowDialog();
            AtualizarDgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgv_financeiro.SelectedRows.Count > 0)
            {
                Financeiro f = new Financeiro();
                f.id = int.Parse(dgv_financeiro.SelectedRows[0].Cells[0].Value.ToString());
                f.barbeiro = dgv_financeiro.SelectedRows[0].Cells[2].Value.ToString();
                f.cliente = dgv_financeiro.SelectedRows[0].Cells[4].Value.ToString();
                f.descricao = dgv_financeiro.SelectedRows[0].Cells[5].Value.ToString();
                f.valor = Decimal.Parse(dgv_financeiro.SelectedRows[0].Cells[6].Value.ToString());
                f.data = dgv_financeiro.SelectedRows[0].Cells[1].Value.ToString();
                f.tipoPagamento = dgv_financeiro.SelectedRows[0].Cells[7].Value.ToString();
                FormEdicaoFinanceiro edicaoFinanceiro = new FormEdicaoFinanceiro(f);
                edicaoFinanceiro.ShowDialog();
            }
            else
            {
                DialogResult res = MessageBox.Show("É necessario selecionar o item a ser alterado","Erro ao selecionar Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
