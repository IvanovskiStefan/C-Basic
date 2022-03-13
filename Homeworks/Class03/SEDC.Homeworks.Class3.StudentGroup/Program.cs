using System;

namespace SEDC.Homeworks.Class3.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[]
            {
                    "Slobodanka",
                    "Stefan",
                    "Bojan",
                    "Kristina"
            };

            string[] studentsG2 = new string[]
            {
                    "Petre",
                    "Mitre",
                    "Delfina",
                    "Pandora"
            };
            int lenghtOfG1 = studentsG1.Length;
            int lenghtOfG2 = studentsG2.Length;


            //parsiranje na brojot od konsola
            Console.WriteLine("1.Select 1 for G1 students");
            Console.WriteLine("2.Select 2 for G2 students");



            string inputFromConsole = Console.ReadLine();
            bool parsedInput = int.TryParse(inputFromConsole, out int parsedInputFromConsole);

            for (int i = 0; i < lenghtOfG1; i++)
            {
                if (parsedInputFromConsole == 1)
                {
                    Console.WriteLine("The Students in G1 are:" + " " + studentsG1[i]);
                }
                else if (parsedInputFromConsole == 2)
                {
                    Console.WriteLine("The Students in G2 are:" + " " + studentsG2[i]);
                }
                else
                {
                    Console.WriteLine("enter a valid number");
                }


            }

        }
    }
}
