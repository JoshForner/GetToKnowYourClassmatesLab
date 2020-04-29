using System;

namespace GetToKnowYourClassmatesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our class!");
            string[] students = { "Josh", "Kat", "Ryan", "Phil", "Diane", "Sam" };
            string[] foods = { "pizza", "tacos", "shrimp", "steak", "lobster", "chicken" };
            string[] color = { "orange", "black", "green", "blue", "yellow", "pink" };
            string[] height = { "6'1\"", "5'2\"", "6'6\"", "6'", "5'8\"", "5'10\"" };
            bool running = true;
            while (running)
            {
                bool running1 = true;
                int index = 0;
                string student = "";
                foreach (string name in students)
                {
                    Console.Write(name + " ");
                }
                while (running1)
                {
                    Console.WriteLine();
                    Console.Write($"Please enter a number between 0 and {students.Length - 1} or a student's name: ");
                    string input = Console.ReadLine().ToLower();
                    bool running2 = true;
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (input == students[i].ToLower())
                        {
                            index = i;
                            student = students[index];
                            running1 = false;
                            running2 = false;
                        }
                    }
                    while (running2)
                    {
                        try
                        {
                            index = int.Parse(input);
                            if (index >= 0 && index < students.Length)
                            {
                                student = students[index];
                                running1 = false;
                                break;
                            }
                            else
                            {
                                throw new Exception($"{input} is out of the range of 0 and {students.Length - 1}");
                            }
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{input} is not a number or a name in the class!");
                            Console.WriteLine();
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine();
                            Console.WriteLine(e.Message);
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                if (student != "")
                {
                    Console.WriteLine();
                    Console.WriteLine($"You selected {student}");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write($"What would like to learn about {student}? type ff, fc or ht : ");
                        string answer1 = Console.ReadLine().ToLower();
                        try
                        {
                            if (answer1 == "ff")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"The favorite food of {student} is {foods[index]}");
                                Console.WriteLine();
                                break;
                            }
                            if (answer1 == "fc")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"The favorite color of {student} is {color[index]}");
                                Console.WriteLine();
                                break;
                            }
                            if (answer1 == "ht")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{student} is {height[index]} tall");
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                throw new Exception($"Not a valid input");
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine();
                            Console.WriteLine(e.Message);
                            Console.WriteLine();
                        }
                    }
                }
                while (true)
                {
                    Console.Write("Would you like to learn about another student? y/n : ");
                    string answer = Console.ReadLine();
                    try
                    {
                        if (answer == "y")
                        {
                            Console.WriteLine();
                            break;
                        }
                        if (answer == "n")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Goodbye!");
                            running = false;
                            break;
                        }
                        else
                        {
                            throw new Exception("Use y or n");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}