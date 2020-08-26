using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RouletteApp
{
    public class RouletteWheel
    {
        string[] colors = { "Red", "Black", "Green" };

        string[] redNumbers = {"1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21",
                               "23", "25", "27", "32", "34", "36" };

        string[] blackNumbers = {"2", "4", "6", "8", "10", "11", "13", "15", "17", "20",
                                 "22", "24", "26", "28", "29", "31", "33", "35"};

        string[] greenNumbers = { "0", "00" };

        public string[] WheelSpin()
        {
            string color, number;
            Random spin = new Random();
            int colorIndex = spin.Next(colors.Length);
            color = colors[colorIndex];

           
            if (color == "Red")
            {
                int redNumberIndex = spin.Next(redNumbers.Length);
                number = redNumbers[redNumberIndex];
            }
            else if (color == "Black")
            {
                int blackNumberIndex = spin.Next(blackNumbers.Length);
                number = blackNumbers[blackNumberIndex];
            }
            else
            {
                int greenNumberIndex = spin.Next(greenNumbers.Length);
                number = greenNumbers[greenNumberIndex];
            }

            string[] spinResult = { color, number };

            Console.WriteLine($"\nThe ball landed in {color} {number}");

            return spinResult;
            
        }
       
    }
}
