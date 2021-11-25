using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Nodo
    {
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public int fe;
        public int numero;

        //para dibujar
        int coordenadasX = 80,
            coordenadasY = 20,
            coordenadaXDerecha,
            coordenadaYDerecha,
            elipse = 35;

        public int nivel { get; set; }
        public Nodo()
        {

        }
        public Nodo(int dt)
        {
            numero = dt;
            fe = 0;
            Izquierdo = null;
            Derecho = null;
        }
        public Nodo(int dat, Nodo izquierdo,Nodo derecho, Nodo padre)
        {
            numero = dat;
            this.Izquierdo = izquierdo;
            this.Derecho = derecho;
        }
        public void UbicarNodo(int posX, int posY)
        {
            int auxiliar1,
                auxiliar2;
            coordenadaYDerecha = Convert.ToInt32(posY + elipse / 2);
            if(Izquierdo!= null)
            {
                Izquierdo.UbicarNodo(posX, posY + elipse + coordenadasY);
            }
            if((Izquierdo != null) && (Derecho != null))
            {
                posX += coordenadasX;
            }
            if (Derecho != null)
            {
                Derecho.UbicarNodo(posX, posY + elipse + coordenadasY);
            }
            if(Izquierdo !=null && Derecho != null)
            {
                coordenadaXDerecha = Convert.ToInt32((Izquierdo.coordenadaXDerecha + Derecho.coordenadaXDerecha) / 2);
            }
            else if(Izquierdo!= null)
            {
                auxiliar1 = Izquierdo.coordenadaXDerecha;
                Izquierdo.coordenadaXDerecha = coordenadaXDerecha - 80;
                coordenadaXDerecha = auxiliar1;
            }
            else if(Derecho != null)
            {
                auxiliar2 = Derecho.coordenadaXDerecha;
                Derecho.coordenadaXDerecha = coordenadaXDerecha + 80;
                coordenadaXDerecha = auxiliar2;
            }
            else
            {
                coordenadaXDerecha = Convert.ToInt32(posX + elipse / 2);
                posX += elipse;
            }
        }
        public void DibujarRamas(Graphics grafico, Pen relacion)
        {
            if(Izquierdo!= null)
            {
                grafico.DrawLine(relacion, coordenadaXDerecha, coordenadaYDerecha, Izquierdo.coordenadaXDerecha, Izquierdo.coordenadaYDerecha);
                Izquierdo.DibujarRamas(grafico, relacion);
            }
            if (Derecho != null)
            {
                grafico.DrawLine(relacion, coordenadaXDerecha, coordenadaYDerecha, Derecho.coordenadaXDerecha, Derecho.coordenadaYDerecha);
                Derecho.DibujarRamas(grafico, relacion);
            }
        }
        public void DibujarNodo(Graphics grafico, Font fuente, Brush color, Brush colofuente, Pen relacion, Brush B)
        {
            Rectangle temp = new Rectangle(Convert.ToInt32(coordenadaXDerecha - elipse / 2),
                Convert.ToInt32(coordenadaYDerecha - elipse / 2), elipse, elipse);

            grafico.FillEllipse(B, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);

            StringFormat formto = new StringFormat();
            formto.Alignment = StringAlignment.Center;
            formto.LineAlignment = StringAlignment.Center;

            grafico.DrawString(numero.ToString(), fuente, colofuente, coordenadaXDerecha,
                coordenadaYDerecha, formto);
            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafico, fuente, color, colofuente,
                    relacion, B);
            }
            if(Derecho!= null)
            {
                Derecho.DibujarNodo(grafico, fuente, color,
                    colofuente, relacion, B);
            }
        }
    }
}
