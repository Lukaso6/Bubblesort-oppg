using System;

namespace BubbleSortOppg
{
    class SortingTest
    {
        static void Main(string[] args)
        {
            // timer
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            // timer


            // lager en array og setter maks antall nummer
            int[] arr = new int[50];
            RandomArrTall(arr);


            // Caller metoden
            BubbleSort(arr);

            // timer
            watch.Stop();
            // timer

            // vise arrayen
            Console.WriteLine("Sorted:");
            PrintArray(arr);

            // timer
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            // timer
        }


        // metode for og fylle arrayen med forskjellige tall
        static void RandomArrTall(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        // bubblesort koden
        static void BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        // print metode
        static void PrintArray(int[] array)
        {
            foreach (int p in array)
                Console.Write(p + "  ");
            Console.WriteLine();
        }
    }
}

// oppg 2: jeg syntes oprinelig at bubblesort var ganske raskt, men etter det tok 17 minutter og sortere 500 000 tilfeldige tall ser jeg hvorfor det finnes sorterings algoritmer tom quicksort
// oppg 3: letteste måten og forandre fra stigende til synkende er og forandre > til < i if statmentet i bubblesort koden

