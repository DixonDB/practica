using DixonCruzBlandon.ArbolBalanceado;
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
    public partial class Arboles : Form
    {
        int aux, posX, posY, i = 0, cantC;
        public struct Usuario{
            public string nombre { get; set; }
            public int numero { get; set; }
        }
       
        Usuario[] dato;

        
       
        Arbol arbol;
        Graphics nodo;
        public Arboles()
        {
            InitializeComponent();
            nodo = CreateGraphics();
            arbol = new Arbol(nodo, Font);
        }
        private void Arboles_Paint(object sender, PaintEventArgs e)
        {
            arbol.MostrarArbol(e, this.BackColor);
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            try
            {
                cantC = Convert.ToInt32(txtcantidad.Text);
                aux = 0;

                if (cantC < 0 || txtcantidad.Text.Length > 8)
                {
                    MessageBox.Show("Cantidad ingresada no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dato = new Usuario[cantC];
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cantidad ingresada no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            arbol.InOrden(lstRecorridos, lblRecorridos);
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            arbol.PosOrden(lstRecorridos, lblRecorridos);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.PreOrden(lstRecorridos, lblRecorridos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txteliminar.Text);
            if (arbol.Eliminar(x))
            {
                EliminarData(x);
                Refresh();
            }
            else
            {
                MessageBox.Show("No se encontro el nodo");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (i < cantC)
            {

                try
                {
                    dato = new Usuario[cantC];
                    dato[i].nombre = txtnombre.Text;
                    dato[i].numero = Convert.ToInt32(txtedad.Text);
                    if (arbol.InsertarDatos(dato[i].numero))
                    {
                        MessageBox.Show("No se pueden insertar datos duplicados");
                        txtedad.Clear();
                        txtedad.Focus();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(dato[i].nombre, dato[i].numero);
                        Refresh();
                        Limpiar();
                        i++;
                        aux++;
                    }
                    if (i > 0)
                    {
                        gbRecorridos.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error"+ex);
                }
                
            }
            else
            {
                MessageBox.Show("Limite alcanzado");
            }
        }
        public void EliminarData(int x)
        {
            bool encontrado = false;
            for(int i=0;i<dato.Length-1; i++)
            {
                if (x == dato[i].numero)
                {
                    for(int j=0; j < dato.Length - 1; j++)
                    {
                        dato[j].nombre = dato[j + 1].nombre;
                        dato[j].numero = dato[j + 1].numero;

                        if (j == dato.Length - 1)
                        {
                            dato[j].nombre = null;
                            dato[j].numero = Convert.ToInt32( null);
                        }
                    }
                    encontrado = true;
                }
            }
            if (encontrado) i--;aux--;
            dataGridView1.Rows.Clear();
            for(int j=0; j < aux; j++)
            {
                dataGridView1.Rows.Add(dato[j].nombre, dato[j].numero);
            }
        }
        public void Limpiar()
        {
            txtedad.Clear();
            txtnombre.Clear();
        }
    }
}
