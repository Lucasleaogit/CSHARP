using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AgendaContatos
{
    public partial class Form1 : Form
    {
        int idSelecionado = 0;

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        // ===============================
        // DESAFIO 5 - EXIBIR DADOS
        // ===============================
        private void ExibirDados(string filtro = "")
        {
            using (MySqlConnection con = Conexao.Conectar())
            {
                string sql = "SELECT * FROM Contatos";

                if (!string.IsNullOrEmpty(filtro))
                {
                    sql += " WHERE nome LIKE @nome";
                }

                MySqlCommand cmd = new MySqlCommand(sql, con);

                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + filtro + "%");
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvContatos.DataSource = dt;
            }
        }

        // ===============================
        // DESAFIO 1 - VALIDAÇÃO
        // ===============================
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtCelular.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            idSelecionado = 0;
        }

        // ===============================
        // DESAFIO 2 - MENSAGEM SUCESSO/ERRO
        // ===============================
        private void AdicionarContato()
        {
            if (!ValidarCampos()) return;

            try
            {
                using (MySqlConnection con = Conexao.Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO Contatos (nome,endereco,celular,telefone,email) " +
                        "VALUES (@nome,@endereco,@celular,@telefone,@email)", con);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contato salvo com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ExibirDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        // ===============================
        // DESAFIO 3 - ATUALIZAR
        // ===============================
        private void AtualizarContato()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um contato para atualizar.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                using (MySqlConnection con = Conexao.Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE Contatos SET nome=@nome, endereco=@endereco, " +
                        "celular=@celular, telefone=@telefone, email=@email " +
                        "WHERE id=@id", con);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contato atualizado com sucesso!");
                ExibirDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        // ===============================
        // DESAFIO 4 - EXCLUIR
        // ===============================
        private void ExcluirContato()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um contato para excluir.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                using (MySqlConnection con = Conexao.Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM Contatos WHERE id=@id", con);

                    cmd.Parameters.AddWithValue("@id", idSelecionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contato removido!");
                ExibirDados();
                LimparCampos();
            }
        }

        // ===============================
        // DESAFIO 8 - MOSTRAR AO CLICAR
        // ===============================
        private void dgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContatos.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtEndereco.Text = row.Cells["endereco"].Value.ToString();
                txtCelular.Text = row.Cells["celular"].Value.ToString();
                txtTelefone.Text = row.Cells["telefone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        // ===============================
        // DESAFIO 6 - PESQUISA
        // ===============================
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados(txtPesquisa.Text);
        }

        // ===============================
        // EVENTOS DOS BOTÕES
        // ===============================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionarContato();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarContato();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirContato();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ExibirDados(txtPesquisa.Text);
        }
    }
}