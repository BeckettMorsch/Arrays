using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] slots = new String[3, 3];
            bool valid = true;
            bool win = false;
            
            String move;
            bool check = false;
            bool check2 = false;
            bool check3 = false;
            bool check4 = false;
            bool check5 = false;
            bool check6 = false;
            bool check7 = false;
            bool check8 = false;
            bool check9 = false;
            int row, col;
            

            Console.WriteLine("    A   B   C  ");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |   |   |   |");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |   |   |   |");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |   |   |   |");
            Console.WriteLine("  +---+---+---+");



            //Space out the board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    slots[i, j] = "   ";
            }

            //TURN 1
            while (check == false && win == false)
            {

                Console.WriteLine("Player X, where do you want to move? :  (number then letter)");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) != "A" && move.Substring(1, 1) != "B" && move.Substring(1, 1) != "C")
                {
                    valid = false;
                    col = 0;
                }
                else if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;

                row = Convert.ToInt32(move.Substring(0, 1)) - 1;
                if (row > 3 || row < 0)
                    valid = false;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }


                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " X ";

                    check = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check = false;
                    Console.WriteLine("That is an invalid move. Try again \n");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
            }















            // TURN 2
            while (check2 == false && win == false)
            {

                Console.WriteLine("Player O, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " O ";

                    check2 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check2 = false;
                    Console.WriteLine("That is an invalid move. Try again \n");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
            }

            //Turn 3
            while (check3 == false && win == false)
            {

                Console.WriteLine("Player X, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " X ";

                    check3 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check3 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }


            }

            //



            //Turn 4
            while (check4 == false && win == false)
            {

                Console.WriteLine("Player O, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " O ";

                    check4 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check4 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
            }

            //Turn 5
            while (check5 == false && win == false)
            {

                Console.WriteLine("Player X, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " X ";

                    check5 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check5 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }

            }

            //Turn 6
            while (check6 == false && win == false)
            {

                Console.WriteLine("Player O, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " O ";

                    check6 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check6 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
            }

            //Turn 7
            while (check7 == false && win == false)
            {

                Console.WriteLine("Player X, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " X ";

                    check7 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check7 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }

            }

            // Turn 8
            while (check8 == false && win == false)
            {

                Console.WriteLine("Player O, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " O ";

                    check8 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check8 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
            }

            //Turn 9
            while (check9 == false && win == false)
            {

                Console.WriteLine("Player X, where do you want to move? : ");
                move = Console.ReadLine();

                // checks if on the board
                if (move != "1A" && move != "1B" && move != "1C" && move != "2A" && move != "2B" && move != "2C" && move != "3A" && move != "3B" && move != "3C")
                    valid = false;
                else
                    valid = true;

                //Assigns row and col
                if (move.Substring(1, 1) == "A")
                    col = 0;
                else if (move.Substring(1, 1) == "B")
                    col = 1;
                else
                    col = 2;
                row = Convert.ToInt32(move.Substring(0, 1)) - 1;

                //checks if something is there
                if (slots[row, col] == " X " || slots[row, col] == " O ")
                {
                    valid = false;
                }

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " X ";

                    check9 = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check9 = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }

                // Win Check
                if ((slots[0, 0] == " X " && slots[0, 1] == " X " && slots[0, 2] == " X ") || (slots[1, 0] == " X " && slots[1, 1] == " X " && slots[1, 2] == " X ") || (slots[2, 0] == " X " && slots[2, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 0] == " X " && slots[2, 0] == " X ") || (slots[0, 1] == " X " && slots[1, 1] == " X " && slots[2, 1] == " X ") || (slots[0, 2] == " X " && slots[1, 2] == " X " && slots[2, 2] == " X ") || (slots[0, 0] == " X " && slots[1, 1] == " X " && slots[2, 2] == " X ") || (slots[0, 2] == " X " && slots[1, 1] == " X " && slots[2, 0] == " X "))
                {
                    Console.WriteLine("Player X Wins!!!!!");
                    win = true;
                }
                else if ((slots[0, 0] == " O " && slots[0, 1] == " O " && slots[0, 2] == " O ") || (slots[1, 0] == " O " && slots[1, 1] == " O " && slots[1, 2] == " O ") || (slots[2, 0] == " O " && slots[2, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 0] == " O " && slots[2, 0] == " O ") || (slots[0, 1] == " O " && slots[1, 1] == " O " && slots[2, 1] == " O ") || (slots[0, 2] == " O " && slots[1, 2] == " O " && slots[2, 2] == " O ") || (slots[0, 0] == " O " && slots[1, 1] == " O " && slots[2, 2] == " O ") || (slots[0, 2] == " O " && slots[1, 1] == " O " && slots[2, 0] == " O "))
                {
                    Console.WriteLine("Player O Wins!!!!!");
                    win = true;
                }
                else
                    Console.WriteLine("Nobody wins, its a tie");
            }


        }
    }
}
