using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._05._24r_popr_ćwiczenia_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Nowak1
            ////Zad.0
            //Console.WriteLine("Wpisz 11 cyfr oddzielonych spacjami:");
            //int[] tablica = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //double srednia = tablica.Average();
            //int powyzejSredniej = tablica.Count(x => x > srednia);
            //int ponizejSredniej = tablica.Count(x => x < srednia);

            //if (powyzejSredniej > ponizejSredniej)
            //{
            //    Console.WriteLine("Tablica jest wielkomiejska.");
            //}
            //else if (ponizejSredniej > powyzejSredniej)
            //{
            //    Console.WriteLine("Tablica jest małorolna.");
            //}
            //else
            //{
            //    Console.WriteLine("Tablica jest matomiasteczkowa.");
            //}

            ////Zad.1
            //Random rnd = new Random();
            //int[] tablica = new int[30];
            //for (int i = 0; i < 30; i++)
            //{
            //    tablica[i] = rnd.Next(100, 1000);
            //}
            //int maxLength = 1;
            //int length = 1;
            //int endIndex = 0;
            //int maxSum = tablica[0];
            //int sum = tablica[0];
            //for (int i = 1; i < 30; i++)
            //{
            //    if (tablica[i] > tablica[i - 1])
            //    {
            //        length++;
            //        sum += tablica[i];
            //    }
            //    else
            //    {
            //        if (length > maxLength)
            //        {
            //            maxLength = length;
            //            endIndex = i - 1;
            //            maxSum = sum;
            //        }
            //        length = 1;
            //        sum = tablica[i];
            //    }
            //}
            //if (length > maxLength)
            //{
            //    maxLength = length;
            //    endIndex = 29;
            //    maxSum = sum;
            //}

            //int startIndex = endIndex - maxLength + 1;

            //Console.WriteLine("Tablica: " + string.Join(", ", tablica));
            //Console.WriteLine($"Element początkowy: {tablica[startIndex]}, element końcowy: {tablica[endIndex]}, suma: {maxSum}");

            ////Zad.2
            //Random rnd = new Random();
            //List<int> list1 = Enumerable.Range(0, 10).OrderBy(x => rnd.Next()).Take(6).ToList();
            //List<int> list2 = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    int element = rnd.Next(0, 10);
            //    for (int j = 0; j < 2; j++)
            //    {
            //        list2.Add(element);
            //    }
            //}

            //list2 = list2.OrderBy(x => rnd.Next()).ToList();

            //List<int> wynikowa = new List<int>();

            //var allElements = list1.Concat(list2).ToList();
            //foreach (var item in allElements.Distinct())
            //{
            //    int count = allElements.Count(x => x == item);
            //    if (count > 2)
            //    {
            //        wynikowa.Add(item);
            //        wynikowa.Add(item);
            //    }
            //}

            //Console.WriteLine("Lista 1: " + string.Join(", ", list1));
            //Console.WriteLine("Lista 2: " + string.Join(", ", list2));
            //Console.WriteLine("Lista wynikowa: " + string.Join(", ", wynikowa));

            ////Zad.3
            //    Random rnd = new Random();
            //    List<string> arrayList = new List<string>();
            //    string letters = "ABCD";

            //    for (int i = 0; i < 30; i++)
            //    {
            //        string str = new string(Enumerable.Range(0, 3).Select(x => letters[rnd.Next(4)]).ToArray());
            //        arrayList.Add(str);
            //    }

            //    List<(string, string)> anagramPairs = new List<(string, string)>();

            //    for (int i = 0; i < arrayList.Count; i++)
            //    {
            //        for (int j = i + 1; j < arrayList.Count; j++)
            //        {
            //            if (IsAnagram(arrayList[i], arrayList[j]))
            //            {
            //                anagramPairs.Add((arrayList[i], arrayList[j]));
            //            }
            //        }
            //    }

            //    Console.WriteLine("ArrayList: " + string.Join(", ", arrayList));
            //    Console.WriteLine("Anagram pairs: " + string.Join(", ", anagramPairs.Select(pair => $"({pair.Item1}, {pair.Item2})")));
            //    Console.WriteLine($"Number of anagram pairs: {anagramPairs.Count}");
            //}

            //static bool IsAnagram(string str1, string str2)
            //{
            //    return string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
            //}

            ////Zad.4
            //Console.WriteLine("Podaj liczbę wierzchołków n:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj liczbę krawędzi k:");
            //int k = int.Parse(Console.ReadLine());

            //Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            //for (int i = 1; i <= n; i++)
            //{
            //    graph[i] = new List<int>();
            //}

            //Console.WriteLine("Podaj krawędzie w formacie u v:");

            //for (int i = 0; i < k; i++)
            //{
            //    var edge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    graph[edge[0]].Add(edge[1]);
            //    graph[edge[1]].Add(edge[0]);
            //}

            //Console.WriteLine("Podaj wierzchołki a i b do sprawdzenia:");
            //var vertices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int a = vertices[0], b = vertices[1];

            //bool found = false;

            //foreach (var neighbor in graph[a])
            //{
            //    if (graph[neighbor].Contains(b))
            //    {
            //        Console.WriteLine($"Połączenie a-x-b istnieje: {a}-{neighbor}-{b}");
            //        found = true;
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Nie znaleziono połączenia a-x-b");
            //}
            /////---------------------------------------------------------------------------------------
            /////Nowak2
            //////Zad.0
            ////// Prompt user to enter 7 integers separated by hyphens
            //Console.WriteLine("Enter 7 integers separated by hyphens (e.g., 1-2-3-4-5-6-7):");
            //string input = Console.ReadLine();

            ////// Split the input into an array of integers
            //string[] inputArray = input.Split('-');
            //int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            ////// Check if the array is non-decreasing (wielkomiejska)
            //bool isNonDecreasing = true;
            //bool isNonIncreasing = true;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < numbers[i - 1])
            //        isNonDecreasing = false;
            //    if (numbers[i] > numbers[i - 1])
            //        isNonIncreasing = false;
            //}

            ////// Print the results
            //if (isNonDecreasing)
            //{
            //    Console.WriteLine("The array is wielkomiejska (non-decreasing).");
            //}
            //else if (isNonIncreasing)
            //{
            //    Console.WriteLine("The array is małorolna (non-increasing).");
            //}
            //else
            //{
            //    Console.WriteLine("The array is neither wielkomiejska nor małorolna.");
            //}

            ////// Check for małomiasteczkowa array (both non-decreasing and non-increasing)
            //if (isNonDecreasing && isNonIncreasing)
            //{
            //    Console.WriteLine("The array is also małomiasteczkowa (both non-decreasing and non-increasing).");
            //}

            ////// Declare a małomiasteczkowa array
            //int[] malomiasteczkowaArray = { 1, 1, 1, 1, 1, 1, 1 };
            //Console.WriteLine("An example of a małomiasteczkowa array: " + string.Join("-", malomiasteczkowaArray));



            //////Zad.1
            ////// Initialize random number generator
            //Random rand = new Random();

            ////// Create and fill the array with random integers between -9 and 9
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(-9, 10); //// Random number between -9 and 9
            //}

            ////// Find the subarray with the maximum sum using Kadane's algorithm
            //int maxSum = int.MinValue;
            //int currentSum = 0;
            //int start = 0, end = 0, tempStart = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    currentSum += array[i];

            //    if (currentSum > maxSum)
            //    {
            //        maxSum = currentSum;
            //        start = tempStart;
            //        end = i;
            //    }

            //    if (currentSum < 0)
            //    {
            //        currentSum = 0;
            //        tempStart = i + 1;
            //    }
            //}

            ////// Print the results
            //Console.WriteLine("Array: " + string.Join(", ", array));
            //Console.WriteLine("Maximum Sum Subarray:");
            //Console.WriteLine("Start Index: " + start);
            //Console.WriteLine("End Index: " + end);
            //Console.WriteLine("Sum: " + maxSum);



            ////Zad.2
            //int n = 3; //// Example odd number; this can be changed as needed.
            //if (n % 2 == 0 || n < 3)
            //{
            //    throw new ArgumentException("n must be an odd number and at least 3.");
            //}

            ////// Initialize the 3D list
            //List<List<List<int>>> cube = new List<List<List<int>>>();
            //Random rand = new Random();

            ////// Fill the cube with random natural numbers
            //for (int i = 0; i < n; i++)
            //{
            //    List<List<int>> plane = new List<List<int>>();
            //    for (int j = 0; j < n; j++)
            //    {
            //        List<int> row = new List<int>();
            //        for (int k = 0; k < n; k++)
            //        {
            //            row.Add(rand.Next(1, 10)); //// Random numbers between 1 and 9
            //        }
            //        plane.Add(row);
            //    }
            //    cube.Add(plane);
            //}

            //// Display the cube (optional)
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Plane {i}:");
            //    for (int j = 0; j < n; j++)
            //    {
            //        for (int k = 0; k < n; k++)
            //        {
            //            Console.Write(cube[i][j][k] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            ////// Calculate the sum of the four main diagonals
            //int mainDiagonal1 = 0;
            //int mainDiagonal2 = 0;
            //int mainDiagonal3 = 0;
            //int mainDiagonal4 = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    mainDiagonal1 += cube[i][i][i];             //// (0,0,0) to (n-1,n-1,n-1)
            //    mainDiagonal2 += cube[i][i][n - 1 - i];     //// (0,0,n-1) to (n-1,n-1,0)
            //    mainDiagonal3 += cube[i][n - 1 - i][i];     //// (0,n-1,0) to (n-1,0,n-1)
            //    mainDiagonal4 += cube[i][n - 1 - i][n - 1 - i]; //// (0,n-1,n-1) to (n-1,0,0)
            //}

            ////// Sum of all four main diagonals
            //int totalSum = mainDiagonal1 + mainDiagonal2 + mainDiagonal3 + mainDiagonal4;

            ////// Output the results
            //Console.WriteLine("Sum of elements on the four main diagonals:");
            //Console.WriteLine("Main Diagonal 1: " + mainDiagonal1);
            //Console.WriteLine("Main Diagonal 2: " + mainDiagonal2);
            //Console.WriteLine("Main Diagonal 3: " + mainDiagonal3);
            //Console.WriteLine("Main Diagonal 4: " + mainDiagonal4);
            //Console.WriteLine("Total Sum: " + totalSum);



            //////Zad.3
            ////// Wczytywanie ilości wierzchołków i krawędzi
            //Console.Write("Podaj ilość wierzchołków: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Podaj ilość krawędzi: ");
            //int k = int.Parse(Console.ReadLine());

            ////// Tworzenie grafu nieskierowanego
            //Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            //for (int i = 1; i <= n; i++)
            //{
            //    graph[i] = new List<int>();
            //}

            ////// Wczytywanie krawędzi
            //for (int i = 0; i < k; i++)
            //{
            //    Console.Write("Podaj krawędź (w formacie a-b): ");
            //    string[] edge = Console.ReadLine().Split('-');
            //    int a = int.Parse(edge[0]);
            //    int b = int.Parse(edge[1]);

            //    graph[a].Add(b);
            //    graph[b].Add(a);
            //}

            ////// Wczytywanie wierzchołków do sprawdzenia
            //Console.Write("Podaj wierzchołki do sprawdzenia (w formacie a-b): ");
            //string[] vertices = Console.ReadLine().Split('-');
            //int v1 = int.Parse(vertices[0]);
            //int v2 = int.Parse(vertices[1]);

            ////// Sprawdzanie bezpośredniego połączenia
            //if (graph[v1].Contains(v2))
            //{
            //    Console.WriteLine($"Istnieje bezpośrednie połączenie między wierzchołkami {v1} i {v2}");
            //}
            //else
            //{
            //    bool indirectConnection = false;

            //    //// Sprawdzanie połączenia przez jednego pośrednika
            //    foreach (int neighbor in graph[v1])
            //    {
            //        if (graph[neighbor].Contains(v2))
            //        {
            //            indirectConnection = true;
            //            break;
            //        }
            //    }

            //    if (indirectConnection)
            //    {
            //        Console.WriteLine($"Istnieje połączenie między wierzchołkami {v1} i {v2} przez dokładnie jednego pośrednika");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Nie istnieje połączenie między wierzchołkami {v1} i {v2} ani bezpośrednie, ani przez jednego pośrednika");
            //    }
            //}
        }
    }
}
