using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
        //operaciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaLlena())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }

        //Limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }
    }//end class
}
