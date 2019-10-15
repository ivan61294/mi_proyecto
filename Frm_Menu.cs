using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_ventas;

namespace App_Proyecto
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void ludopatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ludopatia abrir = new Ludopatia();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.webconsultas.com/mente-y-emociones/adicciones/tratamiento-de-la-ludopatia");
        }

        private void causasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.procasinosonline.com.pe/articulos/causas-de-la-ludopatia-en-la-mujer/");
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newtral.es/reportajes/la-ludopatia-un-problema-social-en-auge/");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void pacmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("pacman.exe");
        }

        private void instagrantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=es-la");
        }

        private void salsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalsa sa = new FrmSalsa();
            sa.MdiParent = this;
            sa.Show();
        }

        private void merengueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMerengue me = new FrmMerengue();
            me.MdiParent = this;
            me.Show();
        }

        private void bachataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBachata ba = new FrmBachata();
            ba.MdiParent = this;
            ba.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas abrir = new Ventas();
            abrir.MdiParent = this;
            abrir.Show();

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Te vas...?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("Buena desicion...!!!");

            
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ascii abrir = new Ascii();
            abrir.Show();
            
        }

        private void BuscaMinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("buscaminas.exe");
        }
    }
}
