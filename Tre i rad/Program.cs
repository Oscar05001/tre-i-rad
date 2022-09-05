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
            string vinn = "X";
            bool gol = false;

            Console.Write("[1] [2] [3]  |  ");
            Console.WriteLine("["+tal1+"] ["+tal2+"] ["+tal3+"]");
            Console.Write("[4] [5] [6]  |  ");
            Console.WriteLine("["+tal4+"] ["+tal5+"] ["+tal6+"]");
            Console.Write("[7] [8] [9]  |  ");
            Console.WriteLine("["+tal7+"] ["+tal8+"] ["+tal9+"]");
            Console.WriteLine(""); 


        while(kor==false) {

            Console.Clear();


            Console.Write("[1] [2] [3]  |  ");
            Console.WriteLine("["+tal1+"] ["+tal2+"] ["+tal3+"]");
            Console.Write("[4] [5] [6]  |  ");
            Console.WriteLine("["+tal4+"] ["+tal5+"] ["+tal6+"]");
            Console.Write("[7] [8] [9]  |  ");
            Console.WriteLine("["+tal7+"] ["+tal8+"] ["+tal9+"]");
            Console.WriteLine(""); 


            while(gol == false)
            {
            Console.Write("Skriv ett numer: ");
            numer = double.Parse(Console.ReadLine());

           

            if(tur == "X"){
             if (numer == 1 )   
                if (tal1 == " "){
                        tal1 = "X";
                        break;
                }
             if (numer == 2 )
                if (tal2 == " "){
                        tal2 = "X";
                        break;
                }
            if (numer == 3 )
                if (tal3 == " "){
                        tal3 = "X";
                        break;
                }
            if (numer == 4 )
                if (tal4 == " "){
                        tal4 = "X";
                        break;
                }
            if (numer == 5 )
                if (tal5 == " "){
                        tal5 = "X";
                        break;
                }
            if (numer == 6 )
                if (tal6 == " "){
                        tal6 = "X";
                        break;
                }
             if (numer == 7 )
                if (tal7 == " "){
                        tal7 = "X";
                        break;
                }
             if (numer == 8 )
                if (tal8 == " "){
                        tal8 = "X";
                        break;
                }
             if (numer == 9 )
                if (tal9 == " "){
                        tal9 = "X";
                        break;
                }
            
                else{
                    Console.Clear();
                    Console.WriteLine("Den är redan tagen ta en annan:");
                }
            }   
            else
                Console.WriteLine("Finns inget som är "+numer);

            if(tur == "O"){
                if (numer == 1 )
                    if (tal1 == " "){
                            tal1 = "O";
                            break;
                    }
                if (numer == 2 )
                    if (tal2 == " "){
                            tal2 = "O";
                            break;
                    }
                if (numer == 3 )
                    if (tal3 == " "){
                            tal3 = "O";
                            break;
                    }
                if (numer == 4 )
                    if (tal4 == " "){
                            tal4 = "O";
                            break;
                    }
                if (numer == 5 )
                    if (tal5 == " "){
                            tal5 = "O";
                            break;
                    }
                if (numer == 6 )
                    if (tal6 == " "){
                            tal6 = "O";
                            break;
                    }
                if (numer == 7 )
                    if (tal7 == " "){
                            tal7 = "O";
                            break;
                    }
                if (numer == 8 )
                    if (tal8 == " "){
                            tal8 = "O";
                            break;
                    }
                if (numer == 9 )
                    if (tal9 == " "){
                            tal9 = "O";
                            break;
                    }
                else{
                    Console.Clear();
                    Console.WriteLine("Den är redan tagen ta en annan:");
                }
                }
                else
                    Console.WriteLine("Finns inget som är "+numer);

            }
            if(tal1=="X" && tal2=="X" && tal3=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal4=="X" && tal5=="X" && tal6=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal7=="X" && tal8=="X" && tal9=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal1=="X" && tal5=="X" && tal9=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal3=="X" && tal5=="X" && tal7=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal3=="X" && tal6=="X" && tal9=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal2=="X" && tal5=="X" && tal8=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal1=="X" && tal4=="X" && tal7=="X"){
                kor = true;
                vinn = "X";
            }
            if(tal3=="X" && tal6=="X" && tal9=="X"){
                kor = true;
                vinn = "X";
            }

                 if(tal1=="O" && tal2=="O" && tal3=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal4=="O" && tal5=="O" && tal6=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal7=="X" && tal8=="O" && tal9=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal1=="O" && tal5=="O" && tal9=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal3=="O" && tal5=="O" && tal7=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal3=="O" && tal6=="O" && tal9=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal2=="O" && tal5=="O" && tal8=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal1=="O" && tal4=="O" && tal7=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal3=="O" && tal6=="O" && tal9=="O"){
                kor = true;
                vinn = "O";
            }
            if(tal1 != " " && tal2 != " " && tal3 != " " && tal4 != " " && tal5 != " " && tal6 != " " && tal7 != " " && tal8 != " " && tal9 != " "){
                kor=true;
                vinn="?";
            }
       
            
            
            if(tur=="X")
                tur="O";
            else
            {
                tur="X";
            }


        }
            Console.Clear();
            Console.Write("[1] [2] [3]  |  ");
            Console.WriteLine("["+tal1+"] ["+tal2+"] ["+tal3+"]");
            Console.Write("[4] [5] [6]  |  ");
            Console.WriteLine("["+tal4+"] ["+tal5+"] ["+tal6+"]");
            Console.Write("[7] [8] [9]  |  ");
            Console.WriteLine("["+tal7+"] ["+tal8+"] ["+tal9+"]");
            Console.WriteLine(""); 

        if(vinn == "X")
            Console.WriteLine("Yay X vann!");
        if(vinn == "O")
            Console.WriteLine("Yay O vann!");
        if(vinn == "?")
            Console.WriteLine("Det blev lika.");

        }
    }
}
