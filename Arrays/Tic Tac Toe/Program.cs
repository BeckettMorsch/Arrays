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
            String[,] slots = new String[3,3];
            bool valid = true;
            bool win = false;
            bool draw = false;
            String move;
            bool check = false;
            int row, col;
            String there = "";
            String first;
            String second;
            String sCol;

            Console.WriteLine("    A   B   C  ");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |   |   |   |");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |   |   |   |");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |   |   |   |");
            Console.WriteLine("  +---+---+---+");

            

            //Space out the board
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                   slots[i, j] = "   ";
            }

            //TURN 1
            while (check == false && win == false) 
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
                row = Convert.ToInt32(move.Substring(0, 1)) -1;

                /*/ checks if something is there
                if (slots[row,col] != " ")
                {
                    valid = false;
                }/*/

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
                    Console.WriteLine("1 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }                
            }

           // check = true;
            // TURN 2
            while (check == false && win == false)
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

                /*/ checks if something is there
                if (slots[row,col] != " ")
                {
                    valid = false;
                }/*/

                // Puts X into board
                if (valid == true)
                {
                    slots[row, col] = " O ";

                    check = true;
                    Console.WriteLine("    A   B   C  ");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[0, 0] + "|" + slots[0, 1] + "|" + slots[0, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + slots[1, 0] + "|" + slots[1, 1] + "|" + slots[1, 2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + slots[2, 0] + "|" + slots[2, 1] + "|" + slots[2, 2] + "|");
                    Console.WriteLine("  +---+---+---+");

                }
                else
                {
                    check = false;
                    Console.WriteLine("That is an invalid move. Try again");
                }
            }


        }
    }
}
