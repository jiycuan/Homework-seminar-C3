// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.WriteLine("Введите пятизначное число: ");
string nums = Console.ReadLine();

if (nums.Length != 5 )
    Console.WriteLine("Некорректное число");
else if (nums[0] == nums[4] && nums[1] == nums[3])
    Console.WriteLine("Это палиндром");
else Console.WriteLine("Это не палиндром");
*/

// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

/*
Console.WriteLine("Укажите координаты точки А");
Console.WriteLine("X:");
int AX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int AY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:");
int AZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите координаты точки B");
Console.WriteLine("X:");
int BX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int BY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:");
int BZ = Convert.ToInt32(Console.ReadLine());


double X = Math.Pow(AX - BX, 2);
double Y = Math.Pow(AY - BY, 2);
double Z = Math.Pow(AZ - BZ, 2);

double lenght = Math.Sqrt (X + Y + Z);

Console.WriteLine (lenght);
*/

// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
double num;

while (N > 0)
    {
        num = Math.Pow(temp, 3);
        Console.WriteLine(num);
        temp++;
        N--;
    }
*/

