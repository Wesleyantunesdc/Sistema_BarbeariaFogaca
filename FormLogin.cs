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
  
    public partial class FormLogin : Form
    {
        Form1 formularioPrincipal;
        public FormLogin(Form1 f)
        {
            InitializeComponent();
            formularioPrincipal = f;
            tb_usuario.Focus();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }


        private void Entrar()
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;
            int idBarbeiro = 0;
            if (usuario == "")
            {
                DialogResult res = MessageBox.Show("Nome do usuario não foi preenchido!", "Erro (Usuario)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_usuario.Focus();
                return;
            }
            else if (senha == "")
            {
                DialogResult res = MessageBox.Show("A Senha não foi inserida!", "Erro (Senha)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_senha.Focus();
                return;
            }
            string vquey = String.Format(@"Select *From tb_barbeiros WHERE T_USUARIO = '{0}' and T_SENHA = '{1}'", tb_usuario.Text, tb_senha.Text);
            DataTable dt = Banco.dql(vquey);
            if (dt.Rows.Count == 1)
            {
                formularioPrincipal.lb_acesso.Text = dt.Rows[0].ItemArray[4].ToString();
                formularioPrincipal.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_USUARIO");
                formularioPrincipal.pb_logado.Image = Properties.Resources.AcessoLiberadoImg;
                Global.nivel = int.Parse((dt.Rows[0].Field<Int64>("N_NIVEL").ToString()));
                Global.logado = true;
                Util.idBarberio = int.Parse(dt.Rows[0].Field<Int64>("N_IDBARBEIRO").ToString());
                Util.nomeBarbeiro = dt.Rows[0].Field<string>("T_NOMEBARBEIRO");
                this.Close();
            }
            else
            {
                DialogResult res = MessageBox.Show("Usuario ou senha estão incorreto(s)", "Erro (Usuario)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
