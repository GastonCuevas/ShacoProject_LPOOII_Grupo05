using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmPantallaCarga : Form
    {
        public frmPantallaCarga(Usuario userLogued)
        {
            InitializeComponent();
            Carga(userLogued);
        }

        private void Carga(Usuario userLogued)
        {
            lbNombre.Text = "Welcome: " + userLogued.Usu_ApellidoNombre;
        }

        private void frmPantallaCarga_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            barraProgreso.Value = 0;
            barraProgreso.Minimum = 0;
            barraProgreso.Maximum = 100;
            timerAparecer.Start();
        }

        private void timerAparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.95) this.Opacity += 0.05;
            barraProgreso.Value += 1;
            barraProgreso.Text = barraProgreso.Value.ToString();
            if (barraProgreso.Value == 100)
            {
                timerAparecer.Stop();
                timerDesaparecer.Start();
            }
        }

        private void timerDesaparecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timerDesaparecer.Stop();
                this.Close();
            }
        }
    }
}
