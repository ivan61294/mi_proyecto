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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            txtIntentos.Text = intentos.ToString();
        }
        int intentos = 3;
        private void Form1_Load(object sender, EventArgs e)
        {
            
                                            
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            if (cboUsuario.Text == "Ivan" | cboUsuario.Text == "Cindy" | cboUsuario.Text == "Jose" | cboUsuario.Text == "Juan")
            {
                if (txtPassword.Text == "12345")
                {
                    Frm_Menu abrir = new Frm_Menu();
                    
                    abrir.Show();

                    this.Hide();  
                    
                }


                else 
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    intentos--;
                    txtIntentos.Text = intentos.ToString();
                    if (intentos==0)
                    {
                        MessageBox.Show("A culminado su numero de intentos");
                        Application.Exit();
                    }

                }

                }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
            
                                                      
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Gracias por Visitarnos");
            Application.Exit();

        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuario.Text == "Ivan")
            {
                pictureBox3.Image = Image.FromFile(@"Ivan.jpg");
            }


            if (cboUsuario.Text == "Cindy")
            {
                pictureBox3.Image = Image.FromFile(@"Cindy.jpg");
            }

            if (cboUsuario.Text == "Jose")
            {
                pictureBox3.Image = Image.FromFile(@"Jose.jpg");
            }

            if (cboUsuario.Text == "Juan")
            {
                pictureBox3.Image = Image.FromFile(@"Juan.jpg");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            




        }

        private void TxtIntentos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
