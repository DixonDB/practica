using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    class OrdenamientoB
    {
        //se declaran todas las variables 
        public string[] nombre;
        int cantidad, i = 0;
        public int[] edad;

        public OrdenamientoB(int Cant)
        {
            this.cantidad = Cant;
            nombre = new string[Cant];
            edad = new int[Cant];
        }
        public void Agregar(string nom, int ed)
        {
            if (i < cantidad)
            {
                this.nombre[i] = nom;
                this.edad[i] = ed;
                i++;
            }            
        }
        public void Burbuja()
        {
            string auxinombre;
            int auxiedad;
            for (i = 0; i < cantidad; i++)
            {
                for(int j = i + 1; j < cantidad; j++)
                {
                    if (edad[i].CompareTo(edad[j]) <= 0)
                    {
                        auxinombre = nombre[i];
                        nombre[i] = nombre[j];
                        nombre[j] = auxinombre;

                        auxiedad = edad[i];
                        edad[i] = edad[j];
                        edad[j] = auxiedad;
                    }
                }
            }
        }
        public void Mostrar(DataGridView data)
        {
            data.Rows.Clear();
            for(int i = 0; i < cantidad; i++)
            {
                data.Rows.Add(nombre[i], edad[i]);
            }
        }
    }
}
