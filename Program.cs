using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Testing SelectionSort algorithm with list of objects of type Person.");

            Person JohnDoe = new Person("John", "Doe", new DateTime(1990, 12, 5), 195, 90.5);
            Person MujoMujic = new Person("Mujo", "Mujic", new DateTime(1995, 5, 12), 180.5, 78.2);
            Person SomePerson = new Person("Some", "Person", new DateTime(1986, 9, 22), 197.8, 108.2);

            List<Person> list = new List<Person>();
            list.Add(JohnDoe);
            list.Add(MujoMujic);
            list.Add(SomePerson);

            Console.WriteLine("List without sorting: ");
            foreach (Person p in list) Console.WriteLine(p.ToString());

            SortingAlgorithms.InsertionSort(list);
            Console.WriteLine("List after sorting by person's height (ascending): ");
            foreach (Person p in list) Console.WriteLine(p.ToString());


            Console.WriteLine("Testing algorithms with arrays of 100, 1000 and 10000 integers: ");
            
            //Testing with array of 100 integers
            int[] arr1 = new int[100];
            int[] randomElementsArr1 = new int[100];
            var timer = new Stopwatch();
            Random random = new Random();
            for (int i = 0; i < 100; ++i) arr1[i] = random.Next(0, 1000);
            arr1.CopyTo(randomElementsArr1, 0);

            // Testing InsertionSort (100 elements)
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.InsertionSort(arr1);
            timer.Stop();
            TimeSpan time = timer.Elapsed;
            string timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the InsertionSort algorithm for array of 100 integers: " + timeString);

            // Testing PancakeSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.PancakeSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the PancakeSort algorithm for array of 100 integers: " + timeString);

            // Testing SelectionSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.SelectionSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the SelectionSort algorithm for array of 100 integers: " + timeString);

            // Testing CycleSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.CycleSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the CycleSort algorithm for array of 100 integers: " + timeString);
            
            // Testing BubbleSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.BubbleSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the BubbleSort algorithm for array of 100 integers: " + timeString);
           
            // Testing GnomeSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.GnomeSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the GnomeSort algorithm for array of 100 integers: " + timeString);
            
            // Testing ShakerSort (100 elements)
            randomElementsArr1.CopyTo(arr1, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.ShakerSort(arr1);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the ShakerSort algorithm for array of 100 integers: " + timeString);
            
            // Testing with array of 1000 integers
            int[] arr2 = new int[1000];
            int[] randomElementsArr2 = new int[1000];
            for (int i = 0; i < 1000; ++i)
                arr2[i] = random.Next(-10000, 10000);
            arr2.CopyTo(randomElementsArr2, 0);
            
            // Testing InsertionSort (1000 elements)
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.InsertionSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the InsertionSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing PancakeSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);           
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.PancakeSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the PancakeSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing SelectionSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.SelectionSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the SelectionSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing CycleSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);
            timer.Start();
            SortingAlgorithms.CycleSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the CycleSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing BubbleSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.BubbleSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the BubbleSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing GnomeSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);           
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.GnomeSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the GnomeSort algorithm for array of 1000 integers: " + timeString);

            // Testing ShakerSort (1000 elements)
            randomElementsArr2.CopyTo(arr2, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.ShakerSort(arr2);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the ShakerSort algorithm for array of 1000 integers: " + timeString);
            
            // Testing with array of 10000 integers
            int[] arr3 = new int[10000];
            int[] randomElementsArr3 = new int[10000];
            for (int i = 0; i < 10000; ++i)
                arr3[i] = random.Next(-1000000, 1000000);
            arr3.CopyTo(randomElementsArr3, 0);

            // Testing InsertionSort (10000 elements)
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.InsertionSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the InsertionSort algorithm for array of 10000 integers: " + timeString);

            // Testing PancakeSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.PancakeSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the PancakeSort algorithm for array of 10000 integers: " + timeString);

            // Testing SelectionSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.SelectionSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the SelectionSort algorithm for array of 10000 integers: " + timeString);

            // Testing CycleSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.CycleSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the CycleSort algorithm for array of 10000 integers: " + timeString);

            // Testing BubbleSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.BubbleSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the BubbleSort algorithm for array of 10000 integers: " + timeString);

            // Testing GnomeSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.GnomeSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the GnomeSort algorithm for array of 10000 integers: " + timeString);

            // Testing ShakerSort (10000 elements)
            randomElementsArr3.CopyTo(arr3, 0);
            timer = new Stopwatch();
            timer.Start();
            SortingAlgorithms.ShakerSort(arr3);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            Console.WriteLine("The duration of the ShakerSort algorithm for array of 10000 integers: " + timeString);

            // Testing ShakerSort (CoctailSort) with array of chars
            string str = "ztrewq";
            char[] charArr = str.ToCharArray();
            timer = new Stopwatch();            
            timer.Start();
            SortingAlgorithms.ShakerSort(charArr);
            timer.Stop();
            time = timer.Elapsed;
            timeString = "" + time.ToString(@"m\:ss\.fff");
            string sortedAlphabetical = "";
            for (int i = 0; i < charArr.Length; i++)
            {
                sortedAlphabetical += charArr[i];
            }
            Console.WriteLine("String before sorting: " + str);
            Console.WriteLine("String after sorting: " + sortedAlphabetical);
            Console.WriteLine("Sorting previous string with ShakerSort took " + timeString);
        }
    }
}