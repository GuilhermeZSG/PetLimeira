namespace PetLimeira.Forms
{
    partial class TutorForm
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
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            txtTelefoneTutor2 = new TextBox();
            txtCelularTutor = new TextBox();
            txtCepTutor = new TextBox();
            txtCidadeTutor = new TextBox();
            txtBairroTutor = new TextBox();
            txtNumeroTutor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRuaTutor = new TextBox();
            txtCpfTutor = new TextBox();
            txtNomeTutor = new TextBox();
            dataGridView1 = new DataGridView();
            txtCampoBuscar = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtTelefoneTutor2);
            groupBox1.Controls.Add(txtCelularTutor);
            groupBox1.Controls.Add(txtCepTutor);
            groupBox1.Controls.Add(txtCidadeTutor);
            groupBox1.Controls.Add(txtBairroTutor);
            groupBox1.Controls.Add(txtNumeroTutor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRuaTutor);
            groupBox1.Controls.Add(txtCpfTutor);
            groupBox1.Controls.Add(txtNomeTutor);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(305, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Tutor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(175, 337);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(55, 20);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(118, 337);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(53, 20);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(50, 337);
            btnAtualizar.Margin = new Padding(2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(64, 20);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(4, 337);
            btnAdicionar.Margin = new Padding(2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(42, 20);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtTelefoneTutor2
            // 
            txtTelefoneTutor2.Location = new Point(6, 298);
            txtTelefoneTutor2.Margin = new Padding(2);
            txtTelefoneTutor2.Name = "txtTelefoneTutor2";
            txtTelefoneTutor2.PlaceholderText = "Numero do Telefone";
            txtTelefoneTutor2.Size = new Size(136, 23);
            txtTelefoneTutor2.TabIndex = 10;
            txtTelefoneTutor2.TextChanged += txtTelefoneTutor2_TextChanged;
            // 
            // txtCelularTutor
            // 
            txtCelularTutor.Location = new Point(6, 271);
            txtCelularTutor.Margin = new Padding(2);
            txtCelularTutor.Name = "txtCelularTutor";
            txtCelularTutor.PlaceholderText = "Numero do Celular";
            txtCelularTutor.Size = new Size(134, 23);
            txtCelularTutor.TabIndex = 9;
            // 
            // txtCepTutor
            // 
            txtCepTutor.Location = new Point(4, 181);
            txtCepTutor.Margin = new Padding(2);
            txtCepTutor.Name = "txtCepTutor";
            txtCepTutor.PlaceholderText = "CEP";
            txtCepTutor.Size = new Size(73, 23);
            txtCepTutor.TabIndex = 8;
            txtCepTutor.TextChanged += txtCepTutor_TextChanged;
            // 
            // txtCidadeTutor
            // 
            txtCidadeTutor.Location = new Point(4, 154);
            txtCidadeTutor.Margin = new Padding(2);
            txtCidadeTutor.Name = "txtCidadeTutor";
            txtCidadeTutor.PlaceholderText = "Cidade";
            txtCidadeTutor.Size = new Size(73, 23);
            txtCidadeTutor.TabIndex = 7;
            // 
            // txtBairroTutor
            // 
            txtBairroTutor.Location = new Point(4, 127);
            txtBairroTutor.Margin = new Padding(2);
            txtBairroTutor.Name = "txtBairroTutor";
            txtBairroTutor.PlaceholderText = "Bairro";
            txtBairroTutor.Size = new Size(73, 23);
            txtBairroTutor.TabIndex = 6;
            // 
            // txtNumeroTutor
            // 
            txtNumeroTutor.Location = new Point(81, 100);
            txtNumeroTutor.Margin = new Padding(2);
            txtNumeroTutor.Name = "txtNumeroTutor";
            txtNumeroTutor.PlaceholderText = "Numero";
            txtNumeroTutor.Size = new Size(59, 23);
            txtNumeroTutor.TabIndex = 5;
            txtNumeroTutor.TextChanged += txtNumeroTutor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 254);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 4;
            label2.Text = "Telefone para Contato:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Endereço:";
            label1.Click += label1_Click;
            // 
            // txtRuaTutor
            // 
            txtRuaTutor.Location = new Point(4, 100);
            txtRuaTutor.Margin = new Padding(2);
            txtRuaTutor.Name = "txtRuaTutor";
            txtRuaTutor.PlaceholderText = "Rua";
            txtRuaTutor.Size = new Size(73, 23);
            txtRuaTutor.TabIndex = 2;
            // 
            // txtCpfTutor
            // 
            txtCpfTutor.Location = new Point(90, 21);
            txtCpfTutor.Margin = new Padding(2);
            txtCpfTutor.Name = "txtCpfTutor";
            txtCpfTutor.PlaceholderText = "CPF";
            txtCpfTutor.Size = new Size(90, 23);
            txtCpfTutor.TabIndex = 1;
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Location = new Point(4, 21);
            txtNomeTutor.Margin = new Padding(2);
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.PlaceholderText = "Nome Completo";
            txtNomeTutor.Size = new Size(83, 23);
            txtNomeTutor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 54);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(546, 537);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtCampoBuscar
            // 
            txtCampoBuscar.Location = new Point(343, 19);
            txtCampoBuscar.Name = "txtCampoBuscar";
            txtCampoBuscar.PlaceholderText = "Buscar por tutores";
            txtCampoBuscar.RightToLeft = RightToLeft.No;
            txtCampoBuscar.Size = new Size(100, 23);
            txtCampoBuscar.TabIndex = 2;
            txtCampoBuscar.TextChanged += txtCampoBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(458, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 598);
            Controls.Add(btnBuscar);
            Controls.Add(txtCampoBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "TutorForm";
            Text = "TutorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNomeTutor;
        private TextBox txtRuaTutor;
        private TextBox txtCpfTutor;
        private Label label2;
        private Label label1;
        private TextBox txtNumeroTutor;
        private TextBox txtCepTutor;
        private TextBox txtCidadeTutor;
        private TextBox txtBairroTutor;
        private TextBox txtTelefoneTutor2;
        private TextBox txtCelularTutor;
        private Button btnAdicionar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private DataGridView dataGridView1;
        private TextBox txtCampoBuscar;
        private Button btnBuscar;
    }
}