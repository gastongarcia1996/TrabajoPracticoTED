using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoTED
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.btn_inicio.Cursor = Cursors.AppStarting;
            if (!Conexion.consultar_usuario_contraseña(this.txt_usuario.Text, this.txt_contraseña.Text).HasRows)
            {
                Conexion.CerrarConexion();
                MessageBox.Show(this, "Usuario o contraseña incorrectos", "Inicio sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Menu menu = new Menu(this);
            this.Hide();
            menu.Show();
            Conexion.CerrarConexion();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            RegistroUsuarioForm rg = new RegistroUsuarioForm(this);
            this.Hide();
            rg.Show();
        }

        private void Form_closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "¿Seguro desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
        }

        private void Mouse_down(object sender, MouseEventArgs e)
        {
            this.txt_contraseña.PasswordChar = '\0';
        }

        private void Mouse_up(object sender, MouseEventArgs e)
        {
            this.txt_contraseña.PasswordChar = '*';
        }
    }
}
