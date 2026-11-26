using PetLimeira.Data;
using PetLimeira.Models;
using PetLimeira.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PetLimeira.Forms
{
    public partial class TutorForm : Form
    {
        private int idSelecionado = 0;

        public TutorForm()
        {
            InitializeComponent();
            ListarTutores();

            // Desabilitar os botoes atualizar e Excluir
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void ListarTutores(string filtro = "")
        {
            var banco = new BancoContext();
            var tutores = banco.ControleTutores
                .Where(p => p.Nome.Contains(filtro))
                .ToList();
            dataGridView1.DataSource = tutores;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneTutor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCepTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verfica se o formulario é valido
            if (!CamposValidos())
            {
                return; // Encerra a execução
            }

            // Cria a conecçao com o banco
            var banco = new BancoContext();

            // Criar o objeto selecao para mapear os dados para o banco
            var tutor = new Tutor
            {
                Nome = txtNomeTutor.Text,
                Cpf = txtCpfTutor.Text,
                Rua = txtRuaTutor.Text,
                Numero = txtNumeroTutor.Text,
                Bairro = txtBairroTutor.Text,
                Cidade = txtCidadeTutor.Text,
                Cep = txtCepTutor.Text
            };

            banco.ControleTutores.Add(tutor);
            banco.SaveChanges();
            Mensagem.Aviso("Dados gravados com suceesso");

            // Atualizar o datagridview
            ListarTutores();

            // Limpar os campos do formulario
            LimparCampos();

            // Devolver o foco do cursor para o inicio
            txtNomeTutor.Focus();
        }

        // Método para validar campos do formulário
        private bool CamposValidos()
        {
            if (txtNomeTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o Nome do Tutor");
                txtNomeTutor.Focus();
                return false;
            }

            if (txtCpfTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o cpf");
                txtCpfTutor.Focus();
                return false;
            }

            if (txtRuaTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a Rua");
                txtRuaTutor.Focus();
                return false;
            }

            if (txtNumeroTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o Numero da Rua");
                txtNumeroTutor.Focus();
                return false;
            }

            if (txtBairroTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o Bairro");
                txtBairroTutor.Focus();
                return false;
            }

            if (txtCidadeTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a Cidade");
                txtCidadeTutor.Focus();
                return false;
            }

            if (txtCepTutor.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o Cep");
                txtCepTutor.Focus();
                return false;
            }

            return true;
        }

        // Método para limpar os campos do formulario
        private void LimparCampos()
        {
            txtNomeTutor.Clear();
            txtCpfTutor.Clear();
            txtRuaTutor.Clear();
            txtNumeroTutor.Clear();
            txtBairroTutor.Clear();
            txtCidadeTutor.Clear();
            txtCepTutor.Clear();
            btnAdicionar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Desabilitar o botão add para evitar clique acidental
            btnAdicionar.Enabled = false;

            // Habilitar os botoes Atualizar e Excluir
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;

            if (e.RowIndex < 0)
            {
                return;
            }

            var objTutor = dataGridView1.Rows[e.RowIndex].DataBoundItem as Tutor;

            if (objTutor == null)
            {
                return;
            }

            idSelecionado = objTutor.IdTutor;
            txtNomeTutor.Text = objTutor.Nome;
            txtCpfTutor.Text = objTutor.Cpf;
            txtRuaTutor.Text = objTutor.Rua;
            txtNumeroTutor.Text = objTutor.Numero;
            txtBairroTutor.Text = objTutor.Bairro;
            txtCidadeTutor.Text = objTutor.Cidade;
            txtCepTutor.Text = objTutor.Cep;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Mensagem.Aviso("Selecione uma linha no grid");
                return;
            }

            // Solicitar a confirmação de exclusão
            var resposta = Mensagem.Confirmacao("Deseja apagar esse tutor");
            if (resposta != DialogResult.Yes)
            {
                return;
            }

            // Buscar a conexão com o banco
            var banco = new BancoContext();

            // Verificar se o idSelecionado existe no banco de dados
            var objTutor = banco.ControleTutores.Find(idSelecionado);
            if (objTutor == null)
            {
                return;
            }

            // Executa a exclusão
            banco.ControleTutores.Remove(objTutor);
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Mensagem.Aviso("Selecione uma linha no grid");
                return;
            }

            // Verificar se os campos são validos
            if (!CamposValidos())
            {
                return; // Encerra a execução
            }

            var banco = new BancoContext();
            var objTutor = banco.ControleTutores.Find(idSelecionado);
            if (objTutor == null)
            {
                return;
            }

            // Obter os novos dados do formulario e atualizar no objeto que sera
            // atualizado
            objTutor.Nome = txtNomeTutor.Text;
            objTutor.Cpf = txtCpfTutor.Text;
            objTutor.Rua = txtRuaTutor.Text;
            objTutor.Numero = txtNumeroTutor.Text;
            objTutor.Bairro = txtBairroTutor.Text;
            objTutor.Cidade = txtCidadeTutor.Text;
            objTutor.Cep = txtCepTutor.Text;
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBuscar.Text);
        }

        private void txtCampoBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBuscar.Text);
        }
    }

}
