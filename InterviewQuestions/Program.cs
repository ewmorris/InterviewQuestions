using InterviewQuestions.UniqueEmail;
using InterviewQuestions.AdvancedTicTacToe;
using System;

namespace InterviewQuestions
{
    class Program
    {

        static void Main(string[] args)
        {

        }
        //    static void Main(string[] args)
        //    {
        //        var selection = "0";

        //        while (selection != "99")
        //        {
        //            Console.WriteLine("Please make selection");
        //            Console.WriteLine();
        //            Console.WriteLine(" 1. Number of Unique Email Address");
        //            Console.WriteLine(" 2. Advanced Tic Tac Toe");
        //            Console.WriteLine();
        //            Console.WriteLine("99. Exit");

        //            selection = Console.ReadLine();
        //            if (selection == "1")
        //            {
        //                Console.Clear();
        //                Console.WriteLine("Number of Unique Email Addresses: " + NumberOfUniqueEmailAddresses().ToString());
        //                Console.WriteLine();
        //            }
        //            else if(selection == "2")
        //            {
        //                AdvancedTicTacToe();
        //            }
        //        }

        //    } 
        //    public static int NumberOfUniqueEmailAddresses()
        //    {
        //        //Assumption: Filter out invalid emails and do not count.

        //        var emails = new string[]
        //        {
        //            "mickey.mouse@clubhouse.com",
        //            "mickeymouse@clubhouse.com",
        //            "mickeymouse@club.house.com",
        //            "mickeymouse+minnie@clubhouse.com",
        //            "mickeymouse@Test@test.com",
        //            "mickey.Mouse.House@club.com",
        //            "m.i.c.k.e.y.mouse@clubhouse.com"
        //        };

        //        var solution = new Solution();
        //        var uniqueEmails = solution.NumberofUniqueEmailAddresses(emails);

        //        return uniqueEmails;
        //    }

        //    public static void AdvancedTicTacToe()
        //    {
        //        //Assumption: row/column are entered as 0 based values
        //        //Assumption: each location will only be placed on once
        //        //Assumption: there will be a winner
        //        //Assumption: no visual board is needed
        //        //Assumption: allowed player selection for easier verification

        //        Console.WriteLine("Please Enter n, size of gameboard n x n");
        //        var n = Convert.ToInt32(Console.ReadLine());
        //        var tic = new TicTacToe(n);
        //        var winner = 0;
        //        while (winner == 0)
        //        {
        //            Console.WriteLine("Please enter row");
        //            var row = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine();
        //            Console.WriteLine("Please enter column");
        //            var column = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine();
        //            Console.WriteLine("Please enter player number");
        //            var player = Convert.ToInt32(Console.ReadLine());

        //            winner = tic.PlacePiece(row, column, player);                
        //        }

        //        Console.Clear();

        //        Console.WriteLine("Player " + winner.ToString() + " is the winner!");
        //        Console.WriteLine();
        //    }

    }
}
