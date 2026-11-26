using PetLimeira.Data;
using PetLimeira.Models;
using PetLimeira.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CriarHashParaOBanco();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Validar os campos vazios
            if (txtLogin.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o login");
                txtLogin.Focus();
                return;
            }

            // Validar os campos vazios
            if (txtSenha.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a senha");
                txtLogin.Focus();
                return;
            }

            // Autenticação com os dados digitados
            var banco = new BancoContext();

            // Busca no banco o primeiro registro de usuario que seja igual ao login informado
            var usuario = banco.ControleUsuario
                .FirstOrDefault(userDoBanco =>
                userDoBanco.Login == txtLogin.Text.Trim());

            if (usuario == null ||
                !HashSenha.Verificar(txtSenha.Text, usuario.Senha)
                )
            {
                Mensagem.Aviso("Usuario ou senha invalida");
                return;                  // Encerrar a execuçao do método
            }


            if (usuario == null)
            {
                Mensagem.Aviso("Usuario não encontrado");
                return;                  // Encerrar a execuçao do método
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CriarHashParaOBanco()
        {
            var minhaHash = HashSenha.Gerar("123");

            var banco = new BancoContext();
            var admin = new Usuario
            {
                Login = "dono",
                Senha = minhaHash
            };
            banco.ControleUsuario.Add(admin);
            banco.SaveChanges();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
