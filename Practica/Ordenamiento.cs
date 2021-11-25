using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Ordenamiento : Form
    {
        int i = 0, cantU;
        public struct Usuarios{
            public string nombre;
            public int edad;
        }
        Usuarios[] Datos;
        public Ordenamiento()
        {
            InitializeComponent();
        }

     
        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtcantidad.Text) || int.Parse(txtcantidad.Text) < 0)
            {
                MessageBox.Show("Ingresa un valor diferente de 0");
            }
            else
            {
                cantU = int.Parse(txtcantidad.Text);
                Datos = new Usuarios[cantU];
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                txtnombre.Focus();
            }
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            OrdenamientoB or = new OrdenamientoB(cantU);
            for(int i = 0; i < cantU; i++)
            {
                or.Agregar(Datos[i].nombre, Datos[i].edad);
            }
            or.Burbuja();
            or.Mostrar(dataGridView1);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda bus = new Busqueda(cantU);
            for(int i = 0; i < cantU; i++)
            {
                bus.Agregar(Datos[i].nombre, Datos[i].edad);
            }
            bus.Binaria(txtbusqueda.Text);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (i < cantU)
            {
                Datos[i].nombre = txtnombre.Text;
                Datos[i].edad = int.Parse(txtedad.Text);
                dataGridView1.Rows.Add(Datos[i].nombre, Datos[i].edad);
                i++;
                MessageBox.Show("Se agrego correctamente");
                groupBox3.Enabled = true;
                btnordenar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Limite de usuarios alcanzado");
                groupBox2.Enabled = false;
            }
        }

    }
}
