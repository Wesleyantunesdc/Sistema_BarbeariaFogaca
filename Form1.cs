using System;
using System.Windows.Forms;
using System.Data;

namespace BarbeariaFogaca
{
    public partial class Form1 : Form
    {
        private Agendamento agendamento;
        private DateTime horario = new DateTime();
        public Form1()
        {
            InitializeComponent();
            FormLogin telaLogin = new FormLogin(this);
            telaLogin.ShowDialog();
            atualizarDvg();
        }

        private void abreForm(int nivel, Form f)
        {
            if(Global.logado == true)
            {
                if(Global.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Acesso não permitido!", "Erro (Acesso)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("É necessario estar logado!", "Erro (Acesso)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void corteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin telaLogin = new FormLogin(this);
            telaLogin.ShowDialog();
            atualizarDvg();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "---";
            lb_nomeUsuario.Text = "---";
            pb_logado.Image = Properties.Resources.AcessoNegadoImg;
            Global.nivel = 0;
            Global.logado = false;
            atualizarDvg();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroBarbeiro telaCadastroBarbeiro = new FormCadastroBarbeiro();
            abreForm(2,telaCadastroBarbeiro);
        }

        private void dadosDoBarbeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarbeiro formBarbeiro = new FormBarbeiro();
            abreForm(2, formBarbeiro);
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            abreForm(1, formCadastroCliente);
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientecs formClientecs = new FormClientecs();
            abreForm(1,formClientecs);
        }

        private void novoCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCortes formCadastroCortes = new FormCadastroCortes();
            abreForm(1, formCadastroCortes);
        }

        private void alterarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCorte telaCorte = new FormCorte();
            abreForm(2, telaCorte);
        }

        private void adicionarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            abreForm(1,formCadastroProduto);
        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos formProduto = new FormProdutos();
            abreForm(1,formProduto);
        }

        private void adicionarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicos formServicos = new FormServicos();
            abreForm(1, formServicos);
        }

        private void adicionarVendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            abreForm(1, formVenda);
        }

        private void painelAdministrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinanceiro formFinanceiro = new FormFinanceiro();
            abreForm(2, formFinanceiro);
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void painelContadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinanceiroContador financeiroContador = new FormFinanceiroContador();
            abreForm(2, financeiroContador);
        }

        private void painelDeNiveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcinalidade em testes, será implementada na proxima versão!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Global.logado == true)
            {

                if (Global.nivel >= 1)
                {
                    FormAgendamentos telaAgendamentos = new FormAgendamentos();
                    telaAgendamentos.ShowDialog();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Acesso não permitido!", "Erro (Acesso)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("É necessario estar logado!", "Erro (Acesso)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizarDvg();
        }

        //Metodo para exclusão do agendamento
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(dgv_agendamentos.SelectedRows.Count > 0)
            {
                try
                {
                    string id = dgv_agendamentos.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = "Delete from tb_agendamentos where N_ID = "+ id;
                    Banco.dml(sql);
                }catch(Exception ex)
                {
                    DialogResult res = MessageBox.Show("Erro ao exclir agendamento!", "Erro(Deleção)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao selecionar linha para exclusão!", "Erro(Seleção da linha)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizarDvg();
        }

        //Metodo para alteração do agendamento
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Implementar o objeto com os campos dados pelo dgv;
            if (dgv_agendamentos.SelectedRows.Count > 0)
            {
                try
                {
                    this.agendamento = new Agendamento();
                    this.agendamento.id = int.Parse(dgv_agendamentos.SelectedRows[0].Cells[0].Value.ToString());
                    this.agendamento.data = DateTime.Parse(dgv_agendamentos.SelectedRows[0].Cells[1].Value.ToString());
                    this.agendamento.cliente = dgv_agendamentos.SelectedRows[0].Cells[2].Value.ToString();
                    this.agendamento.corte = dgv_agendamentos.SelectedRows[0].Cells[3].Value.ToString();
                    this.agendamento.valor = dgv_agendamentos.SelectedRows[0].Cells[4].Value.ToString();
                    FormAgendamentos telaAgendameto = new FormAgendamentos(this.agendamento);
                    telaAgendameto.ShowDialog();
                }
                catch (Exception ex)
                {
                    DialogResult res = MessageBox.Show("Erro ao selecionar linha para alteração!", "Erro(Seleção da linha)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao selecionar linha para alterar o agendamento!", "Erro(Seleção da linha)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizarDvg();
        }


        private void atualizarDvg()
        {
            if (Global.logado == true)
            {
                try
                {
                    string sql = String.Format("SELECT N_ID as 'ID', DT_DATA as 'Data'," +
                    "T_CLIENTE as 'Cliente', T_CORTE as 'Corte', T_VALOR as 'Valor'," +
                    "B_ATENDIDO as 'Status' FROM tb_agendamentos ORDER BY N_ID");
                    DataTable dt = Banco.dql(sql);
                    dgv_agendamentos.DataSource = dt;
                    dgv_agendamentos.Columns[0].Width = 40;
                    dgv_agendamentos.Columns[1].Width = 120;
                    dgv_agendamentos.Columns[2].Width = 170;
                    dgv_agendamentos.Columns[3].Width = 120;
                    dgv_agendamentos.Columns[4].Width = 50;
                    dgv_agendamentos.Columns[5].Width = 52;
                }
                catch (Exception ex)
                {
                    DialogResult res = MessageBox.Show("Erro ao recuperar agendamentos no banco!", "Erro(Agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgv_agendamentos.DataSource = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToLongTimeString();
            lb_horario.Text = hora;
        }
    }
}
