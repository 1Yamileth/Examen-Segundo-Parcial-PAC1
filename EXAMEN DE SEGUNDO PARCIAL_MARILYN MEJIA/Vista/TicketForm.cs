using BD;
using Entidades;
using Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        TicketDB ticketDB = new TicketDB();
        ClienteDB clienteDB = new ClienteDB();
        
        decimal precio = 0;
        decimal isv = 0;
        decimal total = 0;
        decimal descuento = 0;
        decimal subtotal = 0;
    
          
        private void limpiarcontroles()
        {
            IdentidadtextBox.Clear();
            NombretextBox.Clear();
            Problema_textBox.Clear();
            RespuestatextBox.Clear();
            SoportetextBox.Clear();
            PreciotextBox.Clear();
            DescuentotextBox.Clear();
            ISVtextBox.Clear();
            TotaltextBox.Clear();
            precio = 0;
            descuento = 0;
            isv = 0;
            total = 0;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generamos un número aleatorio entre 1 y 100
            int numeroAleatorio = rnd.Next(1, 101);
            NumerotextBox.Text = Convert.ToString (numeroAleatorio);


          //  CodigotextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

       
        private void GenerarBoletobutton_Click(object sender, EventArgs e)
        {
            Cliente clien = new Cliente();
            clien.IdentidadCliente = IdentidadtextBox.Text;
            clien.Nombre = NombretextBox.Text;
            clien.Email = CorreotextBox.Text;

            bool inserto = clienteDB.InsertarCliente(clien);//Si "inserto" trae un ture es porque si hay usuario nuevo
            if (inserto)
            {
                limpiarcontroles();

                MessageBox.Show("CLIENTE GUARDADO SATISFACTORIAMENTE");
            }
            else
            {
                MessageBox.Show("CLIENTE NO GUARDADO ");

            }


            subtotal = Convert.ToDecimal(PreciotextBox.Text);
            descuento = Convert.ToDecimal(DescuentotextBox.Text);
            isv = subtotal * 0.15M;
            total = subtotal + isv - descuento;
            Ticket miticket = new Ticket();
            miticket.Fecha = FechadateTimePicker.Value;
            miticket.CodigoUsuario = CodigotextBox.Text;
            miticket.IdentidadCliente = IdentidadtextBox.Text;
            miticket.TipoSoporte = SoportetextBox.Text;
            miticket.DescripcionSolicitud = Problema_textBox.Text;
            miticket.DescripcionRespuesta = RespuestatextBox.Text;
            miticket.Precio = precio;
            miticket.Descuento = descuento;
            miticket.ISV = isv;
            miticket.Total = total;

            bool insertacion = ticketDB.GuardarTicket(miticket);

            if (insertacion)
            {
                limpiarcontroles();
                IdentidadtextBox.Focus();
                MessageBox.Show("BOLETO GENERARO EXITOSAMENTE");
            }
            else
            {
                MessageBox.Show("NO SE PUDO GENERAR EL BOLETO ");

            }
        }
    }
}
