using System;
using System.Linq;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] students = {"Elijah", "Bryan", "Micheal", "Matt", "Muiz"};

            // for(var i=0; i<4; i++){
            //     System.Console.WriteLine(students[i]);
            // }

            //properties available in Array Class
            //System.Console.WriteLine(students.Length);

            //checks if the size of the elements in te array is fixed, and if fied, returns true
           // System.Console.WriteLine(students.IsFixedSize);

            // Array.Reverse(students);
            // System.Console.WriteLine(students[0]);

            // System.Console.WriteLine(Array.Find(students, (e => e.Contains("M"))));
            // System.Console.WriteLine(Array.Find(students, (x => x.EndsWith("iz"))));
            // System.Console.WriteLine(Array.Find(students, (x => x.StartsWith("Bry"))));

            //This finds the index number of a particular predicate by passing 4 parameters into the Find Index Method such as tha array, index number, length of array and the presicate.
            //System.Console.WriteLine(Array.FindIndex(students, 0, 5, (e => e.Contains("Bry")) ) );
            //System.Console.WriteLine(Array.FindIndex(students, 0, 5, (e => e.StartsWith("Ma"))));

            //System.Console.WriteLine(Array.IndexOf(students, "Bryan"));

            

            // int [] strangeNumbers = {89, 34, 79, 5, 10, 43};

            // //clears the array element position and set the element to the default type
            // Array.Clear(strangeNumbers, 0, 6);

            // System.Console.WriteLine(strangeNumbers[0]);


            //sorts the array in increasing Order; you can use .Reverse() to return in descending order
            // Array.Sort(strangeNumbers);
            // foreach(var i in strangeNumbers)
            // {
            //     System.Console.WriteLine(i);
            // }

            // string [] values = {"Elijah", "Bryan", "Micheal", "Matt", "Muiz"};

            // Array.Sort(values);
            //  foreach(var i in values)
            // {
            //     System.Console.WriteLine(i);
            // }


            int[] numbers = {23, 47, 89, 64, 102, 90, 2, 5, 10};
            Array.Reverse(numbers);

            //using Linq namespace to use the Sum extension method
            int sum = numbers.Sum();
            System.Console.WriteLine(sum);
    

            // foreach(var num in numbers)
            // {
            //     System.Console.WriteLine(num + 5);
                
                
            // }


            //This loops through the array and sum the numbers up and pprint the sum.
            //int sum = 0;

            // foreach( var i in numbers)
            // {
                
            //     sum += i;
            // }
            // System.Console.WriteLine(sum);


            //This loops through the array and sum the numbers up and pprint the sum.
            // for(int i = 0; i<9; i++)
            // {
            //     sum += numbers[i];
            // }
            // System.Console.WriteLine(sum);
            
        }
    }
}
