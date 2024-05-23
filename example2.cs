using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Algo2-Homework";
            while (true)
            {
                try
                {


                    Console.WriteLine("\t\tALGORITHM HOMEWORK-2\n");
                    Console.Write("---------------------------------------------\n\n");
                    //creating card array
                    char[] cardarray = new char[9];
                    char[] ABCD = { 'A', 'B', 'C', 'D' };
                    Random rnd = new Random();
                    //Assignment of random elements A,B,C,D  to the array of cards
                    int a;
                    for (int i = 0; i < cardarray.Length; i++)
                    {
                        a = rnd.Next(0, ABCD.Length);
                        cardarray[i] = ABCD[a];
                    }


                    //A random list between 0 and 8 will be made and the colors will be randomly assigned in 3 with this random sequence.
                    List<int> elements = new List<int>();
                    while (elements.Count != 9)
                    {
                        int b = rnd.Next(0, 9);
                        if (!elements.Contains(b))
                        {
                            elements.Add(b);
                        }

                    }
                    //creating color array
                    char[] colorarray = new char[9];
                    for (int i = 0; i < 9; i++)
                    {
                        if (elements[i] == 0 || elements[i] == 1 || elements[i] == 2)
                        {
                            colorarray[i] = 'K';
                        }
                        else if (elements[i] == 3 || elements[i] == 4 || elements[i] == 5)
                        {
                            colorarray[i] = 'M';
                        }
                        else
                        {
                            colorarray[i] = 'Y';
                        }
                    }
                    Console.SetCursorPosition(0, 4);
                    Console.Write("Your card array:");
                    Console.SetCursorPosition(17, 4);

                    //Combining color array with card array
                    for (int i = 0; i < 9; i++)
                    {
                        if (colorarray[i] == 'K')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(cardarray[i] + "  ");
                        }
                        else if (colorarray[i] == 'M')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(cardarray[i] + "  ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(cardarray[i] + "  ");
                        }
                    }

                    Console.SetCursorPosition(0, 7);

                    int score = 0;
                    //In a 9-element array, since we will control the elements 3 by 3 in a sequential way,
                    // this process is done 7 times in a 9-element array, so our loop will return 7 times.
                    for (int i = 0; i < 7; i++)
                    {
                        int instantscore = 0;
                        if ((cardarray[i] == cardarray[i + 1]) && (cardarray[i + 1] == cardarray[i + 2]))
                        {
                            //In the first part, the probability of identical cards and same colors was calculated
                            if ((colorarray[i] == colorarray[i + 1]) && (colorarray[i + 1] == colorarray[i + 2]))
                            {
                                score = score + 33;
                                instantscore = instantscore + 33;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  " + cardarray[i] + "  " + cardarray[i] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  " + cardarray[i] + "  " + cardarray[i] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  " + cardarray[i] + "  " + cardarray[i] + " " + instantscore + "points\n\n");
                                }

                            }
                            //In the second part, the same cards and different colors are calculated
                            else if ((colorarray[i] != colorarray[i + 1]) && (colorarray[i + 1] != colorarray[i + 2]) && (colorarray[i] != colorarray[i + 2]))
                            {
                                score = score + 28;
                                instantscore = instantscore + 28;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                if (colorarray[i + 1] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                if (colorarray[i + 2] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }

                            }
                            //In the third part, the probability of identical cards but not identical or different colors is calculated.
                            else
                            {
                                score = score + 22;
                                instantscore = instantscore + 22;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                if (colorarray[i + 1] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                if (colorarray[i + 2] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                        }
                        else if (((cardarray[i] != 'D') && (cardarray[i + 1] != 'D') && (cardarray[i + 2] != 'D')
                        && (cardarray[i] != cardarray[i + 1]) && (cardarray[i + 1] != cardarray[i + 2])
                        && (cardarray[i] != cardarray[i + 2])) || ((cardarray[i] != 'A') && (cardarray[i + 1] != 'A')
                        && (cardarray[i + 2] != 'A') && (cardarray[i] != cardarray[i + 1]) && (cardarray[i + 1] != cardarray[i + 2])
                        && (cardarray[i] != cardarray[i + 2])))
                        {
                            //in the fourth part, consecutive cards the same colors are calculated
                            if ((colorarray[i] == colorarray[i + 1]) && (colorarray[i + 1] == colorarray[i + 2]))
                            {
                                score = score + 18;
                                instantscore = instantscore + 18;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                            //in the fifth part consecutive cards different colors were calculated
                            else if ((colorarray[i] != colorarray[i + 1]) && (colorarray[i + 1] != colorarray[i + 2]) && (colorarray[i] != colorarray[i + 2]))
                            {
                                score = score + 16;
                                instantscore = instantscore + 16;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                if (colorarray[i + 1] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                if (colorarray[i + 2] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                            //In the sixth section, consecutive cards are not identical colors and non-different colors are calculated.
                            else
                            {
                                score = score + 14;
                                instantscore = instantscore + 14;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                if (colorarray[i + 1] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                if (colorarray[i + 2] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                        }
                        else
                        {
                            //In the 7th section, the probability of non-same and non-consecutive cards of the same color is calculated.
                            if ((colorarray[i] == colorarray[i + 1]) && (colorarray[i + 1] == colorarray[i + 2]))
                            {
                                score = score + 12;
                                instantscore = instantscore + 12;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  " + cardarray[i + 1] + "  " + cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                            //In the eighth section, the probability that the non-same 
                            //and non-consecutive cards are in different colors is calculated.
                            else if ((colorarray[i] != colorarray[i + 1]) && (colorarray[i + 1] != colorarray[i + 2]) && (colorarray[i] != colorarray[i + 2]))
                            {
                                score = score + 10;
                                instantscore = instantscore + 10;
                                if (colorarray[i] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                else if (colorarray[i] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i] + "  ");
                                }
                                if (colorarray[i + 1] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                else if (colorarray[i + 1] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 1] + "  ");
                                }
                                if (colorarray[i + 2] == 'K')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'M')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                                else if (colorarray[i + 2] == 'Y')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(cardarray[i + 2] + " " + instantscore + "points\n\n");
                                }
                            }
                        }

                    }
                    Console.ResetColor();
                    Console.Write("You get " + score + " points !!!");
                    string name;
                    Console.Write("\nPlease enter your name: ");
                    name = Console.ReadLine();


                    string[] names = new string[11];
                    int[] points = new int[11];

                    //In this section, the txt file is read first as a name and then as a score.
                    StreamReader file = File.OpenText("D:\\HighScoreTable.txt");
                    int q = 0;
                    while (q < 11)
                    {
                        names[q] = file.ReadLine();
                        points[q] = Convert.ToInt16(file.ReadLine());
                        q++;
                    }
                    file.Close();

                    //The high score table is reconstructed using a specific algorithm
                    points[10] = score;
                    names[10] = name;
                    int temporaryscore;
                    string temporaryname;
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 10; i < j; j--)
                        {
                            if (points[i] <= points[j])
                            {
                                temporaryscore = points[i];
                                points[i] = points[j];
                                points[j] = temporaryscore;

                                temporaryname = names[i];
                                names[i] = names[j];
                                names[j] = temporaryname;

                            }
                        }
                    }
                    //The new high score table created is written to the txt file in its new form
                    StreamWriter wrt = File.CreateText("D:\\HighScoreTable.txt");
                    for (int i = 0; i < 10; i++)
                    {
                        wrt.WriteLine(names[i]);
                        wrt.WriteLine(points[i]);
                    }
                    wrt.Close();

                    Console.SetCursorPosition(57, 5);
                    Console.Write("High Score Table");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(57, 7 + i);
                        Console.Write(names[i] + "=> " + points[i]);
                    }
                    Console.SetCursorPosition(0, 23);
                start:
                    Console.Write("Would you like to try your luck again?(Y or N)=>");
                    string answer = Console.ReadLine();
                    if (answer == "Y")
                    {
                        Console.Clear();
                    }
                    else if (answer == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please press yes (Y) or no (N)");
                        goto start;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }
    }
}
