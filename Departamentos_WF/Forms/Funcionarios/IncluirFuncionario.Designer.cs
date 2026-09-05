namespace Departamentos_WF.Forms.Funcionarios
{
    partial class IncluirFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeFuncionario = new Label();
            cmbDepartamentoFuncionario = new ComboBox();
            txtNomeFuncionario = new TextBox();
            btnIncluirFuncionario = new Button();
            txtCargoFuncionario = new TextBox();
            lblCargoFuncionario = new Label();
            txtSalarioFuncionario = new TextBox();
            label1 = new Label();
            dtpDataFuncionario = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            lblNomeFuncionario.AutoSize = true;
            lblNomeFuncionario.Location = new Point(135, 9);
            lblNomeFuncionario.Name = "lblNomeFuncionario";
            lblNomeFuncionario.Size = new Size(40, 15);
            lblNomeFuncionario.TabIndex = 0;
            lblNomeFuncionario.Text = "Nome";
            // 
            // cmbDepartamentoFuncionario
            // 
            cmbDepartamentoFuncionario.FormattingEnabled = true;
            cmbDepartamentoFuncionario.Location = new Point(94, 275);
            cmbDepartamentoFuncionario.Name = "cmbDepartamentoFuncionario";
            cmbDepartamentoFuncionario.Size = new Size(121, 23);
            cmbDepartamentoFuncionario.TabIndex = 1;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(104, 36);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(100, 23);
            txtNomeFuncionario.TabIndex = 2;
            // 
            // btnIncluirFuncionario
            // 
            btnIncluirFuncionario.Location = new Point(116, 346);
            btnIncluirFuncionario.Name = "btnIncluirFuncionario";
            btnIncluirFuncionario.Size = new Size(75, 23);
            btnIncluirFuncionario.TabIndex = 3;
            btnIncluirFuncionario.Text = "Incluir";
            btnIncluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtCargoFuncionario
            // 
            txtCargoFuncionario.Location = new Point(104, 95);
            txtCargoFuncionario.Name = "txtCargoFuncionario";
            txtCargoFuncionario.Size = new Size(100, 23);
            txtCargoFuncionario.TabIndex = 5;
            txtCargoFuncionario.TextChanged += textBox1_TextChanged;
            // 
            // lblCargoFuncionario
            // 
            lblCargoFuncionario.AutoSize = true;
            lblCargoFuncionario.Location = new Point(135, 68);
            lblCargoFuncionario.Name = "lblCargoFuncionario";
            lblCargoFuncionario.Size = new Size(39, 15);
            lblCargoFuncionario.TabIndex = 4;
            lblCargoFuncionario.Text = "Cargo";
            // 
            // txtSalarioFuncionario
            // 
            txtSalarioFuncionario.Location = new Point(104, 158);
            txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            txtSalarioFuncionario.Size = new Size(100, 23);
            txtSalarioFuncionario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 131);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Salario";
            // 
            // dtpDataFuncionario
            // 
            dtpDataFuncionario.Location = new Point(59, 229);
            dtpDataFuncionario.Name = "dtpDataFuncionario";
            dtpDataFuncionario.Size = new Size(200, 23);
            dtpDataFuncionario.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 194);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 9;
            label2.Text = "Data Contratação";
            // 
            // IncluirFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(label2);
            Controls.Add(dtpDataFuncionario);
            Controls.Add(txtSalarioFuncionario);
            Controls.Add(label1);
            Controls.Add(txtCargoFuncionario);
            Controls.Add(lblCargoFuncionario);
            Controls.Add(btnIncluirFuncionario);
            Controls.Add(txtNomeFuncionario);
            Controls.Add(cmbDepartamentoFuncionario);
            Controls.Add(lblNomeFuncionario);
            Name = "IncluirFuncionario";
            Text = "IncluirFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeFuncionario;
        private ComboBox cmbDepartamentoFuncionario;
        private TextBox txtNomeFuncionario;
        private Button btnIncluirFuncionario;
        private TextBox txtCargoFuncionario;
        private Label lblCargoFuncionario;
        private TextBox txtSalarioFuncionario;
        private Label label1;
        private DateTimePicker dtpDataFuncionario;
        private Label label2;
    }
}