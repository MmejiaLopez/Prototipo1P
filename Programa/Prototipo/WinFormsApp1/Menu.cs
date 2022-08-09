using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void picturecliente_Click(object sender, EventArgs e)
        {
         
        }

        private void picturecliente_MouseHover(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.ForeColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(139, 119);
            lbcliente.Location = new Point(111, 205);

        }

        private void picturecliente_MouseLeave(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(49, 101, 244);
            lbcliente.ForeColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(129, 109);
            lbcliente.Location = new Point(105, 196);
        }

        private void lbtrabajador_MouseHover(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.ForeColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(139, 119);
            lbtrabajador.Location = new Point(375, 205);
        }

        private void lbtrabajador_MouseLeave(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(49, 101, 244);
            lbtrabajador.ForeColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(129, 109);
            lbtrabajador.Location = new Point(368, 196);
        }

        private void lblaboratorio_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void picturelaboratorio_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picturecita_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picturecita_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picturedoctor_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picturedoctor_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void picturecita_Click(object sender, EventArgs e)
        {
            
        }

        private void picturelaboratorio_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void picturedoctor_Click(object sender, EventArgs e)
        {
           
        }

        private void picturetrabajador_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login con = new Login();
            this.Hide();
            Login l = new Login();
            l.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            vendedores l = new vendedores();
            this.Hide();
            l.Show();
        }
    }
}
