using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsCA
{
    public class Anagrams
    {
        Anagrams Word;
        public bool anag;
        public string Ana;

            public Anagrams(string ana, bool Anag)
        {
     
            this.Ana = ana;
        }

        public static (string, string) Mina()
        {
            string word= "Palabra: Mina";
            string ana = "Iman, Mani";
           
            return (word, ana);
        }

        public static (string, string) Estudiar()
        {
            string word1 = "Palabra: Estudiar";
            string ana1 = "Aduriste, Destruia, Eruditas, Esturdia, Redituas";

            return (word1, ana1);
        }

        public static (string, string) Saltar()
        {
            string word2 = "Palabra: Saltar";
            string ana2 = "Astral, Lastar, Lastra, Saltar, Sartal";

            return (word2, ana2);
        }

        static void Main()
        {


            Console.WriteLine("De que palabra desea saber el anagrama?");
            Console.WriteLine("1)Mina \n  2)Estudiar \n 3)Saltar");
            Console.WriteLine("Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine("Anagrama:");

                    var (word, ana) = Mina();

                    Console.WriteLine(word);
                    Console.WriteLine(ana);
                    break;
                case '2':
                    Console.WriteLine("Anagrama:");
                    var (word1, ana1) = Estudiar();

                    Console.WriteLine(word1);
                    Console.WriteLine(ana1);
                    break;
                case '3':
                    Console.WriteLine("Anagrama:");
                    var (word2, ana2) = Saltar();

                    Console.WriteLine(word2);
                    Console.WriteLine(ana2);
                    break;
            }
            Console.ReadKey();
        }


    }
   
    
    
}
