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
    public partial class Form1 : Form
    {
        Gestion_De_Usuarios Gestion_Usuario = new Gestion_De_Usuarios();
        public Form1()
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
    }
}
