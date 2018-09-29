using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document_Merger
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            Console.WriteLine("Document Merger\n");

            Console.WriteLine("Please enter the name of the first text file: ");
            string name1 = Console.ReadLine();

            try
            {
                StreamReader streamReader = new StreamReader(name1 + ".txt");
                line = streamReader.ReadLine();

                while (name1 != null)
                {
                    Console.WriteLine(streamReader);
                    line = streamReader.ReadLine(); 
                }

                streamReader.Close();

                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", name1);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
