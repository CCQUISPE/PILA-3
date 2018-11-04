using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PILA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Console.Clear();
            Console.WriteLine("\n El sigeuinte programa imprime las vocales \n");
            string frase;
            
            Stack miPila = new Stack();
            miPila.Push("A");
            miPila.Push("E");
            miPila.Push("I");
            miPila.Push("O");
            miPila.Push("U");

            
            for (byte i = 0; i < 5; i++) // arma el buclne para recorrer la pila
            {
                frase = (string)miPila.Pop(); 
                Console.WriteLine(frase);         // imprime por pantalla

            }
            Console.ReadKey();
            
        }
    }
}
