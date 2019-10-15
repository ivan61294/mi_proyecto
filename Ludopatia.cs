using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proyecto
{
    public partial class Ludopatia : Form
    {
        public Ludopatia()
        {
            InitializeComponent();
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtTexto.Text = "La adicción patológica \n a los juegos de azar y las apuestas se conoce como ludopatía. Esta adicción consiste en un deseo irreprimible de jugar pese a que la persona es conciente de las consecuencias. El origen etimológico de este término se encuentra en el latín";



        }

        private void btnCausas_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtTexto.Text = "El número de casinos ha aumentado en el mundo y con ellos, la cantidad de personas que practican esta actividad, misma que se dificulta medir porque no hay cifras oficiales de la cantidad de jugadores y menos aún, la cantidad de jugadores con problemas de juego. Desde 1992 la OMS, clasifica la ludopatía como enfermedad emocional, definida como “adicción patológica a los juegos de azar y las apuestas”";
        }

        private void btnConsecuencias_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtTexto.Text = "Problemas emocionales, Problemas familiares, Problemas laborales/académicos, Problemas sociales, Problemas legales, Problemas económicos";
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtTexto.Text = "Terapia. La terapia conductual o la terapia cognitiva conductual pueden ser útiles. \r\nLa terapia conductual utiliza la exposición sistemática a la conducta que deseas olvidar y te enseña estrategias para disminuir tu necesidad de apostar. \r\nLa terapia cognitiva conductual se enfoca en identificar las creencias enfermizas, irracionales y negativas, y a reemplazarlas por las que son positivas y sanas. \r\nLa terapia familiar también puede ser de ayuda. Medicamentos. \r\nLos antidepresivos y los estabilizadores del estado de ánimo pueden ayudar a solucionar los problemas que a menudo acompañan la ludopatía, como la depresión, el trastorno obsesivo compulsivo (TOC) o el trastorno por déficit de atención con hiperactividad (TDAH). Algunos antidepresivos pueden ser eficaces en la disminución de las conductas ludopáticas. \r\nLos medicamentos llamados antagonistas de los estupefacientes, útiles en el tratamiento del abuso de sustancias, pueden ayudar a tratar la ludopatía. \r\nGrupos de autoayuda. Algunas personas descubren que hablar con otras que tienen ludopatía puede ser un aspecto beneficioso del tratamiento. Pídele consejo al profesional del cuidado de la salud respecto de los grupos de autoayuda, como Apostadores anónimos y otros recursos. ";
        }
    }
}
