using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        private static bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {

                Char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');

            }
            return sw;

        }

        static void Main(string[] args)
        {

            //PROGRAMA CAPICUA
            bool capicua;
            string numero;

            //PilaLista pila = new PilaLista();
            //ColaCircular circula_Cola = new ColaCircular();


            //declaramos el Queue y el Stack
            Queue q = new Queue();
            Stack s = new Stack();
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                                       
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        q.Enqueue(c);//Insertamos los dígitos en la cola
                        s.Push(c);//Insertamos los dígitos en la pila

                        //circula_Cola.insertar(c);
                        //pila.insertar(c);

                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)q.Dequeue();//quita de la cola la primera cadena
                        capicua = d.Equals(s.Pop()); //Elimina y devuelve el objeto en la parte superior de la pila y compara la igualdad

                        //d = (Char)circula_Cola.quitar();
                        //capicua = d.Equals(pila.quitar()); //compara la igualdad

                    } while (capicua && q.Count != 0);//contamos los dígitos mientras sea diferente a 0

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }

                    // vaciamos la estructura de cola y pila
                    q.Clear();
                    s.Clear();

                    //circula_Cola.borrarCola(); 
                    //pila.limpiarPila();
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }            
        }
    }
}
//Queue qt = new Queue();
//qt.Enqueue("Hola");
//qt.Enqueue("esta");
//qt.Enqueue("es");
//qt.Enqueue("una");
//qt.Enqueue("prueba");

//Console.WriteLine($"La Cola tiene {qt.Count} elementos");
//Console.WriteLine($"Desencolando {qt.Dequeue()}");
//Console.WriteLine($"Ahora la cola tiene {qt.Count} elementos");
//Console.WriteLine($"Desencolando {qt.Dequeue()}");
//Console.WriteLine($"Ahora la cola tiene {qt.Count} elementos");
//Console.WriteLine($"Desencolando {qt.Dequeue()}");
//Console.WriteLine($"Ahora la cola tiene {qt.Count} elementos");
