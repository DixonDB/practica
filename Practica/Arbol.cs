using Practica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DixonCruzBlandon.ArbolBalanceado
{
    class Arbol
    {
        //Variables a usar
        public Nodo raiz;

        Graphics nodo;
        Font font;

        int coordenadasX = 740;
        int coordenadasY = 45;
        bool duplicado = false;

        bool existe = false;


        //Sobrecarga de constructores
        public Arbol()
        {

        }
        public Arbol(Nodo nueva)
        {
            raiz = nueva;
        }
        public Arbol(Graphics nodo, Font font)
        {
            this.nodo = nodo;
            this.font = font;
        }


        //Equilibrar
        private int FactorEquilibrio(Nodo x)
        {
            if (x == null)
            {
                return -1;
            }
            else
            {
                return x.fe;
            }
        }


        //Rotaciones
        private Nodo RotacionIzquierda(Nodo x)
        {
            Nodo auxiliar = x.Izquierdo;
            x.Izquierdo = auxiliar.Derecho;
            auxiliar.Derecho = x;
            x.fe = Math.Max(FactorEquilibrio(x.Izquierdo), FactorEquilibrio(x.Derecho)) + 1;
            auxiliar.fe = Math.Max(FactorEquilibrio(auxiliar.Izquierdo), FactorEquilibrio(auxiliar.Derecho)) + 1;
            return auxiliar;
        }
        private Nodo RotacionDerecha(Nodo x)
        {
            Nodo auxiliar = x.Derecho;
            x.Derecho = auxiliar.Izquierdo;
            auxiliar.Izquierdo = x;
            x.fe = Math.Max(FactorEquilibrio(x.Izquierdo), FactorEquilibrio(x.Derecho)) + 1;
            auxiliar.fe = Math.Max(FactorEquilibrio(auxiliar.Izquierdo), FactorEquilibrio(auxiliar.Derecho)) + 1;
            return auxiliar;
        }

        private Nodo DerechaDerecha(Nodo x)
        {
            Nodo temp;
            x.Derecho = RotacionIzquierda(x.Derecho);
            temp = RotacionDerecha(x);
            return temp;
        }

        private Nodo IzquierdaIzquierda(Nodo x)
        {
            Nodo temp;
            x.Izquierdo = RotacionDerecha(x.Izquierdo);
            temp = RotacionIzquierda(x);
            return temp;
        }


        //Insertar Nodo
        private Nodo Insertar(Nodo nuevo, Nodo subArb)
        {
            Nodo nuevoPadre = subArb;

            if (nuevo.numero < subArb.numero)
            {
                if (subArb.Izquierdo == null)
                {
                    subArb.Izquierdo = nuevo;
                }
                else
                {
                    subArb.Izquierdo = Insertar(nuevo, subArb.Izquierdo);
                    if (FactorEquilibrio(subArb.Izquierdo) - FactorEquilibrio(subArb.Derecho) == 2)
                    {
                        if (nuevo.numero < subArb.Izquierdo.numero)
                        {
                            nuevoPadre = RotacionIzquierda(subArb);
                        }
                        else
                        {
                            nuevoPadre = IzquierdaIzquierda(subArb);
                        }
                    }
                }

                duplicado = false;
            }
            else if (nuevo.numero > subArb.numero)
            {
                if (subArb.Derecho == null)
                {
                    subArb.Derecho = nuevo;
                }
                else
                {
                    subArb.Derecho = Insertar(nuevo, subArb.Derecho);
                    if (FactorEquilibrio(subArb.Derecho) - FactorEquilibrio(subArb.Izquierdo) == 2)
                    {
                        if (nuevo.numero > subArb.Derecho.numero)
                        {
                            nuevoPadre = RotacionDerecha(subArb);
                        }
                        else
                        {
                            nuevoPadre = DerechaDerecha(subArb);
                        }
                    }
                }
                duplicado = false;
            }
            else
            {
                duplicado = true;
            }

            if ((subArb.Izquierdo == null) && (subArb.Derecho != null))
            {
                subArb.fe = subArb.Derecho.fe + 1;
            }
            else if ((subArb.Derecho == null) && (subArb.Izquierdo != null))
            {
                subArb.fe = subArb.Izquierdo.fe + 1;
            }
            else
            {
                subArb.fe = Math.Max(FactorEquilibrio(subArb.Izquierdo), FactorEquilibrio(subArb.Derecho)) + 1;
            }
            return nuevoPadre;
        }


        //Insertar
        public bool InsertarDatos(int numero)
        {
            Nodo nuevo = new Nodo(numero);

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                raiz = Insertar(nuevo, raiz);
            }
            return duplicado;
        }


        //Eliminar
        public bool Eliminar(int numero)
        {
            raiz = EliminarNodo(raiz, numero);
            return existe;
        }


        //Eliminar Nodo
        private Nodo EliminarNodo(Nodo Raiz, int numero)
        {
            if (Raiz == null)
            {
                existe = false;
            }
            else if (numero < Raiz.numero)
            {
                Nodo izq = EliminarNodo(Raiz.Izquierdo, numero);
                Raiz.Izquierdo = izq;
            }
            else if (numero > Raiz.numero)
            {
                Nodo der = EliminarNodo(Raiz.Derecho, numero);
                Raiz.Derecho = der;
            }
            else
            {
                Nodo axu = Raiz;

                if (axu.Derecho == null)
                {
                    Raiz = axu.Izquierdo;
                }
                else if (axu.Izquierdo == null)
                {
                    Raiz = axu.Derecho;
                }
                else
                {
                    axu = Cambiar(axu);
                }
                axu = null;
                existe = true;
            }
            return Raiz;
        }


        //Cambiar
        private Nodo Cambiar(Nodo axu)
        {
            Nodo temp = axu, temp2 = axu.Izquierdo;

            while (temp2.Derecho != null)
            {
                temp = temp2;
                temp2 = temp2.Derecho;
            }
            axu.numero = temp2.numero;

            if (temp == axu)
            {
                temp.Izquierdo = temp2.Izquierdo;
            }
            else
            {
                temp.Derecho = temp2.Izquierdo;
            }
            return temp2;
        }


        //Metodo para dibujar el arbol cada vez que haya cambio 
        public void MostrarArbol(PaintEventArgs e, Color c)
        {
            e.Graphics.Clear(c);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nodo = e.Graphics;
            DibujarArbol(nodo, font, Brushes.White, Brushes.Black, Pens.White, Brushes.Black);
        }


        //Dibujar el arbol
        private void DibujarArbol(Graphics grafico, Font fuente, Brush colorRelleno, Brush colorFuente, Pen relacion, Brush borde)
        {
            if (raiz == null)
            {
                return;
            }

            raiz.UbicarNodo(coordenadasX, coordenadasY);
            raiz.DibujarRamas(grafico, relacion);
            raiz.DibujarNodo(grafico, fuente, colorRelleno, colorFuente, relacion, borde);

        }

        //Recorrido InOrden
        public void InOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            InOrden(raiz, lst, lbl);
        }
        public void InOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido InOrden";
                InOrden(temp.Izquierdo, lst, lbl);
                lst.Items.Add(temp.numero.ToString());
                InOrden(temp.Derecho, lst, lbl);
            }
        }


        //Recorrido PosOrden
        public void PosOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PosOrden(raiz, lst, lbl);
        }
        public void PosOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PosOrden";
                PosOrden(temp.Izquierdo, lst, lbl);
                PosOrden(temp.Derecho, lst, lbl);
                lst.Items.Add(temp.numero.ToString());
            }
        }


        //Recorrido PreOrden
        public void PreOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PreOrden(raiz, lst, lbl);
        }
        public void PreOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PreOrden";
                lst.Items.Add(temp.numero.ToString());
                PreOrden(temp.Izquierdo, lst, lbl);
                PreOrden(temp.Derecho, lst, lbl);
            }
        }

    }
}

