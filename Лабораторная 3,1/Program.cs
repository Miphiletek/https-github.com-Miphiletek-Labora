using System;

namespace Лабораторная_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take number");
             string proverka = Console.ReadLine();
            Proverka(proverka);
            string chislo = proverka;
            
           

                Palidrom1(chislo);
            
            
            
          

        }

        public static void Palidrom1(string chislo2)
        {
            char[] arr = chislo2.ToCharArray();
            Array.Reverse(arr);
            string rez = new string(arr);


            if (chislo2 == rez)
            {
                Console.WriteLine("Palidrom");
            }
            else
            {
                Console.WriteLine("Error 245");
            }
        }
           public static string Proverka(string proverka1)
        {
            if (proverka1.Length < 3)
            {
                Console.WriteLine("Маленькое количество символов");
                Console.Write("Reload Call");
                return Console.ReadLine();




            }
            else
            {



                

               return proverka1 ;
            }
          


        }

    }

}



        
      
       
    

