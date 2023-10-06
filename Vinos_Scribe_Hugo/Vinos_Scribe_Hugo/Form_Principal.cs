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
    public partial class Form_Principal : Form
    {
        Gestion_De_Usuarios Gestion_Usuario = new Gestion_De_Usuarios();
        Gestion_De_Vinos Gestion_Vinos = new Gestion_De_Vinos();
        Calificaciones Calificaciones = new Calificaciones();
        Desgustaciones Desgustaciones = new Desgustaciones();
        Gestio_De_Bodega Gestio_De_Bodega = new Gestio_De_Bodega();
        
         
        public Form_Principal()
        {
            InitializeComponent();
        }
        public void AbrirForms_Gestion(Form form)
        {
            form.ShowDialog();
        }

        private void Tools_BTN_GestionU_Click(object sender, EventArgs e)
        {
            AbrirForms_Gestion(Gestion_Usuario);
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }

        private void ools_BTN_GestionU_Click(object sender, EventArgs e)
        {
            AbrirForms_Gestion(Gestion_Vinos);
        }

        private void Tools_BTN_Calificacion_Click(object sender, EventArgs e)
        {
            AbrirForms_Gestion(Calificaciones);
        }

        private void Tools_BTN_Desgustacion_Click(object sender, EventArgs e)
        {
            AbrirForms_Gestion(Desgustaciones);
        }

        private void Tools_BTN_Bodega_Click(object sender, EventArgs e)
        {
            AbrirForms_Gestion(Gestio_De_Bodega);
        }
    }
}
