using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1_GarciaG
{
    public class Objeto
    {}
    class Program
    {
        static void Main(string[] args)
        {
            Stack kk = new Stack();

            kk.Push("Hola");
            kk.Push("Mundo");
            kk.Push("!");
            kk.Push(2);

            //Checa si el object esta en el contenido de la pila
            if (kk.Contains("Mundo"))
                Console.WriteLine("La palabra 'mundo' se encuentra dentro de la pila");


            //Copia los valores de la pila a un nuevo arreglo
            Console.Write("\n\n");
            Object[] arrayEstandar = kk.ToArray();
            Console.WriteLine("Los valores del nuevo arreglo son:");
            foreach (var item in arrayEstandar)
            {
                Console.WriteLine(item);
            }

            //https://codereview.stackexchange.com/questions/60314/console-blackjack-game/60339

            //Retorna el nombre del objeto actual
            Console.Write("\n\n");
            Objeto track = new Objeto();
            Console.WriteLine(kk.ToString());
            Console.WriteLine(track.ToString());
            Console.Write("\n\n");

            //El IEnumerator actua como un "indice" al cual apunta en la
            //posicion actual del objeto y GetEnumerator retorna el valor 
            //actual que hay en la posición que apunta el IEnumerator
            //Es como un tipo foreach que puede ir recorriendo los elementos
            //de una lista
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            IEnumerator<int> indice = lista.GetEnumerator();
            indice.MoveNext();
            Console.WriteLine(indice.Current);
            indice.MoveNext();
            indice.MoveNext();
            Console.WriteLine(indice.Current);

            Console.Write("\n\n");
            Console.WriteLine("El tipo de dato es: " + track.GetType());

            Console.ReadKey();
        }
    }
}


