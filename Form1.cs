// Form1.cs
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Hospede> hospedes = new List<Hospede>();
        private List<Reserva> reservas = new List<Reserva>();

        private DataGridView dataGridView1;
        private List<string> valuesInMemory;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarHospede_Click(object sender, EventArgs e)
        {
            var hospede = new Hospede
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Documento = txtDocumento.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };
            hospedes.Add(hospede);
            MessageBox.Show("Hóspede registrado com sucesso!");
        }

        private void btnFazerReserva_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                DataCheckIn = dtpCheckIn.Value,
                DataCheckOut = dtpCheckOut.Value,
                NumeroQuarto = int.Parse(txtNumeroQuarto.Text),
                Hospede = hospedes.Find(h => h.Documento == txtDocumentoHospede.Text)
            };
            reservas.Add(reserva);
            MessageBox.Show("Reserva feita com sucesso!");
        }

        private void btnListarReservas_Click(object sender, EventArgs e)
        {
            dgvReservas.Rows.Clear();
            foreach (var reserva in reservas)
            {
                dgvReservas.Rows.Add(reserva.Hospede.Nome, reserva.Hospede.Sobrenome, reserva.DataCheckIn, reserva.DataCheckOut, reserva.NumeroQuarto);
            }
        }

        private void btnregistrarHospede_Click_1(object sender, EventArgs e)
        {
            var hospede = new Hospede
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Documento = txtDocumento.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };
            hospedes.Add(hospede);
            MessageBox.Show("Hóspede registrado com sucesso!");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFazerReserva_Click_1(object sender, EventArgs e)
        {
            var hospede = hospedes.SingleOrDefault(h => h.Documento == txtDocumentoHospede.Text);
            var reserva = new Reserva
            {
                DataCheckIn = dtpCheckIn.Value,
                DataCheckOut = dtpCheckOut.Value,
                NumeroQuarto = int.Parse(txtNumeroQuarto.Text),
                Hospede = hospede
            };
            MessageBox.Show("Reserva feita com sucesso!");
        }

        private void btnListarReservas_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1 = new DataGridView();
            this.SuspendLayout();
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}