// Form1.cs
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Hospede> hospedes = new List<Hospede>();
        private List<Reserva> reservas = new List<Reserva>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarHospede_Click(object sender, EventArgs e)
        {
            var hospede = new Hospede
            {
                Nome = txtNome.Text,
                Sobrenome = lblsobre.Text,
                Documento = lbldoc.Text,
                Telefone = lbltel.Text,
                Email = lblemail.Text
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
    }
}
