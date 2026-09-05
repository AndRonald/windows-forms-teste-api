namespace Departamentos_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUrl = new Label();
            txtUrl = new TextBox();
            dgvDados = new DataGridView();
            btnDepartamentos = new Button();
            btnDepartamentoPorId = new Button();
            btnAtualizaDepartamento = new Button();
            btnExcluirDepartamento = new Button();
            btnIncluirDepartamento = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(12, 21);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 0;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(56, 18);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(434, 23);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "https://localhost:7145/api/departamentos";
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 71);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(478, 309);
            dgvDados.TabIndex = 2;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.BackColor = Color.Yellow;
            btnDepartamentos.Location = new Point(12, 396);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(94, 23);
            btnDepartamentos.TabIndex = 3;
            btnDepartamentos.Text = "Departamentos";
            btnDepartamentos.UseVisualStyleBackColor = false;
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // btnDepartamentoPorId
            // 
            btnDepartamentoPorId.BackColor = Color.FromArgb(128, 128, 255);
            btnDepartamentoPorId.Location = new Point(168, 396);
            btnDepartamentoPorId.Name = "btnDepartamentoPorId";
            btnDepartamentoPorId.Size = new Size(75, 23);
            btnDepartamentoPorId.TabIndex = 4;
            btnDepartamentoPorId.Text = "PorId";
            btnDepartamentoPorId.UseVisualStyleBackColor = false;
            btnDepartamentoPorId.Click += btnDepartamentoPorId_Click;
            // 
            // btnAtualizaDepartamento
            // 
            btnAtualizaDepartamento.BackColor = Color.Lime;
            btnAtualizaDepartamento.Location = new Point(330, 396);
            btnAtualizaDepartamento.Name = "btnAtualizaDepartamento";
            btnAtualizaDepartamento.Size = new Size(75, 23);
            btnAtualizaDepartamento.TabIndex = 5;
            btnAtualizaDepartamento.Text = "Atualiza";
            btnAtualizaDepartamento.UseVisualStyleBackColor = false;
            btnAtualizaDepartamento.Click += btnAtualizaDepartamento_Click;
            // 
            // btnExcluirDepartamento
            // 
            btnExcluirDepartamento.BackColor = Color.Red;
            btnExcluirDepartamento.Location = new Point(411, 396);
            btnExcluirDepartamento.Name = "btnExcluirDepartamento";
            btnExcluirDepartamento.Size = new Size(75, 23);
            btnExcluirDepartamento.TabIndex = 6;
            btnExcluirDepartamento.Text = "Excluir";
            btnExcluirDepartamento.UseVisualStyleBackColor = false;
            btnExcluirDepartamento.Click += btnExcluirDepartamento_Click;
            // 
            // btnIncluirDepartamento
            // 
            btnIncluirDepartamento.BackColor = Color.FromArgb(255, 192, 128);
            btnIncluirDepartamento.Location = new Point(249, 396);
            btnIncluirDepartamento.Name = "btnIncluirDepartamento";
            btnIncluirDepartamento.Size = new Size(75, 23);
            btnIncluirDepartamento.TabIndex = 7;
            btnIncluirDepartamento.Text = "Incluir";
            btnIncluirDepartamento.UseVisualStyleBackColor = false;
            btnIncluirDepartamento.Click += btnIncluirDepartamento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(502, 440);
            Controls.Add(btnIncluirDepartamento);
            Controls.Add(btnExcluirDepartamento);
            Controls.Add(btnAtualizaDepartamento);
            Controls.Add(btnDepartamentoPorId);
            Controls.Add(btnDepartamentos);
            Controls.Add(dgvDados);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Name = "Form1";
            Text = "Gerenciamento de Departamentos";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrl;
        private TextBox txtUrl;
        private DataGridView dgvDados;
        private Button btnDepartamentos;
        private Button btnDepartamentoPorId;
        private Button btnAtualizaDepartamento;
        private Button btnExcluirDepartamento;
        private Button btnIncluirDepartamento;
    }
}
