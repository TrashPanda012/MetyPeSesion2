using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAPP1.clases;

namespace MyAPP1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = tbNombre.Text;
            persona.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(persona.EvaluarEdad());
        }
    }
}
