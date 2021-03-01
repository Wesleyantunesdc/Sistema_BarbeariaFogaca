using System;
using System.Collections;
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
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            InitializeComponent();
            tb_nomeBarbeiro.Text = Util.nomeBarbeiro;
            PopularComboBoxCortes();
            PopularTextBoxValores();
            ZerarCampos();
        }
        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FormSelecaoCliente formSelecao = new FormSelecaoCliente();
            formSelecao.ShowDialog();
            tb_cliente.Text = VariaveisServico.nomeCliente;
        }

        private void btn_incluirServico_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                //VariaveisServico.idCorte = ObterIdCorte(cb_cortes.Text);
                VariaveisServico.pagamento = cb_pagamentos.Text;

                DialogResult res = MessageBox.Show("Deseja confirmar o seguinte serviço?\n" +"Data: "+VariaveisServico.dataServico+
                    "\nCliente: " + tb_cliente.Text + "\n" + "Corte: " + cb_cortes.Text + "\n" + "Valor da Serviço: R$ " + VariaveisServico.total + "\n"+"Pagamento no ("+VariaveisServico.pagamento+")\n",
                    "Confirmação do Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    incluirServico();
                    AdicionarCorte();
                    Util.zerarVariaveisServico();
                }
            
                ZerarCampos();
            }
        }


        private void cb_cortes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopularTextBoxValores();
            cb_cortes.DisplayMember = "T_NOMECORTE";
            cb_cortes.ValueMember = "N_IDCORTE";
        }

        private void cb_cortes_Click(object sender, EventArgs e)
        {
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            tb_desconto.Text = "0";
            cb_pagamentos.Text = "Dinheiro";
            tb_cliente.Text = "Escolha o cliente...";
        }
        //Metodos para popular os campos

        public void PopularComboBoxCortes()
        {
            DataTable dt = ObterCortes();
            cb_cortes.DataSource = dt;
            cb_cortes.DisplayMember = "T_NOMECORTE";
            cb_cortes.ValueMember = "N_IDCORTE";
      
        }
        public void PopularTextBoxValores()
        {
            string id = cb_cortes.SelectedValue.ToString();
            DataTable dt = ObterValores(id);
            tb_valor.Text = dt.Rows[0].Field<double>("D_VALOR").ToString();
            tb_valorEscrito.Text = "R$ "+dt.Rows[0].Field<double>("D_VALOR").ToString();
        }
        /// /////////////////////////////////////////////////////////////////////////////////////


        //Metodos sql
        public DataTable ObterCortes()
        {
            DataTable dt = new DataTable();
            string sql = "Select N_IDCORTE,T_NOMECORTE from tb_cortes ORDER BY T_NOMECORTE";
            dt = Banco.dql(sql);
            return dt;
        }

        /* Devido a pedidos do cliente, não se faz necessario gravar pelo id do corte, simplesmente grava oque tiver no campo de corte
        /*
        public int ObterIdCorte(string corte)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "Select N_IDCORTE FROM tb_cortes WHERE T_NOMECORTE = '" + corte.Trim() + "'";
                dt = Banco.dql(sql);
                int ID = int.Parse(dt.Rows[0].Field<Int64>("N_IDCORTE").ToString());
                return ID;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao obter id do corte, selecione cortes dentro dos valores possiveis!");
                return 0;
            }
        }*/

        private DataTable ObterValores(string id)
        {
            DataTable dt = new DataTable();
            string sql = "select D_VALOR FROM tb_cortes WHERE N_IDCORTE = " + id;
            return dt = Banco.dql(sql);
        }

        private void incluirServico()
        {
            try
            {
                string sql = String.Format(@"INSERT INTO tb_financeiro(T_BARBEIRO,T_CLIENTE,T_CATEGORIA,D_VALOR,T_TIPOPAGAMENTO,D_DATA, T_DESCRICAO) 
                VALUES ('{0}','{1}','Serviço','{2}','{3}','{4}','{5}')",tb_nomeBarbeiro.Text,tb_cliente.Text, VariaveisServico.total, VariaveisServico.pagamento, Util.FormatarInsercaoData(VariaveisServico.dataServico), cb_cortes.Text);
                Banco.dml(sql);
            }catch( Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir serviço", "Erro (Serviço)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AdicionarCorte()
        {
            try
            {
                string sql = "UPDATE tb_clientes SET N_QUANTIDADECORTES = N_QUANTIDADECORTES + 1 WHERE N_IDCLIENTE = " +VariaveisServico.idCliente;
                Banco.dml(sql);
            }
            catch
            {
                DialogResult res = MessageBox.Show("Erro ao relacionar o cliente com o corte!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarFormulario()
        {
            VariaveisServico.dataServico = monthCalendar1.SelectionStart.ToShortDateString();

            //Validando barbeiro responsavel
            if (VariaveisVenda.idBarbeiro == 0)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir barbeiro responsavel!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //validadno Forma de pagamento
            bool possui = false;
            int quantidadePagamento = cb_pagamentos.Items.Count;
            for (int i = 0; i < quantidadePagamento; i++)
            {
                if (cb_pagamentos.Text == cb_pagamentos.Items[i].ToString())
                {
                    possui = true;
                }
            }
            if (!possui)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir forma de pagamento!", "Erro (Pagamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            //Validando corte
            bool verific = false;

            if (cb_cortes.Text=="")
            {
                DialogResult res = MessageBox.Show("Erro ao inserir tipo de corte!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //Validadno o cliente
            if (tb_cliente.Text == "Escolha o cliente..." || tb_cliente.Text == "")
            {
                DialogResult res = MessageBox.Show("Selecione o cliente de forma correta!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Validadndo data
            if (VariaveisServico.dataServico != "")
            {
                DateTime dataVenda = Convert.ToDateTime(VariaveisServico.dataServico);

                if (dataVenda.Date.CompareTo(DateTime.Today) > 0)
                {
                    DialogResult res = MessageBox.Show("A data selecionada tem que ser a atual ou passada!", "Erro (Data)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao setar data!", "Erro (Data)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //
            if (!SetarValorFinal())
            {
                return false;
            }
            return true;
        }

        private bool SetarValorFinal()
        {
            try
            {
                Decimal valorCorte = Convert.ToDecimal(tb_valor.Text.ToString());
                Decimal ValorDesconto = Convert.ToDecimal(tb_desconto.Text.Replace('.', ','));

                VariaveisServico.total = valorCorte - ValorDesconto;
                return true;
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao converter Valor!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ZerarCampos()
        {
            cb_cortes.Text = "";
            tb_valor.Text = "";
            cb_pagamentos.Text = "Dinheiro";
            tb_cliente.Text = "Escolha o cliente...";
            tb_desconto.Text = "0";
            tb_valorEscrito.Text = "R$ 0";
        }

        private void FormServicos_Load(object sender, EventArgs e)
        {
            VariaveisServico.dataServico = monthCalendar1.SelectionStart.ToShortDateString();
            ZerarCampos();
        }

        private List<string> ObterTodosOsCortes()
        {

            DataTable dt = new DataTable();
            List<string> listaCortes = new List<string>();
            listaCortes.Clear();
            try
            {
                string sql = "SELECT T_NOMECORTE FROM tb_cortes";
                dt = Banco.dql(sql);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    listaCortes.Add(dt.Rows[i].Field<string>("T_NOMECORTE"));
                }
                return listaCortes;
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao converter Valor!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_valor_KeyUp(object sender, KeyEventArgs e)
        {
            tb_valorEscrito.Text = "R$ "+ tb_valor.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
