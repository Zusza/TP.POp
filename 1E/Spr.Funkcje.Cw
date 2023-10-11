// 1. Funkcje

// 1.1 - Napisz funkcje która zwraca sume cyfr podaniej liczby

//int SumLiczb(int x)
//{
//    int suma = 0;
//    while(x != 0)
//    {
//        suma += x % 10;
//        x /= 10;
//    }
//    return suma;
//}
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine(SumLiczb(y));

// 1.2 - Napisz funkcje, która zwraca odwrócony do wprowadzonego napis
//string FunNap(string str)
//{
//    char[] napis = str.ToCharArray();
//    char[] napis2 = str.ToCharArray();
//    for (int i = 0; i < napis.Length; i++)
//    {
//        napis[i] = napis2[napis.Length - i - 1];
//    }
//    string Odw = new string(napis);
//    return Odw;
//}

//string c = Console.ReadLine();
//Console.WriteLine(FunNap(c));


// 1.3 - Napisz funkcje, która wypisuje łańcuch połówek wpisanej liczby, aż do 1. Np po wpisaniu 30 otrzymujemy 30-15-7-3-1.

//void Dziel(int v)
//{
//    while(v > 0)
//    {
//        Console.Write(v + "-");
//        v /= 2;
//    }

//}

//int v = int.Parse(Console.ReadLine());
//Dziel(v);

// 2. Ciągi Belgijskie

// 2.1 - Napisz rekurencyjnie n liczb: 3,5,7,9,11...

//int ciag1(int n)
//{
//    if (n == 1) return 3;
//    return ciag1(n - 1) + 2;
//}
//int y = int.Parse(Console.ReadLine());
//for (int i = 1; i <= y; i++)
//{
//    Console.WriteLine(ciag1(i));
//}

// 2.2 - Napisz rekurencyjnie n liczb: 6, 12, 24, 48, 96...

//int ciag2(int n)
//{
//    if (n == 1) return 6;
//    return ciag2(n - 1) * 2;
//}
//int y = int.Parse(Console.ReadLine());
//for (int i = 1; i <= y; i++)
//{
//    Console.WriteLine(ciag2(i));
//}

// 2.3 - Napisz rekurencyjnie n liczb: 1,1,3,5,11,21...

//int reku3(int n)
//{
//    if (n == 1) return 1;
//    if (n == 2) return 1;
//    return 2 * reku3(n - 2) + reku3(n - 1);
//}
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(reku3(i));
//}

// 2.4 - Napisz rekurencyjnie n liczb: 1,2,-1,3,-4,7,-11,18...

//int reku4(int n)
//{
//    if (n == 1) return 1;
//    if (n == 2) return 2;
//    return reku4(n - 2) - reku4(n - 1);
//}
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(reku4(i));
//}

// 2.5 - Napisz rekurencyjnie n liczb: 1,2,3,0,6,3,-3,21...
//Nie zr
//int reku5(int n)
//{
//    if (n == 1) return 1;
//    if (n == 2) return 2;
//    return reku5(n - 2) - reku5(n - 1);
//}
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(reku5(i));
//}

// 3. Pliki

// 3.1 Stwórz plik z dzisiejszą datą

StreamWriter plik = new StreamWriter("C:\\data.txt");

DateTime dzis = DateTime.Today;

plik.WriteLine(dzis.ToString());

plik.Close();

// 3.2 Zapisz do pliku 10 losowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb

// 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.
