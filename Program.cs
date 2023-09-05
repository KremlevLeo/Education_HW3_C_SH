internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu();
    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Palindrome number");
        Console.WriteLine("2) Distance between points");
        Console.WriteLine("3) Table of cobs");
        Console.WriteLine("4) Calculating the area");
        Console.WriteLine("5) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                Console.Clear();
                Console.Write("Enter a five-digit number: ");
                int number = int.Parse(Console.ReadLine());
                if (NumCompar(number))
                {
                    Console.WriteLine($"{number} -> Yes");
                }
                else
                {
                    Console.WriteLine($"{number} -> No");
                }
                return true;
            case "2":
                //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                Console.Clear();
                int[] pointArrA = EntPointCoord("A");
                int[] pointArrB = EntPointCoord("B");
                double res = Math.Round(Math.Sqrt(Math.Pow(pointArrB[0] - pointArrA[0], 2) + Math.Pow(pointArrB[1] - pointArrA[1], 2) + Math.Pow(pointArrB[2] - pointArrA[2], 2)), 2);
                Console.Write($"A({pointArrA[0]}, {pointArrA[1]}, {pointArrA[2]}); B({pointArrB[0]}, {pointArrB[1]}, {pointArrB[2]}) -> {res}");
                return true;
            case "3":
                //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
                Console.Clear();
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                double[] cubArr = Cubing(number);
                PrintArr(cubArr);
                return true;
            case "4":
            //Напишите программу для вычисления площади круга, прямоугольника и треугольника.
                SubMenu();
                return true;
            case "5":
                return false;
            default:
                return false;
        }

    }
    private static bool SubMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Circle");
        Console.WriteLine("2) Rectangle");
        Console.WriteLine("3) Triangle");
        Console.WriteLine("4) Exit");
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Enter a radius of circle: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Аrea of the circle = " + Math.Round(Math.PI * Math.Pow(radius, 2), 2));
                return true;
            case "2":
                Console.Write("Enter a height of rectangle: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Enter a width of rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Аrea of the rectangle = " + Math.Round(height * width, 2));
                return true;
            case "3":
                Console.Write("Enter side A: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                double sideC = double.Parse(Console.ReadLine());
                height = (sideA + sideB + sideC) / 2;
                double S = Math.Round(Math.Sqrt(height * (height - sideA) * (height - sideB) * (height - sideC)),2);
                Console.WriteLine("Аrea of the triangle = " + S);
                return true;
            case "4":
                return false;
            default:
                return false;

        }
    }
    /// <summary>
    /// Разбивает число по массиву
    /// </summary>
    /// <param name="a">Разбиваемое число</param>
    /// <returns></returns>
    private static bool NumCompar(int a)
    {
        int[] array = new int[4];
        array[0] = a / 10000;
        array[1] = a / 1000 % 10;
        array[2] = a % 100 / 10;
        array[3] = a % 10;
        if (array[0] == array[3] & array[1] == array[2]) return true;
        else return false;
    }
    /// <summary>
    /// Координаты точек
    /// </summary>
    /// <param name="namePoint">Имя точки</param>
    /// <returns></returns>
    private static int[] EntPointCoord(string namePoint)
    {
        int[] pointArr = new int[3];
        for (int i = 0; i <= 2; i++)
        {
            Console.Write($"Enter {i + 1} coordinate point {namePoint}: ");
            pointArr[i] = int.Parse(Console.ReadLine());
        }
        return pointArr;
    }
    /// <summary>
    /// Возведение массива в куб
    /// </summary>
    /// <param name="numb">Чило до которого возводит в куб</param>
    /// <returns></returns>
    private static double[] Cubing(int numb)
    {
        double[] cubArr = new double[numb];
        for (int i = 0; i < cubArr.Length; i++)
        {
            cubArr[i] = Math.Round(Math.Pow(i + 1, 3), 0);
        }
        return cubArr;
    }
    /// <summary>
    /// Распечатать массив
    /// </summary>
    /// <param name="arr">Массив на распечатку</param>
    private static void PrintArr(double[] arr)
    {
        Console.Write($"{arr.Length} -> ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
}