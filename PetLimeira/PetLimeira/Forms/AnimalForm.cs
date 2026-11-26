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
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();
            CarregarCombos();
            ListarAnimais();
        }

        // Carrega as Listas de sedes e seleçoes nos combos
        private void CarregarCombos()
        {
            var banco = new BancoContext();

            // ComboBox de sedes
            cmbTutorAnimal.DisplayMember = "Nome";  // O que o usuario ve
            cmbTutorAnimal.ValueMember = "IdTutor";
            cmbTutorAnimal.DataSource = banco.ControleTutores.ToList();
        }

        private void ListarAnimais()
        {
            var banco = new BancoContext();
            var partidas = banco.ControleAnimal.ToList();
            dataGridView1.DataSource = partidas;
        }
        private void lblPesoAnimal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var banco = new BancoContext();

            // Criar o objeto partida que sera salvo no banco
            var animal = new Animal
            {
                Nome = txtNomeAnimal.Text,
                Especie = txtEspecie.Text,
                Raca = txtRaca.Text,
                DataNascimento = dtpAnimalData.Value.Date,
                Peso = nudPeso.Value,
                Situacao = txtSituacao.Text,
                FkIdTutor = cmbTutorAnimal.SelectedValue as int?
            };

            // Adicionar o objeto no banco
            banco.ControleAnimal.Add(animal);
            banco.SaveChanges();

            Mensagem.Aviso("dados gravados com sucesso");
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
