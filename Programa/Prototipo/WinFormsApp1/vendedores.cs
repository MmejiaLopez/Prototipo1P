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
    public partial class vendedores : Form
    {
        public vendedores()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
            MessageBox.Show("Bienvenido a Menu");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtAdress.Clear();
            txtName.Clear();
            txtNit.Clear();
            txtTel.Clear();
            txtBuscar.Clear();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string ID, name, adress, tel, nit, status;
            

            ID= txtID.Text;
            name= txtName.Text;
            adress = txtName.Text;
            tel = txtTel.Text;
            nit = txtNit.Text;
            status = txtEstatus.Text;

            string sql = "insert into vendedores values" +
                "('" + ID + "','" + name + "','" + adress + "','" + tel +
                "','" + nit + "','" + status + "')";

            conexion con = new conexion();
            con.IDU(sql);
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID, name, adress, tel, nit, status;


            ID = txtID.Text;
            name = txtName.Text;
            adress = txtName.Text;
            tel = txtTel.Text;
            nit = txtNit.Text;
            status = txtEstatus.Text;

            string sql2 = "delete from vendedores where id_examen = '" + ID + "'";

            string sql = "insert into vendedores values" +
                "('" + ID + "','" + name + "','" + adress + "','" + tel +
                "','" + nit + "','" + status + "')";

            conexion con = new conexion();
            con.IDU(sql2);
            con.IDU(sql);

            

            
            

            
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string buscar= txtBuscar.Text;
            string[] sellers = new string[5];

            int n = table4.Rows.Add();

            string sql = "select * from vendedores where id_examen = '" + buscar + "'";

            conexion con = new conexion();
            sellers = con.buscar(sql, 6);
           

            table4.Rows[n].Cells[0].Value = sellers[0];
            table4.Rows[n].Cells[1].Value = sellers[1];
            table4.Rows[n].Cells[2].Value = sellers[2];
            table4.Rows[n].Cells[3].Value = sellers[3];
            table4.Rows[n].Cells[4].Value = sellers[4];
            table4.Rows[n].Cells[5].Value = sellers[5];



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string buscar = table4.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from vendedores where id_examen = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);
           

            table4.Rows.RemoveAt(table4.CurrentRow.Index);
            
        }

        private void Examen_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
