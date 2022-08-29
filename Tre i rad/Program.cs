using System;

namespace Tre_i_rad
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string tal1 = " ";
            string tal2 = " ";
            string tal3 = " ";
            string tal4 = " ";
            string tal5 = " ";
            string tal6 = " ";
            string tal7 = " ";
            string tal8 = " ";
            string tal9 = " ";
            string tur = "X";
            double numer = 0;
            bool kor =false;

        while(kor==false) {
        

            Console.Write("[1] [2] [3]  |  ");
            Console.WriteLine("["+tal1+"] ["+tal2+"] ["+tal3+"]");
            Console.Write("[4] [5] [6]  |  ");
            Console.WriteLine("["+tal4+"] ["+tal5+"] ["+tal6+"]");
            Console.Write("[7] [8] [9]  |  ");
            Console.WriteLine("["+tal7+"] ["+tal8+"] ["+tal9+"]");
            Console.WriteLine(""); 

            Console.Write("Skriv ett tal: ");
            numer = double.Parse(Console.ReadLine());

            if(tur == "X")
             if (numer == 1 )   
                if (tal1 == " ")
                    tal1 = "X";
             else if (numer == 2 )
                if (tal2 == " ")
                    tal2 = "X";
             else if (numer == 3 )
                if (tal3 == " ")
                    tal3 = "X";
             else if (numer == 4 )
                if (tal4 == " ")
                    tal4 = "X";
             else if (numer == 5 )
                if (tal5 == " ")
                    tal5 = "X";
             else if (numer == 6 )
                if (tal6 == " ")
                    tal6 = "X";
             else if (numer == 7 )
                if (tal7 == " ")
                    tal7 = "X";
             else if (numer == 8 )
                if (tal8 == " ")
                    tal8 = "X";
             else if (numer == 9 )
                if (tal9 == " ")
                    tal9 = "X";
                else
                    Console.WriteLine("Den är redan tagen ta en annan:");
            else
                Console.WriteLine("Finns inget som är "+numer);

            if(tur == "O")
             if (numer == 1 )   
                if (tal1 == " ")
                    tal1 = "O";
             else if (numer == 2 )
                if (tal2 == " ")
                    tal2 = "O";
             else if (numer == 3 )
                if (tal3 == " ")
                    tal3 = "O";
             else if (numer == 4 )
                if (tal4 == " ")
                    tal4 = "O";
             else if (numer == 5 )
                if (tal5 == " ")
                    tal5 = "O";
             else if (numer == 6 )
                if (tal6 == " ")
                    tal6 = "O";
             else if (numer == 7 )
                if (tal7 == " ")
                    tal7 = "O";
             else if (numer == 8 )
                if (tal8 == " ")
                    tal8 = "O";
             else if (numer == 9 )
                if (tal9 == " ")
                    tal9 = "O";
                else
                    Console.WriteLine("Den är redan tagen ta en annan:");
            else
                Console.WriteLine("Finns inget som är "+numer);
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("[1] [2] [3]  |  ");
            Console.WriteLine("["+tal1+"] ["+tal2+"] ["+tal3+"]");
            Console.Write("[4] [5] [6]  |  ");
            Console.WriteLine("["+tal4+"] ["+tal5+"] ["+tal6+"]");
            Console.Write("[7] [8] [9]  |  ");
            Console.WriteLine("["+tal7+"] ["+tal8+"] ["+tal9+"]");
            Console.WriteLine(""); 

            tur = "O";
        
        }

        }
    }
}
