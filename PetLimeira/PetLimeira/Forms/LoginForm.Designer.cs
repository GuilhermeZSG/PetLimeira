namespace PetLimeira.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitulo = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(55, 89);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Acesso ao Sistema";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(38, 180);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(224, 23);
            txtLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(38, 162);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Tag = "";
            lblLogin.Text = "Login";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(38, 248);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(38, 230);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 59);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(38, 295);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 41);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(166, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 447);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - acesso ao sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtLogin;
        private Label lblLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnCancelar;
    }
}