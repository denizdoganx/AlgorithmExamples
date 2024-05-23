using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Homework_3
{
    class Program
    {
        //A boolean type function was defined to check the Phrase Rhyme.
        public static bool PhraseRyme(string[] phrase1, string[] phrase2)
        {
            Array.Reverse(phrase1);
            Array.Reverse(phrase2);
            int length = Math.Min(phrase1.Length, phrase2.Length);
            int equalcount = 0;
            for (int i = 0; i < length; i++)
            {
                if (phrase1[i] == phrase2[i])
                {
                    equalcount++;
                }
                else
                {
                    break;
                }
            }
            if (equalcount > 1)
            {
                return true;
            }
            return false;
        }
        //A boolean type function has been defined that controls Word Rhme.
        public static bool WordRhyme(string word1, string word2)
        {
            if (word1.Equals(word2))
            {
                return true;
            }
            return false;
        }
        //A boolean type function that controls Additional Rhyme is defined.
        //With this function, the controls of straight rhyme, alternating rhyme, 
        //winding rhyme and hoarse rhyme are also made within this function.
        public static bool AddtionalRhyme(string word1, string word2)
        {
            char[] chrarray1 = new char[word1.Length];
            int count1 = 0;
            for (int i = word1.Length - 1; 0 <= i; i--)
            {
                chrarray1[count1] = word1[i];
                count1++;
            }

            char[] chrarray2 = new char[word2.Length];
            int count2 = 0;
            for (int i = word2.Length - 1; 0 <= i; i--)
            {
                chrarray2[count2] = word2[i];
                count2++;
            }

            int length = Math.Min(word1.Length, word2.Length);
            int egualcount = 0;
            for (int i = 0; i < length; i++)
            {
                if (chrarray1[i] == chrarray2[i])
                {
                    egualcount++;
                }
                else
                {
                    break;
                }
            }
            if (egualcount > 1)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            Console.Title = "ALGO-3";
            Console.WriteLine("\t\t\tALGORITHM HOMEWORK - 3\n\n");
            Console.WriteLine("\t  POEM\n");
            
            try
            {
                //where the line of the given file with a do while loop is counted
                StreamReader f = File.OpenText("D:\\poem.txt");
                string text;
                int numberoflines = 0;
                do
                {
                    text = f.ReadLine();
                    numberoflines++;
                } while (!f.EndOfStream);
                f.Close();
                //In this section, the lines of the poem are placed in separate series.
                StreamReader g = File.OpenText("D:\\poem.txt");
                string[] poem = new string[numberoflines];
                
                for (int i = 0; i < numberoflines; i++)
                {
                    poem[i] = g.ReadLine();
                    Console.WriteLine(poem[i]);
                }
                g.Close();
                Console.WriteLine();
                //Counters were created because additional rhyme, word rhyme, and phrase rhyme should be continuous at the end of the whole poem
                int phrasecount = 0;
                int wordcount = 0;
                int addcount = 0;
             
                for (int i = 0; i < numberoflines - 1; i++)
                {
                    //counting with counters to check how many lines of the poem are common elements
                    string[] array1 = poem[i].Split(' ');
                    string[] array2 = poem[i + 1].Split(' ');
                    string word3 = array1[array1.Length - 1];
                    string word4 = array2[array2.Length - 1];
                    if (AddtionalRhyme(word3, word4))
                    {
                        addcount++;
                        if (WordRhyme(word3, word4))
                        {
                            wordcount++;
                            if (PhraseRyme(array1, array2))
                            {
                                phrasecount++;
                            }
                        }
                    }
                }
                //Additional rhyme, words rhyme and phrase rhyme are checked in this section.
                if (numberoflines > 1)
                {
                    if (addcount == numberoflines - 1)
                    {
                        string[] array1 = poem[0].Split(' ');
                        string[] array2 = poem[1].Split(' ');
                        string word3 = array1[array1.Length - 1];
                        string word4 = array2[array2.Length - 1];
                        int length = Math.Min(word3.Length, word4.Length);
                        char[] chrarray1 = new char[word3.Length];
                        int count1 = 0;
                        for (int j = word3.Length - 1; 0 <= j; j--)
                        {
                            chrarray1[count1] = word3[j];
                            count1++;
                        }
                        char[] chrarray2 = new char[word4.Length];
                        int count2 = 0;
                        for (int j = word4.Length - 1; 0 <= j; j--)
                        {
                            chrarray2[count2] = word4[j];
                            count2++;
                        }
                        int equalRepetition = 0;
                        for (int j = 0; j < length; j++)
                        {
                            if (chrarray1[j] != chrarray2[j])
                            {
                                break;
                            }
                            equalRepetition++;
                        }
                        string suffixRepetition = word3.Substring(word3.Length - equalRepetition);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("TYPE : Addtional Rhyme   =>   Repetition  {0}", suffixRepetition);
                        if (wordcount == numberoflines - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("TYPE : Word Rhyme   =>   Repetition   {0}", word3);
                            if (phrasecount == numberoflines - 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Array.Reverse(array1);
                                Array.Reverse(array2);
                                int equalWord = 0;
                                int lenght1 = Math.Min(array1.Length, array2.Length);
                                for (int i = 0; i < lenght1; i++)
                                {
                                    if (array1[i] != array2[i])
                                    {
                                        break;
                                    }
                                    equalWord++;
                                }
                                Array.Reverse(array1);
                                Console.Write("TYPE : Phrase Rhyme   =>   Repetition   ");
                                for (int i = 0; i < equalWord; i++)
                                {
                                    Console.Write(array1[array1.Length - equalWord + i] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
                //there is a big for loop here , alternating rhme, winding rhyme and hoarse rhyme are controlled in this for loop
                if (numberoflines > 3)
                {
                    for (int i = 0; i < numberoflines - 3; i++)
                    {
                        //here, since we are dealing with the word at the end of each line,
                        // the last words of the sentences are thrown into the corresponding variables.
                        string[] array1 = poem[i].Split(' ');
                        string[] array2 = poem[i + 1].Split(' ');
                        string[] array3 = poem[i + 2].Split(' ');
                        string[] array4 = poem[i + 3].Split(' ');
                        string word3 = array1[array1.Length - 1];
                        string word4 = array2[array2.Length - 1];
                        string word5 = array3[array3.Length - 1];
                        string word6 = array4[array4.Length - 1];
                        //We refer to the length of the shorter words compared to the other to avoid errors from the words we compare.
                        int length1 = Math.Min(word3.Length, word5.Length);
                        int length2 = Math.Min(word4.Length, word6.Length);
                        int length3 = Math.Min(word3.Length, word6.Length);
                        int length4 = Math.Min(word4.Length, word5.Length);
                        //Each word is reversed and thrown into char arrays for comparison
                        char[] chrarray1 = new char[word3.Length];
                        int count1 = 0;
                        for (int j = word3.Length - 1; 0 <= j; j--)
                        {
                            chrarray1[count1] = word3[j];
                            count1++;
                        }
                        char[] chrarray2 = new char[word4.Length];
                        int count2 = 0;
                        for (int j = word4.Length - 1; 0 <= j; j--)
                        {
                            chrarray2[count2] = word4[j];
                            count2++;
                        }
                        char[] chrarray3 = new char[word5.Length];
                        int count3 = 0;
                        for (int j = word5.Length - 1; 0 <= j; j--)
                        {
                            chrarray3[count3] = word5[j];
                            count3++;
                        }
                        char[] chrarray4 = new char[word6.Length];
                        int count4 = 0;
                        for (int j = word6.Length - 1; 0 <= j; j--)
                        {
                            chrarray4[count4] = word6[j];
                            count4++;
                        }
                        //Here, for alternating rhyme control, parameters are given to the additional rhyme function in the form of related binaries.
                        if (AddtionalRhyme(word3, word5))
                        {
                            if (AddtionalRhyme(word4, word6))
                            {
                                if ((!word3.Equals(word4)) && (!word5.Equals(word6)))
                                {
                                    int equalA = 0;
                                    int equalB = 0;
                                    for (int j = 0; j < length1; j++)
                                    {
                                        if (chrarray1[j] != chrarray3[j])
                                        {
                                            break;
                                        }
                                        equalA++;
                                    }
                                    for (int j = 0; j < length2; j++)
                                    {
                                        if (chrarray2[j] != chrarray4[j])
                                        {
                                            break;
                                        }
                                        equalB++;
                                    }
                                    //where attachment is created and thrown to related variable
                                    string suffixA = word3.Substring(word3.Length - equalA);
                                    string suffixB = word4.Substring(word4.Length - equalB);
                                    if (!suffixA.Equals(suffixB))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("TYPE : Alternating Rhyme  A - {0}   B - {1}  (A B A B)", suffixA, suffixB);
                                    }
                                    //hoarse rhyme has also been checked in alternating rhyme as it is alternating rhyme
                                    //In addition, the hoarse rhyme is checked as it requires at least six lines.
                                    if (numberoflines - i > 5)
                                    {
                                        string[] array5 = poem[i + 4].Split(' ');
                                        string[] array6 = poem[i + 5].Split(' ');
                                        string word7 = array5[array5.Length - 1];
                                        string word8 = array6[array6.Length - 1];
                                        if ((!word7.Equals(word8)) && (!word6.Equals(word7)))
                                        {
                                            if (word8.EndsWith(suffixB))
                                            {
                                                if (!suffixA.Equals(suffixB))
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("TYPE : Hoarse Rhyme  A - {0}   B - {1}   (A B A B C B)", suffixA, suffixB);
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        //here for the control winding rhyme, parameters are given to the additional rhyme function accordingly and control is provided.
                        if (AddtionalRhyme(word3, word6))
                        {
                            if (AddtionalRhyme(word4, word5))
                            {
                                if ((!word3.Equals(word4)) && (!word5.Equals(word6)))
                                {
                                    int equalA = 0;
                                    int equalB = 0;
                                    for (int j = 0; j < length3; j++)
                                    {
                                        if (chrarray1[j] != chrarray4[j])
                                        {
                                            break;
                                        }
                                        equalA++;
                                    }
                                    for (int j = 0; j < length4; j++)
                                    {
                                        if (chrarray2[j] != chrarray3[j])
                                        {
                                            break;
                                        }
                                        equalB++;
                                    }
                                    //where attachment is created and thrown to related variable
                                    string suffixA = word3.Substring(word3.Length - equalA);
                                    string suffixB = word4.Substring(word4.Length - equalB);
                                    if (!suffixA.Equals(suffixB))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("TYPE : Winding  Rhyme A - {0}   B - {1}   (A B B A)", suffixA, suffixB);
                                    }

                                }
                            }
                        }
                    }
                }
                //Straight rhyme control is done first for AAA format and then for AAAA format.
                if (numberoflines > 2)
                {
                    for (int i = 0; i < numberoflines - 2; i++)
                    {
                        //As in previous operations, the word at the end of the sentence is taken and the sentences are reversed for control.
                        string[] array1 = poem[i].Split(' ');
                        string[] array2 = poem[i + 1].Split(' ');
                        string[] array3 = poem[i + 2].Split(' ');
                        string word3 = array1[array1.Length - 1];
                        string word4 = array2[array2.Length - 1];
                        string word5 = array3[array3.Length - 1];
                        int length1 = Math.Min(word3.Length, word4.Length);
                        int length = Math.Min(length1, word5.Length);
                        char[] chrarray1 = new char[word3.Length];
                        int count1 = 0;
                        for (int j = word3.Length - 1; 0 <= j; j--)
                        {
                            chrarray1[count1] = word3[j];
                            count1++;
                        }
                        char[] chrarray2 = new char[word4.Length];
                        int count2 = 0;
                        for (int j = word4.Length - 1; 0 <= j; j--)
                        {
                            chrarray2[count2] = word4[j];
                            count2++;
                        }
                        char[] chrarray3 = new char[word5.Length];
                        int count3 = 0;
                        for (int j = word5.Length - 1; 0 <= j; j--)
                        {
                            chrarray3[count3] = word5[j];
                            count3++;
                        }
                        if (AddtionalRhyme(word3, word4))
                        {
                            if (AddtionalRhyme(word4, word5))
                            {
                                int equalA = 0;
                                for (int j = 0; j < length; j++)
                                {
                                    if ((chrarray1[j] != chrarray2[j]) || (chrarray2[j] != chrarray3[j]) || (chrarray1[j] != chrarray3[j]))
                                    {
                                        break;
                                    }
                                    equalA++;
                                }
                                string suffixA = word3.Substring(word3.Length - equalA);
                                //If the check for AAAA is correct, check is made so that AAA is not written to the console at the same time.
                                bool havefoura = false;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                if (numberoflines - i > 3)
                                {
                                    string[] array4 = poem[i + 3].Split(' ');
                                    string word6 = array4[array4.Length - 1];
                                    if (word6.EndsWith(suffixA))
                                    {
                                        Console.WriteLine("TYPE : Straight Rhyme   A - {0}   (A A A A)", suffixA);
                                        havefoura = true;
                                    }
                                }
                                if (!havefoura)
                                {
                                    Console.WriteLine("TYPE : Straight Rhyme   A - {0}   (A A A)", suffixA);
                                }
                            }
                        }
                    }
                }
                Console.Read();
            }
            catch (Exception)
            {

            }
        }
    }
}
