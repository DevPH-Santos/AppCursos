using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCurso.Controller;

namespace AppCursos.UI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        Curso curso = new Curso();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            txtCurso.Text = null;
            txtLink.Text = null;
            cmbStatus.SelectedItem = null;

            this.Close();
            dashboard.Show();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            string nome = txtCurso.Text;
            string link = txtLink.Text;
            string status = cmbStatus.Text;

            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(link) || string.IsNullOrEmpty(status)){
                MessageBox.Show("Preencha os campos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool cursoCadastrado = curso.CadastrarCurso(nome, link, status);

                if (cursoCadastrado)
                {
                    MessageBox.Show("Cadastrou!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurso.Clear();
                    txtLink.Clear();
                    cmbStatus.SelectedItem= null;

                    Dashboard dashboard = new Dashboard();
                    this.Close();
                    dashboard.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
