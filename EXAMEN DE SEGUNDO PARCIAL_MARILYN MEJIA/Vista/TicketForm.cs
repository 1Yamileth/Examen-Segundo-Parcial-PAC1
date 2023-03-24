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
        Ticket ticket = new Ticket();
        ClienteDB clienteDB = new ClienteDB();
        Cliente cliente = null;
        
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
            SoportecomboBox.Text = string.Empty;
            NumerotextBox.Clear();
            SubtotaltextBox.Clear();
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

            

            CodigotextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

       
        private void GenerarBoletobutton_Click(object sender, EventArgs e)
        {

            subtotal = Convert.ToDecimal(SubtotaltextBox.Text);
            descuento = Convert.ToDecimal(DescuentotextBox.Text);

            isv = subtotal * 0.15M;
            total = subtotal + isv - descuento;
            Ticket miticket = new Ticket();
            miticket.CodigoTicket =Convert.ToInt32(NumerotextBox.Text);
            miticket.Fecha = FechadateTimePicker.Value;
            miticket.CodigoUsuario = CodigotextBox.Text;
            miticket.IdentidadCliente = IdentidadtextBox.Text;
            miticket.TipoSoporte = SoportecomboBox.Text;
            miticket.DescripcionSolicitud = Problema_textBox.Text;
            miticket.DescripcionRespuesta = RespuestatextBox.Text;
            miticket.Subtotal= subtotal;
            miticket.Descuento = descuento;
            miticket.ISV = isv;
            miticket.Total = total;

            bool insertacion = ticketDB.GuardarTicket(miticket);

            if (insertacion )
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

        
        private void IdentidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadtextBox.Text))
            {
                cliente = new Cliente();
                cliente = clienteDB.DevolverClientePorId(IdentidadtextBox.Text);
                NombretextBox.Text = cliente.Nombre;
                ;
            }
            else
            {
                cliente = null;
                NombretextBox.Clear();
            }
        }

        private void Buscrabutton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadtextBox.Text))
            {
                cliente = new Cliente();
                cliente = clienteDB.DevolverClientePorId(IdentidadtextBox.Text);
                NombretextBox.Text = cliente.Nombre;
                ;
            }
            else
            {
                cliente = null;
                NombretextBox.Clear();
            }
        }

        private void Ticketbutton_Click(object sender, EventArgs e)
        {
           
                List<int> numerosGenerados = new List<int>();
                Random rnd = new Random();
                int numeroAleatorio = rnd.Next(0,200);

                while (numerosGenerados.Contains(numeroAleatorio))
                {
                    numeroAleatorio = rnd.Next();
                }

                numerosGenerados.Add(numeroAleatorio);

                NumerotextBox.Text = numeroAleatorio.ToString();
            

        }
    }
}
