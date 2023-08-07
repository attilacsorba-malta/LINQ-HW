using System.Collections.Generic;
namespace LINQ_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HW task 1
            //************************************************************************

            List<int> listOfIntegers = new List<int>() { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

            var listOfSelectedIntegers = listOfIntegers.Where(num => num > 40 && num < 70).ToList();

            foreach (int num in listOfSelectedIntegers)
            {
                Console.WriteLine(num);
            }

            //HW task 2
            //************************************************************************

            List<string> listOfAnimals = new List<string>() {"ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            "sheep", "tiger", "wolf"};

            var listOfSelectedAnimals = listOfAnimals.Where(animal => animal.Length > 5).ToList();
            var selectedAnimalsUpper = listOfSelectedAnimals.Select(animal => animal.ToUpper()).ToList();

            foreach (string animal in selectedAnimalsUpper)
            {
                Console.WriteLine(animal);
            }


            //HW task 3
            //************************************************************************

            List<string> listOfAnimals = new List<string>() {"ant", "cat", "cow", "dog", "elephant", "horse", "hare", "kangaroo", "lion",
            "sheep", "tiger", "wolf"};

            var listOfSelectedAnimals = listOfAnimals.Where(animal => animal.StartsWith("h") && animal.EndsWith("e")).ToList();

            foreach (string animal in listOfSelectedAnimals)
            {
                Console.WriteLine(animal);
                //            }


                //HW task 4
                //************************************************************************

                List<int> listOfIntegers = new List<int>() { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

                var listOfSelectedIntegers = listOfIntegers.OrderByDescending(number => number).Take(5).ToList();

                foreach (int number in listOfSelectedIntegers)
                {
                    Console.WriteLine(number);

                }


                //HW task 5
                //************************************************************************

                List<int> listOfIntegers = new List<int>() { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

                var listOfSelectedIntegers = listOfIntegers.Where(i => i * i > 7000).Select(numbers => $"{numbers} - {numbers * numbers}");

                foreach (string i in listOfSelectedIntegers)
                {
                    Console.WriteLine(i);
                }


                //HW task 6
                //************************************************************************

                List<string> listOfAnimals = new List<string>() {"ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            "sheep", "tiger", "wolf"};

                var listOfAnimalsChanged = listOfAnimals.Select(animal => animal.Replace("an", "*")).ToList();

                foreach (var animal in listOfAnimalsChanged)
                {
                    Console.WriteLine(animal);
                }

                //HW task 7
                //************************************************************************

                List<string> listOfAnimals = new List<string>() {"ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
"sheep", "tiger", "wolf"};

                var listOfSelectedAnimal = listOfAnimals.OrderBy(i => i).Where(i => i.Contains("e")).Last();

                Console.WriteLine(listOfSelectedAnimal);


                //HW task 8
                //************************************************************************

                List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

                Random random = new Random();

                var mixedIntegerList = integerList.OrderBy(x => random.Next()).ToList();

                foreach (int integer in mixedIntegerList)
                {
                    Console.WriteLine(integer);
                }



            }
        }
    }