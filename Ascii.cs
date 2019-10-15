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
    public partial class Ascii : Form
    {
        public Ascii()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ascii_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Ascii.png");
           
        }
    }
}
