using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Calculadora.FormCalculadora vCalculadora = new FormCalculadora(); //Calculadora genera conflicto por ser el nombre del proyecto
            vCalculadora.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Login vLogin = new Login();
            vLogin.Show();

        }
    }
}
