using Entidad;

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
        private Logica.PersonaService personaService = new Logica.PersonaService();

        string Usuario = "Hugo";
        string Contraseña = "1234";
        List<Persona> ListPersona = new List<Persona>();
        Persona Persona;
        string Nombre_GU, Apellido_GU, Correo_GU, Celular_GU
            , FechaRegistro_GU, TipoUsuario_GU, Usuario_GU, Contraseña_GU;
        int Existe;
        public Gestion_De_Usuarios()
        {
            InitializeComponent();
        }
        void Guardar(Persona persona)
        {
            var msg = personaService.Guardar(persona);
            MessageBox.Show(msg);

        }
        void CargarLista()
        {
            //lstDpto.Items.Clear();
            //foreach (var item in deparatamentoService.Consultar())
            //{
            //    lstDpto.Items.Add(item.NombreDpto);
            //}

            ListBx_Personas.DataSource = personaService.Consultar();
            ListBx_Personas.ValueMember = "Codigo de usuario";
            ListBx_Personas.DisplayMember = "Nombre Usuario";
        }
        void Buscar(string nombre)
        {
            var person = personaService.BuscarUsuario(nombre);
            VerPersona(person);
        }
        void VerPersona(Persona persona)
        {
            if (persona != null)
            {
                Nombre_GU = TxtNombreU.Text;
                Apellido_GU = TxtApellidoU.Text;
                Correo_GU = Txt_CorreoU.Text;
                Celular_GU = Txt_CelularU.Text;
                FechaRegistro_GU = Txt_FechaU.Text;
                TipoUsuario_GU = Cb_TipodeU.SelectedItem.ToString();
                Usuario_GU = Txt_InfoUsuario.Text;
                Contraseña_GU = Txt_InfoContra.Text;
            }

        }
        public void Cerrar_Sesion() {

            DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesion?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Limpiar_Campos_Ingresar();
                Activar_Ingresar();
                Bt_Ingresar.Enabled = false;
                TxtNombreU.Enabled = false;
            }
            else
            {
                TxtNombreU.Focus();
                TxtNombreU.Enabled = true;
                return;

            }

        }
        public void Limpiar_Campos() {

            TxtApellidoU.Text = "";
            Txt_CelularU.Text = "";
            Txt_CorreoU.Text = "";
            Txt_FechaU.Text = "";
            Txt_InfoContra.Text = "";
            Txt_InfoUsuario.Text = "";
            TxtNombreU.Text = "";
            Cb_TipodeU.Text = "";

        }
        public void Limpiar_Campos_Ingresar()
        {
            Txt_Usuario.Text = "";
            Txt_Contraseña.Text = "";
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
            Bt_AgregarInfoU.Enabled = true;
            Bt_ModificarU.Enabled = true;
            Bt_EliminarU.Enabled = true;
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
        public void Desactivar_Ingresar()
        {
            Txt_Usuario.Enabled = false;
            Txt_Contraseña.Enabled = false;
            Bt_Ingresar.Enabled = false;
        }
        public void Activar_Ingresar()
        {
            Txt_Usuario.Enabled = true;
            Txt_Contraseña.Enabled = true;
            Bt_Ingresar.Enabled = true;
        }
        private int Obtener_Posicion(string Nombre_B)
        {
            for (int i = 0; i < ListPersona.Count; i++)
            {
                Persona persona = ListPersona[i];
                if (Nombre_B.Equals(Persona.Nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
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
            CargarLista();
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

        private void Bt_ModificarU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombreU.Text) || string.IsNullOrEmpty(TxtApellidoU.Text) || string.IsNullOrEmpty(Txt_CorreoU.Text) || string.IsNullOrEmpty(Txt_CelularU.Text) || string.IsNullOrEmpty(Txt_FechaU.Text) || string.IsNullOrEmpty(Cb_TipodeU.SelectedItem.ToString()) || string.IsNullOrEmpty(Txt_Usuario.Text) || string.IsNullOrEmpty(Txt_Contraseña.Text))
            {
                MessageBox.Show("Hay campos vacíos, complételos para continuar.", "Error Campos Vacíos", MessageBoxButtons.OK);
            }
            else
            {
                Nombre_GU = TxtNombreU.Text;
                Apellido_GU = TxtApellidoU.Text;
                Correo_GU = Txt_CorreoU.Text;
                Celular_GU = Txt_CelularU.Text;
                FechaRegistro_GU = Txt_FechaU.Text;
                TipoUsuario_GU = Cb_TipodeU.SelectedItem.ToString();
                Usuario_GU = Txt_InfoUsuario.Text;
                Contraseña_GU = Txt_InfoContra.Text;

                Persona = new Persona();

                Persona.Nombre = Nombre_GU;
                Persona.Apellido = Apellido_GU;
                Persona.Correo = Correo_GU;
                Persona.Celular = Celular_GU;
                Persona.FechaRegistro = FechaRegistro_GU;
                Persona.TipoUsuario = TipoUsuario_GU;
                Persona.Usuario = Usuario_GU;
                Persona.Contraseña = Contraseña_GU;

                int Pos = Obtener_Posicion(Nombre_GU);
                ListPersona[Pos] = Persona;
                MessageBox.Show("Datos almacenados correctamente", "GUARDADO", MessageBoxButtons.OK);
                Desactivar_Campos();
                Limpiar_Campos();
                TxtNombreU.Enabled = true;
                Bt_AgregarInfoU.Enabled = true;
                Bt_ModificarU.Enabled = false;
                Bt_EliminarU.Enabled = false;
            }
            Cerrar_Sesion();
        }

        private void Bt_EliminarU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreU.Text))
            {
                MessageBox.Show("Para eliminar un Usuario, El nombre del Usuario a eliminar no puede quedar vacío", "ERROR NOMBRE DE USUARIO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombreU.Text = "";
                TxtNombreU.Focus();
            }
            else
            {
                Nombre_GU = TxtNombreU.Text;
                Existe = Obtener_Posicion(Nombre_GU);
                if (Existe == -1)
                {
                    MessageBox.Show("El Usuario con el nombre a eliminar no existe", "EL USUARIO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNombreU.Text = "";
                    TxtNombreU.Focus();
                }
                else
                {
                    ListPersona.RemoveAt(Existe);
                    MessageBox.Show("VINO ELIMINADO CORRECTAMENTE", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreU.Text = "";
                    TxtNombreU.Focus();
                    Desactivar_Campos();
                    Limpiar_Campos();
                    Bt_AgregarInfoU.Enabled = true;
                    Bt_ModificarU.Enabled = false;
                    Bt_EliminarU.Enabled = false;

                }
            }
            Cerrar_Sesion();
        }

        private void ListBx_Personas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar(ListBx_Personas.SelectedValue.ToString());
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            if ((/*Persona.*/Usuario == Txt_Usuario.Text) && (/*Persona.*/Contraseña == Txt_Contraseña.Text))
            {
                MessageBox.Show("Bienvenido A continuacion Registre, Modifique u Elimine un usuario", "Usuario encontrado");
                TxtNombreU.Enabled = true;
                Bt_AgregarInfoU.Enabled = true;
                TxtNombreU.Focus(); 
                Desactivar_Ingresar();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Usuario No Registrado");
                Desactivar_Campos();
            }
        }

        private void Txt_CelularU_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_CelularU_MouseEnter(object sender, EventArgs e)
        {
            Txt_CelularU.BackColor = Color.LightGray;
        }

        private void Txt_CelularU_MouseLeave(object sender, EventArgs e)
        {
            Txt_CelularU.BackColor = Color.White;
        }

        private void Txt_CelularU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( char.IsLetter(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void TxtNombreU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Bt_AgregarInfoU_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtNombreU.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacio, por favor llene el campo nombre");
                TxtNombreU.Text = "";
                TxtNombreU.Focus();
            }
            else
            {
                Nombre_GU = TxtNombreU.Text;
                var res = false;

                for (int i = 0; i < ListPersona.Count; i++)
                {
                    Persona = ListPersona[i];
                    if (Nombre_GU.Equals(Persona.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        res = true;
                        Activar_Campos();
                        TxtNombreU.Text = Persona.Nombre;
                        TxtApellidoU.Text = Persona.Apellido;
                        Txt_CorreoU.Text = Persona.Correo.ToString();
                        Txt_CelularU.Text = Persona.Celular.ToString();
                        Txt_FechaU.Text = Persona.FechaRegistro;
                        Cb_TipodeU.Text = Persona.TipoUsuario;
                        Txt_InfoUsuario.Text = Persona.Usuario;
                        Txt_InfoContra.Text = Persona.Contraseña;

                        MessageBox.Show("Nombre: " + Nombre_GU + " Encontrado\nPuede Eliminarlo o Modificarlo", "OK", MessageBoxButtons.OK);
                        Bt_AgregarInfoU.Enabled = false;
                        TxtNombreU.Enabled = false;
                        break;
                    }
                }

                if (res == false)
                {
                    Activar_Campos();
                    Bt_EliminarU.Enabled = false;
                    Bt_ModificarU.Enabled = false;
                    TxtNombreU.Enabled = false;
                    TxtApellidoU.Focus();
                    

                    if (string.IsNullOrEmpty(TxtNombreU.Text) || string.IsNullOrEmpty(TxtApellidoU.Text) || string.IsNullOrEmpty(Txt_CorreoU.Text) || string.IsNullOrEmpty(Txt_CelularU.Text) || string.IsNullOrEmpty(Txt_FechaU.Text) || string.IsNullOrEmpty(Cb_TipodeU.SelectedItem.ToString()) || string.IsNullOrEmpty(Txt_Usuario.Text) || string.IsNullOrEmpty(Txt_Contraseña.Text)) // Si algún campo está vacío
                    {
                        MessageBox.Show("Por favor, completa todos los campos.");
                    }
                    else
                    {
                        Nombre_GU = TxtNombreU.Text;
                        Apellido_GU = TxtApellidoU.Text;
                        Correo_GU = Txt_CorreoU.Text;
                        Celular_GU = Txt_CelularU.Text;
                        FechaRegistro_GU = Txt_FechaU.Text;
                        TipoUsuario_GU = Cb_TipodeU.SelectedItem.ToString();
                        Usuario_GU = Txt_InfoUsuario.Text;
                        Contraseña_GU = Txt_InfoContra.Text;

                        Persona = new Persona();

                        Persona.Nombre = Nombre_GU;
                        Persona.Apellido = Apellido_GU;
                        Persona.Correo = Correo_GU;
                        Persona.Celular = Celular_GU;
                        Persona.FechaRegistro = FechaRegistro_GU;
                        Persona.TipoUsuario = TipoUsuario_GU;
                        Persona.Usuario = Usuario_GU;
                        Persona.Contraseña = Contraseña_GU;

                        
                        ListPersona.Add(Persona);
                        MessageBox.Show("Datos almacenados correctamente", "GUARDADO", MessageBoxButtons.OK);
                        Limpiar_Campos();
                        Desactivar_Campos();
                        Guardar(new Persona(TxtNombreU.Text, TxtApellidoU.Text, Txt_CorreoU.Text, Txt_CelularU.Text, Txt_FechaU.Text, Cb_TipodeU.SelectedItem.ToString(), Txt_InfoUsuario.Text, Txt_InfoContra.Text));
                        CargarLista();
                        Cerrar_Sesion();

                    }

                }

            }

            //Nombre_GU = TxtNombreU.Text;
            //Apellido_GU = TxtApellidoU.Text;
            //Correo_GU = Txt_CorreoU.Text;
            //Celular_GU = Txt_CelularU.Text;
            //FechaRegistro_GU = Txt_FechaU.Text;
            //TipoUsuario_GU = Cb_TipodeU.SelectedItem.ToString();
            //Usuario_GU = Txt_InfoUsuario.Text;
            //Contraseña_GU = Txt_InfoContra.Text;

            //if (string.IsNullOrEmpty(Nombre_GU) || string.IsNullOrEmpty(Apellido_GU) || string.IsNullOrEmpty(Correo_GU) || string.IsNullOrEmpty(Correo_GU) || string.IsNullOrEmpty(Celular_GU) || string.IsNullOrEmpty(FechaRegistro_GU) || string.IsNullOrEmpty(TipoUsuario_GU) || string.IsNullOrEmpty(Usuario_GU) || string.IsNullOrEmpty(Contraseña_GU)  ) // Si algún campo está vacío
            //{
            //    MessageBox.Show("Por favor, completa todos los campos.");
            //    return; // No agregues la persona si algún campo está vacío
            //}

            //Persona = new Persona();

            //List.Add(Persona);

            //MessageBox.Show("Usuario Registrado Correctamente", "Usuario Registrado");
            //Limpiar_Campos();

        }
    }
}
