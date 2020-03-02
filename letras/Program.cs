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


          


            Dictionary<char, int> myDic = new Dictionary<char, int>();



           

            foreach (var mychar in lista)



            {
                if (!myDic.ContainsKey(mychar))
                
                    myDic.Add(mychar, 1);
                
                else
                {
                    myDic[mychar]++;
                }
            }
        

            foreach (var mychar in myDic)
            {
                Console.WriteLine(mychar);
            }
    Console.Read();
            
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
