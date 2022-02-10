using System;
using System.IO;
using System.Text;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomGenerator();
            SortOne();
            SortTwo();
        }
        public static void RandomGenerator()
        {
            Random numberGen = new Random();
            int amountToOutput = 10;
            int minimumRange = 1;
            int maximumRange = 1000000; 
            Int64 x;

            string fileName = @"C:\Temp\Temp01.txt";

            try
            {

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                //Open the File
                StreamWriter sw = new StreamWriter(fileName, true, Encoding.ASCII);

                //Write out the numbers 1 to 10 each on the new line.
                for (x = 0; x < amountToOutput; x++)
                {
                    int randomNumber = numberGen.Next(minimumRange, maximumRange);
                    sw.WriteLine(randomNumber);
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            //read the file and display on the console
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static void SortOne()
        {
            //implementation needed
        }

        public static void SortTwo()
        {
            //implementation needed
        }       
    }
}
