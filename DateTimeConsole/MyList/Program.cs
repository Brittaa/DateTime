using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(1);//lisab 1 muutuja massivi juurde
            numbers.AddRange(new int[3] { 6, 7, 8 });


            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }


            int index = numbers.IndexOf(1);
            Console.WriteLine($"Value of IndexOf: {index}");
            int lastIndex = numbers.LastIndexOf(1);
            Console.WriteLine($"Value of LastIndexOf: {lastIndex}");
            //numbers.RemoveAt(lastIndex);

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            int sizeOfList = numbers.Count;
            Console.WriteLine($"Your list is {sizeOfList} long.");

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            //empty the list
            numbers.Clear();

            foreach (int element in numbers)
            {
                Console.WriteLine($"List after Clear() {element}");
            }


        }
    }
}
