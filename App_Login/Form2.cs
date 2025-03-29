using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //codigo para acessar novos formularios
        private void btAcesso_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String password = "admin";

            if (txtUsuario.Text == user & txtSenha.Text == password)
            {
                MessageBox.Show("Acesso Liberado!");
                FrmAcesso FrmAcesso = new FrmAcesso();
                FrmAcesso.Show();
                this.Hide();

            }


        }
    }
}
