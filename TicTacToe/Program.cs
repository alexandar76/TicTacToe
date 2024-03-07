using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string[,] array2d = new string[,]
            {
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
            };


        
        static bool finish = false;

        static bool check = true;
        static int turns = 0;
        


        static void Main(string[] args)
        {

            SetField();
            do
            {
                
                Work1();

                Winner1();

                if (check == false)
                {
                    Console.WriteLine("Please use another field");
                    check = true;
                    turns--;
                    continue;

                }

                if (turns == 9)
                {
                    if (finish != true)
                    {
                        Console.WriteLine("There is no winner");
                        Console.WriteLine("Press any Key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

           

                if (finish == true)
                {
                    Console.WriteLine("Press any Key to Reset the Game");
                    Console.ReadKey();
                    ResetField();
                    break;
                }

                Work2();
                Winner2();
                if (check == false)
                {
                    Console.WriteLine("Please use another field");
                    check = true;
                    turns--;
                    Work2();
                    Winner2();
                    if (check == false)
                    {
                        Console.WriteLine("Please use another field");
                        check = true;
                        turns--;
                        Work2();
                        Winner2();
                        if (check == false)
                        {
                            Console.WriteLine("Please use another field");
                            check = true;
                            turns--;
                            Work2();
                            Winner2();
                            continue;
                        }
                    }


                }
                if (finish == true)
                {
                    Console.WriteLine("Press any Key to Reset the Game");
                    Console.ReadKey();
                    ResetField();
                    break;
                }




            }
            while (!finish);
            Console.ReadLine();
        }

        public static void ResetField()
        {
            array2d[0, 0] = "1";
            array2d[0, 1] = "2";
            array2d[0, 2] = "3";
            array2d[1, 0] = "4";
            array2d[1, 1] = "5";
            array2d[1, 2] = "6";
            array2d[2, 0] = "7";
            array2d[2, 1] = "8";
            array2d[2, 2] = "9";

            finish = false;
            
            Console.Clear();
            
            SetField();
            turns = 0;
            do
            {

                Work1();

                Winner1();

                if (check == false)
                {
                    Console.WriteLine("Please use another field");
                    check = true;
                    turns--;
                    continue;

                }



                if (turns == 9)
                {
                    if (finish != true)
                    {
                        Console.WriteLine("There is no winner");
                        Console.WriteLine("Press any Key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }


                if (finish == true)
                {
                    Console.WriteLine("Press any Key to Reset the Game");
                    Console.ReadKey();
                    ResetField();
                   
                    break;
                }

                Work2();
                Winner2();
                if (check == false)
                {
                    Console.WriteLine("Please use another field");
                    check = true;
                    turns--;
                    Work2();
                    Winner2();
                    if (check == false)
                    {
                        Console.WriteLine("Please use another field");
                        check = true;
                        turns--;
                        Work2();
                        Winner2();
                        if (check == false)
                        {
                            Console.WriteLine("Please use another field");
                            check = true;
                            turns--;
                            Work2();
                            Winner2();
                            continue;
                        }
                    }


                }
                if (finish == true)
                {
                    Console.WriteLine("Press any Key to Reset the Game");
                    Console.ReadKey();
                    ResetField();
                    break;
                }




            }
            while (!finish);




        }

        public static void SetField()
        {

            

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array2d[0,0], array2d[0, 1], array2d[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array2d[1, 0], array2d[1, 1], array2d[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");            
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array2d[2, 0], array2d[2, 1], array2d[2, 2]);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("");
       
        }

   



        public static void Work1()
        {
          
           
                Console.WriteLine("Player 1: Choose your field!");
                string num = Console.ReadLine();
            if (num != ""  && num == "1" || num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7" || num == "8" || num == "9")
            {


                if (num == "1" && array2d[0, 0] == "O")
                {
                    check = false;
                }

                if (num == "1" && array2d[0, 0] == "X")
                {
                    check = false;
                }
                if (num == "2" && array2d[0, 1] == "O")
                {
                    check = false;
                }
                if (num == "2" && array2d[0, 1] == "X")
                {
                    check = false;
                }
                if (num == "3" && array2d[0, 2] == "O")
                {
                    check = false;
                }
                if (num == "3" && array2d[0, 2] == "X")
                {
                    check = false;
                }
                if (num == "4" && array2d[1, 0] == "O")
                {
                    check = false;
                }
                if (num == "4" && array2d[1, 0] == "X")
                {
                    check = false;
                }
                if (num == "5" && array2d[1, 1] == "O")
                {
                    check = false;
                }
                if (num == "5" && array2d[1, 1] == "X")
                {
                    check = false;
                }
                if (num == "6" && array2d[1, 2] == "O")
                {
                    check = false;
                }
                if (num == "6" && array2d[1, 2] == "X")
                {
                    check = false;
                }
                if (num == "7" && array2d[2, 0] == "O")
                {
                    check = false;
                }
                if (num == "7" && array2d[2, 0] == "X")
                {
                    check = false;
                }
                if (num == "8" && array2d[2, 1] == "O")
                {
                    check = false;
                }
                if (num == "8" && array2d[2, 1] == "X")
                {
                    check = false;
                }
                if (num == "9" && array2d[2, 2] == "O")
                {
                    check = false;
                }
                if (num == "9" && array2d[2, 2] == "X")
                {
                    check = false;
                }
            }
            else
            {
                Console.Clear();
                SetField();
                Console.WriteLine("Please input number 1-9");
                turns--;
                Work1();
            }

         

                if (check == true)
            {
                switch (num)
                {

                    case "1":
                        array2d[0, 0] = "O";
                        break;
                    case "2":
                        array2d[0, 1] = "O";
                        break;
                    case "3":
                        array2d[0, 2] = "O";
                        break;
                    case "4":
                        array2d[1, 0] = "O";
                        break;
                    case "5":
                        array2d[1, 1] = "O";
                        break;
                    case "6":
                        array2d[1, 2] = "O";
                        break;
                    case "7":
                        array2d[2, 0] = "O";
                        break;
                    case "8":
                        array2d[2, 1] = "O";
                        break;
                    case "9":
                        array2d[2, 2] = "O";
                        break;
                }
            }

            turns++;


            Console.Clear();
                SetField();
            
         
        }

        public static void Work2()
        {

           
                Console.WriteLine("Player 2: Choose your field!");
                string num = Console.ReadLine();
            if (num != "" && num == "1" || num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7" || num == "8" || num == "9")
            {

                if (num == "1" && array2d[0, 0] == "X")
                {
                    check = false;
                }
                if (num == "1" && array2d[0, 0] == "O")
                {
                    check = false;
                }
                if (num == "2" && array2d[0, 1] == "X")
                {
                    check = false;
                }
                if (num == "2" && array2d[0, 1] == "O")
                {
                    check = false;
                }
                if (num == "3" && array2d[0, 2] == "X")
                {
                    check = false;
                }
                if (num == "3" && array2d[0, 2] == "O")
                {
                    check = false;
                }
                if (num == "4" && array2d[1, 0] == "X")
                {
                    check = false;
                }
                if (num == "4" && array2d[1, 0] == "O")
                {
                    check = false;
                }
                if (num == "5" && array2d[1, 1] == "X")
                {
                    check = false;
                }
                if (num == "5" && array2d[1, 1] == "O")
                {
                    check = false;
                }
                if (num == "6" && array2d[1, 2] == "X")
                {
                    check = false;
                }
                if (num == "6" && array2d[1, 2] == "O")
                {
                    check = false;
                }
                if (num == "7" && array2d[2, 0] == "X")
                {
                    check = false;
                }
                if (num == "7" && array2d[2, 0] == "O")
                {
                    check = false;
                }
                if (num == "8" && array2d[2, 1] == "X")
                {
                    check = false;
                }
                if (num == "8" && array2d[2, 1] == "O")
                {
                    check = false;
                }
                if (num == "9" && array2d[2, 2] == "X")
                {
                    check = false;
                }
                if (num == "9" && array2d[2, 2] == "O")
                {
                    check = false;
                }
            }
            else
            {
                Console.Clear();
                SetField();
                Console.WriteLine("Please input number 1-9");
                turns--;
                Work2();
            }

            if (check == true)
            {
                switch (num)
                {
                    case "1":
                        array2d[0, 0] = "X";
                        break;
                    case "2":
                        array2d[0, 1] = "X";
                        break;
                    case "3":
                        array2d[0, 2] = "X";
                        break;
                    case "4":
                        array2d[1, 0] = "X";
                        break;
                    case "5":
                        array2d[1, 1] = "X";
                        break;
                    case "6":
                        array2d[1, 2] = "X";
                        break;
                    case "7":
                        array2d[2, 0] = "X";
                        break;
                    case "8":
                        array2d[2, 1] = "X";
                        break;
                    case "9":
                        array2d[2, 2] = "X";
                        break;
                }
            }
            turns++;
            Console.Clear();
                SetField();
            }

        public static void Winner1()
        {
          
                if (array2d[0, 0] == "O" && array2d[0, 1] == "O" && array2d[0, 2] == "O" && finish == false)
                {
              
                Console.WriteLine("Player 1 win");
                
                finish = true;
                   
                }
                if(array2d[1, 0] == "O" && array2d[1, 1] == "O" && array2d[1, 2] == "O" && finish == false)
                {
                    Console.WriteLine("Player 1 win");

                finish = true;

            }
            if (array2d[2, 0] == "O" && array2d[2, 1] == "O" && array2d[2, 2] == "O" && finish == false)
            {
                    Console.WriteLine("Player 1 win");

                finish = true;

            }
            if (array2d[0, 0] == "O" && array2d[1, 0] == "O" && array2d[2, 0] == "O" && finish == false)
            {
                Console.WriteLine("Player 1 win");

                finish = true;

            }
            if (array2d[0, 1] == "O" && array2d[1, 1] == "O" && array2d[2, 1] == "O" && finish == false)
            {
                Console.WriteLine("Player 1 win");

                finish = true;

            }
            if (array2d[0, 2] == "O" && array2d[1, 2] == "O" && array2d[2, 2] == "O" && finish == false)
            {
                Console.WriteLine("Player 1 win");

                finish = true;

            }

            if (array2d[0, 0] == "O" && array2d[1, 1] == "O" && array2d[2, 2] == "O" && finish == false)
            {
                Console.WriteLine("Player 1 win");

                finish = true;

            }
            if (array2d[0, 2] == "O" && array2d[1, 1] == "O" && array2d[2, 0] == "O" && finish == false)
            {
                Console.WriteLine("Player 1 win");

                finish = true;

            }

        }

        public static void Winner2()
        {

            if (array2d[0, 0] == "X" && array2d[0, 1] == "X" && array2d[0, 2] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[1, 0] == "X" && array2d[1, 1] == "X" && array2d[1, 2] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[2, 0] == "X" && array2d[2, 1] == "X" && array2d[2, 2] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[0, 0] == "X" && array2d[1, 0] == "X" && array2d[2, 0] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[0, 1] == "X" && array2d[1, 1] == "X" && array2d[2, 1] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[0, 2] == "X" && array2d[1, 2] == "X" && array2d[2, 2] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[0, 0] == "X" && array2d[1, 1] == "X" && array2d[2, 2] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }
            if (array2d[0, 2] == "X" && array2d[1, 1] == "X" && array2d[2, 0] == "X" && finish == false)
            {
                Console.WriteLine("Player 2 win");

                finish = true;

            }


        }

    }
}
