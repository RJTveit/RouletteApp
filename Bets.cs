using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace RouletteApp
{
    public class Bets 
    {
        public void BettingTable()
        {
            Console.WriteLine("The following Bets may be placed before the spin:");
            Console.WriteLine("\t************");

            Console.WriteLine("1 - Numbers: bet on the numbers in the bin");
            Console.WriteLine("2 - Evens/Odds: bet on even or odd numbers");
            Console.WriteLine("3 - Reds/Blacks: bet on the color");
            Console.WriteLine("4 - Lows/Highs: bet on the low (1-8) or the high (19-38) numbers");
            Console.WriteLine("5 - Dozens: bet on (1-12), (13-24), or (25-36)");
            Console.WriteLine("6 - Columns: First, Second, or Third column");
            Console.WriteLine("7 - Street: rows e.g., 1/2/3 or 22/23/24)");
            Console.WriteLine("8 - 6 Numbers: double rows");
            Console.WriteLine("9 - Split: at the edge of any two contiguous numbers e.g., 1/2 or 35/36");
            Console.WriteLine("0 - Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");

            Console.Write("\nPlease enter the number for the bet you would like to make:   ");

            switch (Console.ReadLine())
            {
                case "1":
                    BetNumbers();
                    break;
                case "2":
                    EvensOrOdds();
                    break;
                case "3":
                    RedsOrBlacks();
                    break;
                case "4":
                    LowsOrHighs();
                    break;
                case "5":
                    Dozens();
                    break;
                case "6":
                    Columns();
                    break;
                case "7":
                    Street();
                    break;
                case "8":
                    SixNumbers();
                    break;
                case "9":
                    Split();
                    break;
                case "0":
                    Corner();
                    break;
            }
        }

        static void BetNumbers()
        {
            Console.WriteLine("Please enter either Red, Black, or Green");
            string betColor = Console.ReadLine();
            Console.WriteLine("Please enter a number (00,0) to 36");
            string betNumber = Console.ReadLine();

            //string[] userBet = new string[] { betColor, betNumber};

            RouletteWheel newSpin = new RouletteWheel();
            string[] spinResult = newSpin.WheelSpin();

            string spinColor = spinResult[0];
            string spinNumber = spinResult[1];
            
                       
            if (betNumber == spinNumber)
            {
                Console.WriteLine("Congratulations you won!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time");
            }
        }

        static void EvensOrOdds()
        {
            Console.WriteLine("Bet on even or odd?");
                      

            switch (Console.ReadLine())
            {

                case "even":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinColor = spinResult[0];
                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (spinInt / 2 == 0)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;

                case "odd":

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinColor2 = spinResult2[0];
                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);

                    if (spinInt2 / 2 != 0)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;
            }
        }

        static void RedsOrBlacks()
        {
            Console.WriteLine("Please choose a color, Red or Black:    ");
                       

            switch (Console.ReadLine())
            {
                case "red":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();
                    string spinColor = spinResult[0];

                    if (Console.ReadLine() == spinColor)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;

                case "black":

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();
                    string spinColor2 = spinResult2[0];

                    if (Console.ReadLine() == spinColor2)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;
            }


        }

        static void LowsOrHighs()
        {
            Console.WriteLine("Please choose Lows(1) or Highs(2):  ");
                       
            switch (Console.ReadLine())
            {
                case "1":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (spinInt <= 18)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;
                case "2":

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);

                    if (spinInt2 >= 19)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;
            }

        }

        static void Dozens()
        {
            Console.WriteLine("Please select a block; 1-12(1), 13-24(2), 25-36(3):  ");

            switch (Console.ReadLine())
            {
                case "1":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (spinInt <= 12)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;

                case "2":

                   // RouletteWheel newSpin2 = new RouletteWheel();
                   // string[] spinResult2 = newSpin2.WheelSpin();
                   //
                   // string spinNumber2 = spinResult2[1];
                   // int spinInt2 = Convert.ToInt32(spinNumber2);
                   //
                   // if (spinInt2 <= 12)
                   // {
                   //     Console.WriteLine("Congratulations you won!");
                   // }
                   // else
                   // {
                   //     Console.WriteLine("Sorry, better luck next time!");
                   // }
                   //
                   // break;

                case "3":

                    RouletteWheel newSpin3 = new RouletteWheel();
                    string[] spinResult3 = newSpin3.WheelSpin();

                    string spinNumber3 = spinResult3[1];
                    int spinInt3 = Convert.ToInt32(spinNumber3);

                    if (spinInt3 >= 25)
                    {
                        Console.WriteLine("Congratulations you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;
            }
        }

        static void Columns()
        {
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};

            Console.WriteLine("Please select a a column (1), (2), or (3):   ");

            switch (Console.ReadLine())
            {
                case "1":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (column1.Contains(spinInt))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;

                case "2":

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);

                    if (column2.Contains(spinInt2))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "3":

                    RouletteWheel newSpin3 = new RouletteWheel();
                    string[] spinResult3 = newSpin3.WheelSpin();

                    string spinNumber3 = spinResult3[1];
                    int spinInt3 = Convert.ToInt32(spinNumber3);

                    if (column3.Contains(spinInt3))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }
                    break;
            }
        }

        static void Street()
        {

            int[] street1 = { 1, 2, 3 };
            int[] street2 = { 4, 5, 6 };
            int[] street3 = { 7, 8, 9 };
            int[] street4 = { 10, 11, 12 };
            int[] street5 = { 13, 14, 15 };
            int[] street6 = { 16, 17, 18 };
            int[] street7 = { 19, 20, 21 };
            int[] street8 = { 22, 23, 24 };
            int[] street9 = { 25, 26, 27 };
            int[] street10 = { 28, 29, 30 };
            int[] street11 = { 31, 32, 33 };
            int[] street12 = { 34, 35, 36 };

            Console.WriteLine("\nStreet 1 (1-3), 2 (4-6), 3 (7-9), 4 (10-12), 5 (13-15), 6 (16-18), 7 (19-21), 8 (22-24), 9 (25-27), 10 (28-30),\n 11 (31-33), 12 (34-36)");
            Console.WriteLine(" Please choose a street (1-12):  ");
                       

            switch (Console.ReadLine())
            {

                case "1":

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (street1.Contains(spinInt))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "2":

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);
                                        
                    if (street2.Contains(spinInt2))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "3":

                    RouletteWheel newSpin3 = new RouletteWheel();
                    string[] spinResult3 = newSpin3.WheelSpin();

                    string spinNumber3 = spinResult3[1];
                    int spinInt3 = Convert.ToInt32(spinNumber3);

                    if (street3.Contains(spinInt3))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "4":

                    RouletteWheel newSpin4 = new RouletteWheel();
                    string[] spinResult4 = newSpin4.WheelSpin();

                    string spinNumber4 = spinResult4[1];
                    int spinInt4 = Convert.ToInt32(spinNumber4);

                    if (street4.Contains(spinInt4))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "5":

                    RouletteWheel newSpin5 = new RouletteWheel();
                    string[] spinResult5 = newSpin5.WheelSpin();

                    string spinNumber5 = spinResult5[1];
                    int spinInt5 = Convert.ToInt32(spinNumber5);

                    if (street5.Contains(spinInt5))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "6":

                    RouletteWheel newSpin6 = new RouletteWheel();
                    string[] spinResult6 = newSpin6.WheelSpin();

                    string spinNumber6 = spinResult6[1];
                    int spinInt6 = Convert.ToInt32(spinNumber6);

                    if (street6.Contains(spinInt6))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "7":

                    RouletteWheel newSpin7 = new RouletteWheel();
                    string[] spinResult7 = newSpin7.WheelSpin();

                    string spinNumber7 = spinResult7[1];
                    int spinInt7 = Convert.ToInt32(spinNumber7);

                    if (street7.Contains(spinInt7))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "8":

                    RouletteWheel newSpin8 = new RouletteWheel();
                    string[] spinResult8 = newSpin8.WheelSpin();

                    string spinNumber8 = spinResult8[1];
                    int spinInt8 = Convert.ToInt32(spinNumber8);

                    if (street8.Contains(spinInt8))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "9":

                    RouletteWheel newSpin9 = new RouletteWheel();
                    string[] spinResult9 = newSpin9.WheelSpin();

                    string spinNumber9 = spinResult9[1];
                    int spinInt9 = Convert.ToInt32(spinNumber9);

                    if (street9.Contains(spinInt9))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "10":

                    RouletteWheel newSpin10 = new RouletteWheel();
                    string[] spinResult10 = newSpin10.WheelSpin();

                    string spinNumber10 = spinResult10[1];
                    int spinInt10 = Convert.ToInt32(spinNumber10);

                    if (street10.Contains(spinInt10))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "11":

                    RouletteWheel newSpin11 = new RouletteWheel();
                    string[] spinResult11 = newSpin11.WheelSpin();

                    string spinNumber11 = spinResult11[1];
                    int spinInt11 = Convert.ToInt32(spinNumber11);

                    if (street11.Contains(spinInt11))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "12":

                    RouletteWheel newSpin12 = new RouletteWheel();
                    string[] spinResult12 = newSpin12.WheelSpin();

                    string spinNumber12 = spinResult12[1];
                    int spinInt12 = Convert.ToInt32(spinNumber12);

                    if (street12.Contains(spinInt12))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;
            }

        }

        static void SixNumbers()
        {
            int[,] sixNum = { { 1, 2, 3, 4, 5, 6}, { 4, 5, 6, 7, 8, 9}, { 7, 8, 9, 10, 11, 12 }, { 10, 11, 12, 13, 14, 15}, { 13, 14, 15, 16, 17, 18 }, { 16, 17, 18, 19, 20, 21},
                            { 19, 20, 21, 22, 23, 24 }, { 22, 23, 24, 25, 26, 27}, { 25, 26, 27, 28, 29, 30}, {28, 29, 30, 31, 32, 33}, { 30, 31, 32, 33, 34, 35}, {31, 32, 33, 34, 35, 36}};

            Console.WriteLine("Please place a bet on a string of six numbers 1-12:   ");

            switch (Console.ReadLine())
            {
                case "1":

                    int[] userBet = new int[sixNum[0, 0]];

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (userBet.Contains(spinInt))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "2":

                    int[] userBet2 = new int[sixNum[1, 0]];

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);

                    if (userBet2.Contains(spinInt2))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "3":

                    int[] userBet3 = new int[sixNum[2, 0]];

                    RouletteWheel newSpin3 = new RouletteWheel();
                    string[] spinResult3 = newSpin3.WheelSpin();

                    string spinNumber3 = spinResult3[1];
                    int spinInt3 = Convert.ToInt32(spinNumber3);

                    if (userBet3.Contains(spinInt3))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "4":

                    int[] userBet4 = new int[sixNum[3, 0]];

                    RouletteWheel newSpin4 = new RouletteWheel();
                    string[] spinResult4 = newSpin4.WheelSpin();

                    string spinNumber4 = spinResult4[1];
                    int spinInt4 = Convert.ToInt32(spinNumber4);

                    if (userBet4.Contains(spinInt4))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "5":

                    int[] userBet5 = new int[sixNum[4, 0]];

                    RouletteWheel newSpin5 = new RouletteWheel();
                    string[] spinResult5 = newSpin5.WheelSpin();

                    string spinNumber5 = spinResult5[1];
                    int spinInt5 = Convert.ToInt32(spinNumber5);

                    if (userBet5.Contains(spinInt5))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "6":

                    int[] userBet6 = new int[sixNum[5, 0]];

                    RouletteWheel newSpin6 = new RouletteWheel();
                    string[] spinResult6 = newSpin6.WheelSpin();

                    string spinNumber6 = spinResult6[1];
                    int spinInt6 = Convert.ToInt32(spinNumber6);

                    if (userBet6.Contains(spinInt6))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "7":

                    int[] userBet7 = new int[sixNum[6, 0]];

                    RouletteWheel newSpin7 = new RouletteWheel();
                    string[] spinResult7 = newSpin7.WheelSpin();

                    string spinNumber7 = spinResult7[1];
                    int spinInt7 = Convert.ToInt32(spinNumber7);

                    if (userBet7.Contains(spinInt7))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "8":

                    int[] userBet8 = new int[sixNum[7, 0]];

                    RouletteWheel newSpin8 = new RouletteWheel();
                    string[] spinResult8 = newSpin8.WheelSpin();

                    string spinNumber8 = spinResult8[1];
                    int spinInt8 = Convert.ToInt32(spinNumber8);

                    if (userBet8.Contains(spinInt8))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "9":

                    int[] userBet9 = new int[sixNum[8, 0]];

                    RouletteWheel newSpin9 = new RouletteWheel();
                    string[] spinResult9 = newSpin9.WheelSpin();

                    string spinNumber9 = spinResult9[1];
                    int spinInt9 = Convert.ToInt32(spinNumber9);

                    if (userBet9.Contains(spinInt9))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "10":

                    int[] userBet10 = new int[sixNum[9, 0]];

                    RouletteWheel newSpin10 = new RouletteWheel();
                    string[] spinResult10 = newSpin10.WheelSpin();

                    string spinNumber10 = spinResult10[1];
                    int spinInt10 = Convert.ToInt32(spinNumber10);

                    if (userBet10.Contains(spinInt10))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "11":

                    int[] userBet11 = new int[sixNum[10, 0]];

                    RouletteWheel newSpin11 = new RouletteWheel();
                    string[] spinResult11 = newSpin11.WheelSpin();

                    string spinNumber11 = spinResult11[1];
                    int spinInt11 = Convert.ToInt32(spinNumber11);

                    if (userBet11.Contains(spinInt11))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "12":

                    int[] userBet12 = new int[sixNum[11, 0]];

                    RouletteWheel newSpin12 = new RouletteWheel();
                    string[] spinResult12 = newSpin12.WheelSpin();

                    string spinNumber12 = spinResult12[1];
                    int spinInt12 = Convert.ToInt32(spinNumber12);

                    if (userBet12.Contains(spinInt12))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;
            }
        }

        static void Split()
        {
            int[,] splitNum = { { 1, 2 }, { 2, 3}, { 3, 4 }, { 4, 5}, { 5, 6}, { 6, 7 }, { 7, 8 }, { 8, 9 }, { 9, 10 }, { 10, 11 }, { 11, 12 }, { 12, 13 }, { 13, 14 }, { 14, 15 },
                              { 15, 16 }, { 16, 17}, { 17, 18 }, {18, 19 }, { 19, 20}, { 20, 21}, { 21, 22 }, { 23, 24}, { 25, 26 }, { 27, 28 }, { 28, 29 }, { 29, 30 }, { 30, 31 }, { 31, 32 }, { 32, 33 },
                              { 33, 34 }, { 34, 35 }, { 35, 36 }};

            Console.WriteLine("\tCorner Options:  ");
            Console.WriteLine(" 1{ 1, 2 } 2{ 2, 3} 3{ 3, 4 }, 4{ 4, 5} 5{ 5, 6}, 6{ 6, 7 } 7{ 7, 8 } 8{ 8, 9 } 9{ 9, 10 }, 10{ 10, 11 } 11{ 11, 12 } 12{ 12, 13 } 13{ 13, 14 } 14{ 14, 15 } \n15{ 15, 16 } 16{ 16, 17} 17{ 7, 18 } 18{ 18, 19 } 19{ 19, 20} 20{ 20, 21} 21{ 21, 22 } 22{ 23, 24} 23{ 25, 26 } 24{ 27, 28 } \n25{ 28, 29 } 26{ 29, 30 } 27{ 30, 31 } 28{ 31, 32 } 29{ 32, 33 } 30{ 33, 34 } 31{ 34, 35 } 32{  35, 36 }");
            Console.WriteLine("Please select a corner to bet on, 1-32:   ");

            switch (Console.ReadLine())
            {
                case "1":

                    int[] userBet = new int[splitNum[0, 0]];

                    RouletteWheel newSpin = new RouletteWheel();
                    string[] spinResult = newSpin.WheelSpin();

                    string spinNumber = spinResult[1];
                    int spinInt = Convert.ToInt32(spinNumber);

                    if (userBet.Contains(spinInt))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "2":

                    int[] userBet2 = new int[splitNum[1, 0]];

                    RouletteWheel newSpin2 = new RouletteWheel();
                    string[] spinResult2 = newSpin2.WheelSpin();

                    string spinNumber2 = spinResult2[1];
                    int spinInt2 = Convert.ToInt32(spinNumber2);

                    if (userBet2.Contains(spinInt2))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "3":

                    int[] userBet3 = new int[splitNum[2, 0]];

                    RouletteWheel newSpin3 = new RouletteWheel();
                    string[] spinResult3 = newSpin3.WheelSpin();

                    string spinNumber3 = spinResult3[1];
                    int spinInt3= Convert.ToInt32(spinNumber3);

                    if (userBet3.Contains(spinInt3))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "4":

                    int[] userBet4 = new int[splitNum[3, 0]];

                    RouletteWheel newSpin4 = new RouletteWheel();
                    string[] spinResult4 = newSpin4.WheelSpin();

                    string spinNumber4 = spinResult4[1];
                    int spinInt4 = Convert.ToInt32(spinNumber4);

                    if (userBet4.Contains(spinInt4))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "5":

                    int[] userBet5 = new int[splitNum[4, 0]];

                    RouletteWheel newSpin5 = new RouletteWheel();
                    string[] spinResult5 = newSpin5.WheelSpin();

                    string spinNumber5 = spinResult5[1];
                    int spinInt5 = Convert.ToInt32(spinNumber5);

                    if (userBet5.Contains(spinInt5))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "6":

                    int[] userBet6 = new int[splitNum[5, 0]];

                    RouletteWheel newSpin6 = new RouletteWheel();
                    string[] spinResult6 = newSpin6.WheelSpin();

                    string spinNumber6 = spinResult6[1];
                    int spinInt6 = Convert.ToInt32(spinNumber6);

                    if (userBet6.Contains(spinInt6))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "7":

                    int[] userBet7 = new int[splitNum[6, 0]];

                    RouletteWheel newSpin7 = new RouletteWheel();
                    string[] spinResult7 = newSpin7.WheelSpin();
                    
                    string spinNumber7 = spinResult7[1];
                    int spinInt7 = Convert.ToInt32(spinNumber7);

                    if (userBet7.Contains(spinInt7))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "8":

                    int[] userBet8 = new int[splitNum[7, 0]];

                    RouletteWheel newSpin8 = new RouletteWheel();
                    string[] spinResult8 = newSpin8.WheelSpin();

                    string spinNumber8 = spinResult8[1];
                    int spinInt8 = Convert.ToInt32(spinNumber8);

                    if (userBet8.Contains(spinInt8))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "9":

                    int[] userBet9 = new int[splitNum[8, 0]];

                    RouletteWheel newSpin9 = new RouletteWheel();
                    string[] spinResult9 = newSpin9.WheelSpin();

                    string spinNumber9 = spinResult9[1];
                    int spinInt9 = Convert.ToInt32(spinNumber9);

                    if (userBet9.Contains(spinInt9))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "10":

                    int[] userBet10 = new int[splitNum[9, 0]];

                    RouletteWheel newSpin10 = new RouletteWheel();
                    string[] spinResult10 = newSpin10.WheelSpin();

                    string spinNumber10 = spinResult10[1];
                    int spinInt10 = Convert.ToInt32(spinNumber10);

                    if (userBet10.Contains(spinInt10))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "11":

                    int[] userBet11 = new int[splitNum[10, 0]];

                    RouletteWheel newSpin11 = new RouletteWheel();
                    string[] spinResult11 = newSpin11.WheelSpin();

                    string spinNumber11 = spinResult11[1];
                    int spinInt11 = Convert.ToInt32(spinNumber11);

                    if (userBet11.Contains(spinInt11))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "12":

                    int[] userBet12 = new int[splitNum[11, 0]];

                    RouletteWheel newSpin12 = new RouletteWheel();
                    string[] spinResult12 = newSpin12.WheelSpin();

                    string spinNumber12 = spinResult12[1];
                    int spinInt12 = Convert.ToInt32(spinNumber12);

                    if (userBet12.Contains(spinInt12))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "13":

                    int[] userBet13 = new int[splitNum[12, 0]];

                    RouletteWheel newSpin13 = new RouletteWheel();
                    string[] spinResult13 = newSpin13.WheelSpin();

                    string spinNumber13 = spinResult13[1];
                    int spinInt13= Convert.ToInt32(spinNumber13);

                    if (userBet13.Contains(spinInt13))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "14":

                    int[] userBet14 = new int[splitNum[13, 0]];

                    RouletteWheel newSpin14 = new RouletteWheel();
                    string[] spinResult14 = newSpin14.WheelSpin();

                    string spinNumber14 = spinResult14[1];
                    int spinInt14 = Convert.ToInt32(spinNumber14);

                    if (userBet14.Contains(spinInt14))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "15":

                    int[] userBet15 = new int[splitNum[14, 0]];

                    RouletteWheel newSpin15 = new RouletteWheel();
                    string[] spinResult15 = newSpin15.WheelSpin();

                    string spinNumber15 = spinResult15[1];
                    int spinInt15 = Convert.ToInt32(spinNumber15);

                    if (userBet15.Contains(spinInt15))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "16":

                    int[] userBet16 = new int[splitNum[15, 0]];

                    RouletteWheel newSpin16 = new RouletteWheel();
                    string[] spinResult16 = newSpin16.WheelSpin();

                    string spinNumber16 = spinResult16[1];
                    int spinInt16 = Convert.ToInt32(spinNumber16);

                    if (userBet16.Contains(spinInt16))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "17":

                    int[] userBet17 = new int[splitNum[16, 0]];

                    RouletteWheel newSpin17 = new RouletteWheel();
                    string[] spinResult17 = newSpin17.WheelSpin();

                    string spinNumber17 = spinResult17[1];
                    int spinInt17 = Convert.ToInt32(spinNumber17);

                    if (userBet17.Contains(spinInt17))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "18":

                    int[] userBet18 = new int[splitNum[17, 0]];

                    RouletteWheel newSpin18 = new RouletteWheel();
                    string[] spinResult18 = newSpin18.WheelSpin();

                    string spinNumber18 = spinResult18[1];
                    int spinInt18 = Convert.ToInt32(spinNumber18);

                    if (userBet18.Contains(spinInt18))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "19":

                    int[] userBet19 = new int[splitNum[18, 0]];

                    RouletteWheel newSpin19 = new RouletteWheel();
                    string[] spinResult19 = newSpin19.WheelSpin();

                    string spinNumber19 = spinResult19[1];
                    int spinInt19 = Convert.ToInt32(spinNumber19);

                    if (userBet19.Contains(spinInt19))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "20":

                    int[] userBet20 = new int[splitNum[19, 0]];

                    RouletteWheel newSpin20 = new RouletteWheel();
                    string[] spinResult20 = newSpin20.WheelSpin();

                    string spinNumber20 = spinResult20[1];
                    int spinInt20 = Convert.ToInt32(spinNumber20);

                    if (userBet20.Contains(spinInt20))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "21":

                    int[] userBet21 = new int[splitNum[20, 0]];

                    RouletteWheel newSpin21 = new RouletteWheel();
                    string[] spinResult21 = newSpin21.WheelSpin();

                    string spinNumber21 = spinResult21[1];
                    int spinInt21 = Convert.ToInt32(spinNumber21);

                    if (userBet21.Contains(spinInt21))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "22":

                    int[] userBet22 = new int[splitNum[21, 0]];

                    RouletteWheel newSpin22 = new RouletteWheel();
                    string[] spinResult22 = newSpin22.WheelSpin();

                    string spinNumber22 = spinResult22[1];
                    int spinInt22 = Convert.ToInt32(spinNumber22);

                    if (userBet22.Contains(spinInt22))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "23":

                    int[] userBet23 = new int[splitNum[21, 0]];

                    RouletteWheel newSpin23 = new RouletteWheel();
                    string[] spinResult23 = newSpin23.WheelSpin();

                    string spinNumber23 = spinResult23[1];
                    int spinInt23 = Convert.ToInt32(spinNumber23);

                    if (userBet23.Contains(spinInt23))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "24":

                    int[] userBet24 = new int[splitNum[23, 0]];

                    RouletteWheel newSpin24 = new RouletteWheel();
                    string[] spinResult24 = newSpin24.WheelSpin();

                    string spinNumber24 = spinResult24[1];
                    int spinInt24 = Convert.ToInt32(spinNumber24);

                    if (userBet24.Contains(spinInt24))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "25":

                    int[] userBet25 = new int[splitNum[24, 0]];

                    RouletteWheel newSpin25 = new RouletteWheel();
                    string[] spinResult25 = newSpin25.WheelSpin();

                    string spinNumber25 = spinResult25[1];
                    int spinInt25 = Convert.ToInt32(spinNumber25);

                    if (userBet25.Contains(spinInt25))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "26":

                    int[] userBet26 = new int[splitNum[25, 0]];

                    RouletteWheel newSpin26 = new RouletteWheel();
                    string[] spinResult26 = newSpin26.WheelSpin();

                    string spinNumber26 = spinResult26[1];
                    int spinInt26 = Convert.ToInt32(spinNumber26);

                    if (userBet26.Contains(spinInt26))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "27":

                    int[] userBet27 = new int[splitNum[26, 0]];

                    RouletteWheel newSpin27 = new RouletteWheel();
                    string[] spinResult27 = newSpin27.WheelSpin();

                    string spinNumber27 = spinResult27[1];
                    int spinInt27 = Convert.ToInt32(spinNumber27);

                    if (userBet27.Contains(spinInt27))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "28":

                    int[] userBet28 = new int[splitNum[27, 0]];

                    RouletteWheel newSpin28 = new RouletteWheel();
                    string[] spinResult28 = newSpin28.WheelSpin();

                    string spinNumber28 = spinResult28[1];
                    int spinInt28 = Convert.ToInt32(spinNumber28);

                    if (userBet28.Contains(spinInt28))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "29":

                    int[] userBet29 = new int[splitNum[28, 0]];

                    RouletteWheel newSpin29 = new RouletteWheel();
                    string[] spinResult29 = newSpin29.WheelSpin();

                    string spinNumber29 = spinResult29[1];
                    int spinInt29 = Convert.ToInt32(spinNumber29);

                    if (userBet29.Contains(spinInt29))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "30":

                    int[] userBet30 = new int[splitNum[29, 0]];

                    RouletteWheel newSpin30 = new RouletteWheel();
                    string[] spinResult30 = newSpin30.WheelSpin();

                    string spinNumber30 = spinResult30[1];
                    int spinInt30 = Convert.ToInt32(spinNumber30);

                    if (userBet30.Contains(spinInt30))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "31":

                    int[] userBet31 = new int[splitNum[30, 0]];

                    RouletteWheel newSpin31 = new RouletteWheel();
                    string[] spinResult31 = newSpin31.WheelSpin();

                    string spinNumber31 = spinResult31[1];
                    int spinInt31 = Convert.ToInt32(spinNumber31);

                    if (userBet31.Contains(spinInt31))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;

                case "32":

                    int[] userBet32 = new int[splitNum[31, 0]];

                    RouletteWheel newSpin32 = new RouletteWheel();
                    string[] spinResult32 = newSpin32.WheelSpin();

                    string spinNumber32 = spinResult32[1];
                    int spinInt32 = Convert.ToInt32(spinNumber32);

                    if (userBet32.Contains(spinInt32))
                    {
                        Console.WriteLine("Congrats you won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, better luck next time!");
                    }

                    break;



            }


        }

        static void Corner()
        {
            int[,] corners = { { 1, 2, 4, 5}, { 2, 3, 5, 6 }, { 4, 5, 7, 8 }, { 5, 6, 8, 9 }, { 7, 8, 10, 11 }, { 8, 9, 11, 12 }, { 10, 11, 13, 14 }, { 11, 12, 14, 15 },
                                { 13, 14, 16, 17}, { 17, 18, 20, 21}, { 19, 20, 22, 23}, { 20, 21, 23, 24}, { 22, 23, 25, 26}, { 23, 24, 26, 27}, { 25, 26, 28, 29}, { 26, 27, 29, 30},
                                { 28, 29, 31, 32}, { 29, 30, 32, 33}, { 31, 32, 34, 35}, { 32, 33, 35, 36} };

            string userBet;

            Console.WriteLine("{ 1, 2, 4, 5}, { 2, 3, 5, 6 }, { 4, 5, 7, 8 }, { 5, 6, 8, 9 }, { 7, 8, 10, 11 }, { 8, 9, 11, 12 }, { 10, 11, 13, 14 }, { 11, 12, 14, 15 } \n{ 13, 14, 16, 17}, { 17, 18, 20, 21}, { 19, 20, 22, 23}, { 20, 21, 23, 24}, { 22, 23, 25, 26}, { 23, 24, 26, 27}, { 25, 26, 28, 29}, { 26, 27, 29, 30}, \n{ 28, 29, 31, 32}, { 29, 30, 32, 33}, { 31, 32, 34, 35}, { 32, 33, 35, 36}");
            
            Console.WriteLine("Please enter a number to bet on (1-20):   ");
            userBet = Console.ReadLine();

            int i = Convert.ToInt32(userBet);

            int cornerBet = corners[i, 0];
            

            RouletteWheel newSpin = new RouletteWheel();
            string[] spinResult = newSpin.WheelSpin();

            string spinNumber = spinResult[1];
            int spinInt = Convert.ToInt32(spinNumber);

            if (spinInt == cornerBet)
            {
                Console.WriteLine("Congrats you won!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time!");
            }

            //I tested and tried rewriting several times before I ran out of time this evening. The objective of this method was to take the users input and use that as an index to sort through the "corners" array and select the corresponding int array. Then comparing the wheelSpin result to the integers within the assigned array.

        }

    }

}
