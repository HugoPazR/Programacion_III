using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinos_Scribe_Hugo
{
    public partial class Gestion_De_Usuarios : Form
    {
        string Usuario = "Hugo Paz";
        string Contraseña = "1234";

        public Gestion_De_Usuarios()
        {
            InitializeComponent();
        }

        public void Activar_Campos()
        {
            TxtNombreU.Enabled = true;
            TxtApellidoU.Enabled = true;
            Txt_CorreoU.Enabled = true;
            Txt_CelularU.Enabled = true;
            Txt_FechaU.Enabled = true;
            Cb_TipodeU.Enabled = true;
            Txt_InfoUsuario.Enabled = true;
            Txt_InfoContra.Enabled = true;
        }

        public void Desactivar_Campos()
        {
            TxtNombreU.Enabled = false;
            TxtApellidoU.Enabled = false;
            Txt_CorreoU.Enabled = false;
            Txt_CelularU.Enabled = false;
            Txt_FechaU.Enabled = false;
            Cb_TipodeU.Enabled = false;
            Txt_InfoUsuario.Enabled = false;
            Txt_InfoContra.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Gestion_De_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_Registrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_Tipo_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            if( (Usuario == Txt_Usuario.Text) && (Contraseña == Txt_Contraseña.Text))
            {
                MessageBox.Show("Bienvenido A continuacion Registre Modifique u Elimine un usuario", "Usuario encontrado");
                Activar_Campos();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Usuario No Registrado");
                Desactivar_Campos();
            }
        }
    }
}
