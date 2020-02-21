using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTRACOSA
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Ejercicio letras repetidas");

            //Fase1 


            char[] letra = new char[8];

            letra[0] = 'g';
            letra[1] = 'a';
            letra[2] = 'b';
            letra[3] = 'r';
            letra[4] = 'i';
            letra[5] = 'e';
            letra[6] = 'l';
            letra[7] = 'a';

           


            for (int i = 0; i < letra.Length; i++)
            {
                Console.WriteLine(letra[i]);

            }

            Console.ReadKey();


            //Fase 2

            List<char> lista = new List<char>();
            lista.Add('g');
            lista.Add('a');
            lista.Add('b');
            lista.Add('r');
            lista.Add('i');
            lista.Add('e');
            lista.Add('l');
            lista.Add('a');

           

            for (int i = 0; i < letra.Length; i++)

            {
                Console.WriteLine(letra[i]);


                if (letra[i] == 'a' || letra[i] == 'e' || letra[i] == 'i' || letra[i] == 'o' || letra[i] == 'u')
                {
                    Console.WriteLine(" vocal");
                }

                else
                {
                    Console.WriteLine("consonante");
                }


            }

            Console.ReadKey();

            //Fase 3 Dictionary y cuantas veces aparece cada caracter

            Dictionary<string, int> letras = new Dictionary<string, int>();


            letras.Add("g", 1);
            letras.Add("a", 2);
            letras.Add("b", 1);
            letras.Add("r", 1);
            letras.Add("i", 1);
            letras.Add("e", 1);
            letras.Add("l", 1);



            foreach (KeyValuePair<string, int> product in letras)
            {

                Console.WriteLine("letra:  " + product.Key + " " + "cantidad de veces que se muestra:  " + " " + product.Value);
            }
            Console.ReadKey();





            //Fase 4 unir dos listas 

            List<char> apellido = new List<char>();
            apellido.Add(' ');
            apellido.Add('d');
            apellido.Add('u');
            apellido.Add('q');
            apellido.Add('u');
            apellido.Add('e');

           

            Console.ReadKey();

            List<char> query = lista.Concat(apellido).ToList();
            query.ForEach(item => System.Console.WriteLine(item));
            Console.ReadKey();




        }
}
    }

