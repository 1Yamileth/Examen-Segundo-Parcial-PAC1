using BD;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            if (Usuario_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Usuario_textBox, " INGRESE UN USUARIO VALIDO");
                Usuario_textBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (Contra_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Usuario_textBox, " INGRESE UNA CONTRASEÑA VALIDA");
                Contra_textBox.Focus();
                return;
            }

            Login login = new Login(Usuario_textBox.Text, Contra_textBox.Text);
            Usuario user = new Usuario();
            UsuarioDB usuarioBD = new UsuarioDB();

          //  System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(Usuario_textBox.Text);
         //   System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, null);
          //  System.Threading.Thread.CurrentPrincipal = principal;

            user = usuarioBD.Autenticar(login);
            if (user != null)
            {
                if (user.EstaActivo)
                {

                    MenuForm menuFormulario = new MenuForm();
                    Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO INACTIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DATOS DE USUARIO INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Mostrar_button_Click(object sender, EventArgs e)
        {
            if (Contra_textBox.PasswordChar == '*')
            {
                Contra_textBox.PasswordChar = '\0';
            }
            else
            {
                Contra_textBox.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario_textBox.Focus();
        }

        private void Cancelar_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
