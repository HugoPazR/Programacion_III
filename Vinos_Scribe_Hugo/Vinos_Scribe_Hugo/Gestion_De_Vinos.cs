using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
//using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vinos_Scribe_Hugo
{
    public partial class Gestion_De_Vinos : Form
    {

        List<Vino> List = new List<Vino>();
        Vino Vinos;
        
        public Gestion_De_Vinos()
        {
            InitializeComponent();
        }
        string Nombre_B, Presentacion_B, Color_B, Tipo_B, Lugar_B;
        double Contenido_Azucar_B;
        int Año_B;

        void Habilitar_Campos_1()
        {
            TxtNombre.Enabled = false;
            Cb_Presentacion.Enabled = true;
            Txt_Elaboracion.Enabled = true;
            Txt_ContA.Enabled = true;
            Cb_Tipo.Enabled = true;
            Txt_Origen.Enabled = true;
            Cb_Color.Enabled = true;

            Btn_Agregar.Enabled = false;
            Btn_Eliminar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Examinar.Enabled = true;
            Cb_Presentacion.Focus();
        }

        void Habilitar_Campos_2()
        {
            TxtNombre.Enabled = true;
            Cb_Presentacion.Enabled = true;
            Txt_Elaboracion.Enabled = true;
            Txt_ContA.Enabled = true;
            Cb_Tipo.Enabled = true;
            Txt_Origen.Enabled = true;
            Cb_Color.Enabled = true;

            Btn_Agregar.Enabled = true;
            Btn_Eliminar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Examinar.Enabled = true;
            TxtNombre.Focus();
        }

        void Deshabilitar_Campos()
        {
            TxtNombre.Enabled = true;
            Cb_Presentacion.Enabled = false;
            Txt_Elaboracion.Enabled = false;
            Txt_ContA.Enabled = false;
            Cb_Tipo.Enabled = false;
            Txt_Origen.Enabled = false;
            Cb_Color.Enabled = false;

            TxtNombre.Text = "";
            Cb_Presentacion.SelectedIndex = 0;
            Txt_Elaboracion.Text = "";
            Txt_ContA.Text = "";
            Cb_Tipo.SelectedIndex = 0;
            Txt_Origen.Text = "";
            Cb_Color.SelectedIndex = 0;

            Btn_Eliminar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Examinar.Enabled = false;
        }

        void Llenar_tabla()
        {
            Tabla_Vinos.Rows.Clear();

            // Recorre la lista de Vinos y agrega cada Vino a la tabla
            foreach (var vino in List)
            {
                // Agrega una fila al DataGridView y completa las celdas con los datos del Vino
                Tabla_Vinos.Rows.Add(
                    vino.Nombre,
                    vino.Presentacion,
                    vino.Año_Elaboracion,
                    vino.ContenidoAzucar,
                    vino.Tipo,
                    vino.LugarOrigen,
                    vino.Color
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_De_Vinos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_Vinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Selector_imagen = new OpenFileDialog();
            Selector_imagen.Title = "Seleccione una imagen";

            if ( Selector_imagen.ShowDialog() == DialogResult.OK)
            {
                Picture_Vino.Image = Image.FromStream(Selector_imagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                Picture_Vino.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Picture_Vino_Click(object sender, EventArgs e)
        {

        }

        private void Gbox_GV_Enter(object sender, EventArgs e)
        {

        }

        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacio, or favor llene el campo nombre");
                TxtNombre.Text = "";
                TxtNombre.Focus();
            }
            else
            {
                Nombre_B = TxtNombre.Text;
                var res = false;

                for (int i = 0; i < List.Count; i++)
                {
                    Vinos = List[i];
                    if (Nombre_B.Equals(Vinos.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        res = true;
                        Habilitar_Campos_1();
                        Cb_Presentacion.Text = Vinos.Presentacion.ToString();
                        Txt_Elaboracion.Text = Vinos.Año_Elaboracion.ToString();
                        Txt_ContA.Text = Vinos.ContenidoAzucar.ToString();
                        Cb_Tipo.Text = Vinos.Tipo.ToString();
                        Txt_Origen.Text = Vinos.LugarOrigen.ToString();
                        Cb_Color.Text = Vinos.Color.ToString();


                        MessageBox.Show("Vino: " + Nombre_B + " Encontrado\nPuede Eliminarlo o Modificarlo", "OK", MessageBoxButtons.OK);
                        break;
                    }
                }

                if (res == false)
                {
                    Habilitar_Campos_2();

                    if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(Cb_Presentacion.Text) || string.IsNullOrEmpty(Txt_Elaboracion.Text) || string.IsNullOrEmpty(Txt_ContA.Text) || string.IsNullOrEmpty(Cb_Tipo.Text) || string.IsNullOrEmpty(Txt_Origen.Text) || string.IsNullOrEmpty(Cb_Color.Text))
                    {
                        MessageBox.Show("Hay campos vacíos, complételos para continuar.", "Error Campos Vacíos", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Nombre_B = TxtNombre.Text;
                        Presentacion_B = Cb_Presentacion.SelectedItem.ToString();
                        Año_B = int.Parse(Txt_Elaboracion.Text);
                        Contenido_Azucar_B = double.Parse(Txt_ContA.Text);
                        Tipo_B = Cb_Tipo.SelectedItem.ToString();
                        Lugar_B = Txt_Origen.Text;
                        Color_B = Cb_Color.SelectedItem.ToString();

                        Vinos = new Vino();

                        Vinos.Nombre = Nombre_B;
                        Vinos.Presentacion = Presentacion_B;
                        Vinos.Año_Elaboracion = Año_B;
                        Vinos.ContenidoAzucar = Contenido_Azucar_B;
                        Vinos.Tipo = Tipo_B;
                        Vinos.LugarOrigen = Lugar_B;
                        Vinos.Color = Color_B;
                        List.Add(Vinos);
                        MessageBox.Show("Datos almacenados correctamente", "GUARDADO", MessageBoxButtons.OK);
                        Deshabilitar_Campos();
                        Llenar_tabla();

                    }

                }

            }
        }
    }
}
