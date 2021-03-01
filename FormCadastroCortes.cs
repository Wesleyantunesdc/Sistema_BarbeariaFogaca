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
    public partial class FormCadastroCortes : Form
    {
        public FormCadastroCortes()
        {
            InitializeComponent();
            tb_novo.Focus();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(tb_novo.Text == ""||tb_valor.Text =="")
            {
                DialogResult res = MessageBox.Show("Erro ao cadastrar corte!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nomeCorte = tb_novo.Text;
                String valor = Util.formatarValor(tb_valor.Text);
                Corte corte = new Corte(nomeCorte,valor);
                CadastrarCorte(corte);
                Limpar();

            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            tb_novo.Text = "";
            tb_valor.Text = "";
            tb_novo.Focus();
        }
        //Metodos comuns

        //Metodos sql
        public void CadastrarCorte(Corte corte)
        {
            try
            {
                string vquery = String.Format(@"INSERT INTO tb_cortes(T_NOMECORTE,D_VALOR) VALUES ('{0}',{1})", corte.nome, corte.valor);
                Banco.dml(vquery);
                MessageBox.Show("Novo corte cadastrado com sucesso!");
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao cadastrar corte, verifique o campo 'VALOR'!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
