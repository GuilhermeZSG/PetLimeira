namespace PetLimeira.Forms
{
    partial class AnimalForm
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
            btnBuscar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            dataGridView1 = new DataGridView();
            txtNomeAnimal = new TextBox();
            txtCampoBuscar = new TextBox();
            groupBox1 = new GroupBox();
            txtRaca = new TextBox();
            txtEspecie = new TextBox();
            cmbTutorAnimal = new ComboBox();
            lblTutorAnimal = new Label();
            lblSituacaoAnimal = new Label();
            nudPeso = new NumericUpDown();
            lblPesoAnimal = new Label();
            lblNascimentoAnimal = new Label();
            dtpAnimalData = new DateTimePicker();
            lblRacaAnimal = new Label();
            lblEspecieAnimal = new Label();
            lblNomeAnimal = new Label();
            txtSituacao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(407, -55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(177, 388);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(55, 20);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(120, 388);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(53, 20);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(52, 388);
            btnAtualizar.Margin = new Padding(2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(64, 20);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(6, 388);
            btnAdicionar.Margin = new Padding(2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(42, 20);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(506, 516);
            dataGridView1.TabIndex = 5;
            // 
            // txtNomeAnimal
            // 
            txtNomeAnimal.Location = new Point(6, 44);
            txtNomeAnimal.Margin = new Padding(2);
            txtNomeAnimal.Name = "txtNomeAnimal";
            txtNomeAnimal.PlaceholderText = "Nome Completo";
            txtNomeAnimal.Size = new Size(123, 23);
            txtNomeAnimal.TabIndex = 0;
            // 
            // txtCampoBuscar
            // 
            txtCampoBuscar.Location = new Point(292, -55);
            txtCampoBuscar.Name = "txtCampoBuscar";
            txtCampoBuscar.PlaceholderText = "Buscar por tutores";
            txtCampoBuscar.RightToLeft = RightToLeft.No;
            txtCampoBuscar.Size = new Size(100, 23);
            txtCampoBuscar.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSituacao);
            groupBox1.Controls.Add(txtRaca);
            groupBox1.Controls.Add(txtEspecie);
            groupBox1.Controls.Add(cmbTutorAnimal);
            groupBox1.Controls.Add(lblTutorAnimal);
            groupBox1.Controls.Add(lblSituacaoAnimal);
            groupBox1.Controls.Add(nudPeso);
            groupBox1.Controls.Add(lblPesoAnimal);
            groupBox1.Controls.Add(lblNascimentoAnimal);
            groupBox1.Controls.Add(dtpAnimalData);
            groupBox1.Controls.Add(lblRacaAnimal);
            groupBox1.Controls.Add(lblEspecieAnimal);
            groupBox1.Controls.Add(lblNomeAnimal);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtNomeAnimal);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(267, 415);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Animal";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(13, 168);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(115, 23);
            txtRaca.TabIndex = 29;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(10, 110);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(119, 23);
            txtEspecie.TabIndex = 28;
            // 
            // cmbTutorAnimal
            // 
            cmbTutorAnimal.FormattingEnabled = true;
            cmbTutorAnimal.Location = new Point(141, 44);
            cmbTutorAnimal.Name = "cmbTutorAnimal";
            cmbTutorAnimal.Size = new Size(121, 23);
            cmbTutorAnimal.TabIndex = 27;
            // 
            // lblTutorAnimal
            // 
            lblTutorAnimal.AutoSize = true;
            lblTutorAnimal.Location = new Point(141, 27);
            lblTutorAnimal.Name = "lblTutorAnimal";
            lblTutorAnimal.Size = new Size(36, 15);
            lblTutorAnimal.TabIndex = 26;
            lblTutorAnimal.Text = "Tutor";
            lblTutorAnimal.Click += label1_Click;
            // 
            // lblSituacaoAnimal
            // 
            lblSituacaoAnimal.AutoSize = true;
            lblSituacaoAnimal.Location = new Point(8, 318);
            lblSituacaoAnimal.Name = "lblSituacaoAnimal";
            lblSituacaoAnimal.Size = new Size(52, 15);
            lblSituacaoAnimal.TabIndex = 24;
            lblSituacaoAnimal.Text = "Situação";
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Location = new Point(8, 275);
            nudPeso.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(120, 23);
            nudPeso.TabIndex = 23;
            // 
            // lblPesoAnimal
            // 
            lblPesoAnimal.AutoSize = true;
            lblPesoAnimal.Location = new Point(8, 257);
            lblPesoAnimal.Name = "lblPesoAnimal";
            lblPesoAnimal.Size = new Size(35, 15);
            lblPesoAnimal.TabIndex = 22;
            lblPesoAnimal.Text = "Peso:";
            lblPesoAnimal.Click += lblPesoAnimal_Click;
            // 
            // lblNascimentoAnimal
            // 
            lblNascimentoAnimal.AutoSize = true;
            lblNascimentoAnimal.Location = new Point(8, 196);
            lblNascimentoAnimal.Name = "lblNascimentoAnimal";
            lblNascimentoAnimal.Size = new Size(117, 15);
            lblNascimentoAnimal.TabIndex = 21;
            lblNascimentoAnimal.Text = "Data de Nascimento:";
            // 
            // dtpAnimalData
            // 
            dtpAnimalData.Format = DateTimePickerFormat.Short;
            dtpAnimalData.Location = new Point(8, 214);
            dtpAnimalData.Name = "dtpAnimalData";
            dtpAnimalData.Size = new Size(121, 23);
            dtpAnimalData.TabIndex = 20;
            // 
            // lblRacaAnimal
            // 
            lblRacaAnimal.AutoSize = true;
            lblRacaAnimal.Location = new Point(8, 146);
            lblRacaAnimal.Name = "lblRacaAnimal";
            lblRacaAnimal.Size = new Size(35, 15);
            lblRacaAnimal.TabIndex = 18;
            lblRacaAnimal.Text = "Raça:";
            // 
            // lblEspecieAnimal
            // 
            lblEspecieAnimal.AutoSize = true;
            lblEspecieAnimal.Location = new Point(8, 87);
            lblEspecieAnimal.Name = "lblEspecieAnimal";
            lblEspecieAnimal.Size = new Size(49, 15);
            lblEspecieAnimal.TabIndex = 17;
            lblEspecieAnimal.Text = "Espécie:";
            // 
            // lblNomeAnimal
            // 
            lblNomeAnimal.AutoSize = true;
            lblNomeAnimal.Location = new Point(8, 27);
            lblNomeAnimal.Name = "lblNomeAnimal";
            lblNomeAnimal.Size = new Size(43, 15);
            lblNomeAnimal.TabIndex = 16;
            lblNomeAnimal.Text = "Nome:";
            // 
            // txtSituacao
            // 
            txtSituacao.Location = new Point(9, 345);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(120, 23);
            txtSituacao.TabIndex = 30;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(txtCampoBuscar);
            Controls.Add(groupBox1);
            Name = "AnimalForm";
            Text = "AnimalForm";
            Load += AnimalForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private TextBox txtTelefoneTutor2;
        private TextBox txtCelularTutor;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtEspecieAnimal;
        private TextBox txtNomeAnimal;
        private TextBox txtCampoBuscar;
        private GroupBox groupBox1;
        private Label lblRacaAnimal;
        private Label lblEspecieAnimal;
        private Label lblNomeAnimal;
        private DateTimePicker dtpAnimalData;
        private Label lblPesoAnimal;
        private Label lblNascimentoAnimal;
        private NumericUpDown nudPeso;
        private Label lblSituacaoAnimal;
        private Label lblTutorAnimal;
        private ComboBox cmbTutorAnimal;
        private TextBox txtRaca;
        private TextBox txtEspecie;
        private TextBox txtSituacao;
    }
}