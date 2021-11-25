using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    class Busqueda
    {

        public string[] nombre;
        public int[] edad;
        int i = 0, cantC;

        public Busqueda(int cantidad)
        {
            cantC = cantidad;
            nombre= new string[cantidad];
            edad = new int[cantidad];
        }
        public void Agregar(string nom, int ed)
        {
            if (i < cantC)
            {
                this.nombre[i] = nom;
                this.edad[i] = ed;
                i++;
            }
        }
        public void Binaria(string x)
        {
            int izq, der, cen = 0;
            bool ban;
            izq = 0;
            der = cantC - 1;
            ban = false;
           while(izq<=der && ban == false)
            {
                if (x == nombre[cen])
                {
                    ban = true;
                }
                else
                {
                    cen++;
                }
                if (nombre[cen].CompareTo(x) > 0)
                {
                    izq = cen + 1;
                }
                else
                {
                    der = cen - 1;
                }
            }
           if(ban== true)
            {
                MessageBox.Show(string.Format("\n\nInformacion: \n-Nombre: {0} \n-Edad: {1}", nombre[cen], edad[cen]), "Busqueda encontrada");
            }
            else
            {
                MessageBox.Show("La informacion no ha sido encontrada");
            }
        }

    }
}
