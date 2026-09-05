using Departamentos_WF.Model;
using Departamentos_WF.Service;

namespace Departamentos_WF
{
    public partial class Initial : Form
    {
        private AcessaAPIService? _apiService;
        public Initial()
        {
            InitializeComponent();
            InitializeApiService();
        }

        private void InitializeApiService()
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
                _apiService = new AcessaAPIService(txtUrl.Text);
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            InitializeApiService();
        }

        private bool VerificarApiService()
        {
            if (_apiService == null)
            {
                MessageBox.Show("Por favor, informe a URL base da API no campo correspondente.",
                                "API não configurada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private void FormatarGridDepartamento()
        {
            if (dgvDados.DataSource != null && dgvDados.Columns.Contains("DepartamentoId"))
            {
                var colId = dgvDados.Columns["DepartamentoId"];
                colId!.Width = 100;
            }
        }

        private async void btnDepartamentos_Click(object sender, EventArgs e)
        {
            if (!VerificarApiService()) return;
            try
            {
                List<Departamento> departamentos = await _apiService!.GetAllDepartamentos();
                dgvDados.DataSource = departamentos;
                FormatarGridDepartamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: " + ex.Message);
            }
        }

        private async void btnDepartamentoPorId_Click(object sender, EventArgs e)
        {
            if (!VerificarApiService()) return;
            if (InputBox(out int codigoDepartamento))
            {
                try
                {
                    Departamento? departamento = await _apiService!.GetDepartamentoById(codigoDepartamento);

                    if (departamento != null)
                    {
                        dgvDados.DataSource = new List<Departamento> { departamento };
                        FormatarGridDepartamento();
                    }
                    else
                    {
                        MessageBox.Show($"Departamento com código {codigoDepartamento} não encontrado");
                        btnDepartamentoPorId.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: " + ex.Message);
                }
            }
        }

        private async void btnIncluirDepartamento_Click(object sender, EventArgs e)
        {
            if (!VerificarApiService()) return;
            try
            {
                var novoDepartamento = new Departamento
                {
                    Nome = "Depto" + DateTime.Now.Ticks,
                    Descricao = "Departamento teste criado via WinForms",
                    Criacao = DateTime.Now
                };

                await _apiService!.AddDepartamento(novoDepartamento);

                MessageBox.Show($"Departamento '{novoDepartamento.Nome}' incluído com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                btnDepartamentos.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void btnAtualizaDepartamento_Click(object sender, EventArgs e)
        {
            if (InputBox(out int codigoDepartamento))
            {
                try
                {
                    var departamentoAtualizado = new Departamento
                    {
                        Id = codigoDepartamento,
                        Nome = "Depto Alterado" + DateTime.Now.ToLongTimeString(),
                        Descricao = "Descrição atualizada via WinForms"
                    };

                    await _apiService!.UpdateDepartamento(codigoDepartamento, departamentoAtualizado);

                    MessageBox.Show($"Departamento com ID {codigoDepartamento} foi atualizado com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    btnDepartamentos.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async void btnExcluirDepartamento_Click(object sender, EventArgs e)
        {
            if (!VerificarApiService()) return;

            if (InputBox(out int codigoDepartamento))
            {
                try
                {
                    await _apiService!.DeleteDepartamento(codigoDepartamento);
                    MessageBox.Show("Departamento excluído com sucesso!");
                    btnDepartamentos.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro" + ex.Message);
                }
            }
        }

        private bool InputBox(out int codigo)
        {
            string resultado = Microsoft.VisualBasic.Interaction.
                               InputBox("Informe o código do Departamento.", "Input", "1");

            if (int.TryParse(resultado, out codigo))
            {
                return true;
            }

            codigo = -1;
            return false;
        }

        private void btnIncluirFuncionario_Click(object sender, EventArgs e)
        {
            var incluirFuncionarioForm = new Forms.Funcionarios.IncluirFuncionario();
            incluirFuncionarioForm.ShowDialog();
        }
    }
}
