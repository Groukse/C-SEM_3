/*
// Домашнее задание.

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polydrome()
{
    Console.Write("Imput number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num % 10;
    int num2 = (num / 10) % 10;
    int num3 = (num / 1000) % 10;
    int num4 = num / 10000;
    if (num > 99999 || num < 10000)
        Console.WriteLine("Incorrect number");
    else
        if (num1 == num4 && num2 == num3)
            Console.WriteLine("This number is a palindrome");
        else
            Console.WriteLine("This number is not a palindrome");
}
Polydrome();


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine ("Расстояние между точками = " + dist);
}

Console.WriteLine("Imput coordinates of dot");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput coordinates of the second dot");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());
int Zb = Convert.ToInt32(Console.ReadLine());

Distance(Xa, Ya, Za, Xb, Yb, Zb);

*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Sqrt(int num)
{
    int count = 1;
    Console.Write(num + " -> ");
    while(count <= num){
        Console.Write(count * count * count + " ");
        count++;
    }
}
Console.WriteLine("Imput number: ");
int N = Convert.ToInt32(Console.ReadLine());
Sqrt(N);
