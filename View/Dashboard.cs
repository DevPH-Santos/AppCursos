using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCurso.Controller;
using System.Windows.Forms;

namespace AppCursos.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            // No construtor do formulário ou em InitializeComponent()

        }

        Curso curso = new Curso();

        private void btnAddCurso_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();
        }

        #region ListarCursos

        private void ListarCursos()
        {
            try
            {
                dataGridCursos.Rows.Clear();
                DataTable cursos = curso.ListarCursos();

                foreach (DataRow row in cursos.Rows)
                {
                    dataGridCursos.Rows.Add(
                        row["pk_id_curso"],
                        row["nome_curso"],
                        row["link_curso"],
                        row["status_curso"]
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cursos" + ex.Message);
            }
        }

        #endregion

        #region DeletarCurso

        private void ApagarCurso(int pk, DataGridViewRow row)
        {
            DialogResult result = MessageBox.Show("Deletar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool sucesso = curso.DeletarCurso(pk);

                if (sucesso)
                {
                    dataGridCursos.Rows.Remove(row);
                    MessageBox.Show("Deletado!");
                }
                else
                {
                    MessageBox.Show("Erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ListarCursos();
        }

        private void dataGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCursos.Columns["link_curso"].Index && e.RowIndex >= 0)
            {
                string link = dataGridCursos.Rows[e.RowIndex].Cells["link_curso"].Value.ToString();

                try
                {
                    // Se o link não tiver http:// ou https://, adiciona automaticamente
                    if (!link.StartsWith("http://") && !link.StartsWith("https://"))
                    {
                        link = "https://" + link;
                    }

                    // Abre o link no navegador padrão
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o link: " + ex.Message);
                }
            }

            if (e.ColumnIndex == dataGridCursos.Columns["Acao"].Index && e.RowIndex >= 0)
            {
                int pk = Convert.ToInt32(dataGridCursos.Rows[e.RowIndex].Cells["pk_id_curso"].Value);
                DataGridViewRow row = dataGridCursos.Rows[e.RowIndex];
                ApagarCurso(pk, row);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListarCursos();
        }
    }
}
