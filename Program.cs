using System;
namespace Lab_1
{
    public class lab_program
    {
        static public int V(int a, int b, int c)
        {
            int V = a * b * c;
            return V;
        }
        static public int S(int a, int b, int c)
        {
            int S = 2 * (a * b + b * c + a * c);
            return S;
        }
        static void Main()
        {
            Console.WriteLine("Введіть довжину ребра a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть довжину ребра b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть довжину ребра c:");
            int c = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Неможливо вирахувати площу поверхні. Довжина кожного ребра повинна бути більшою за нуль.");
                return;
            }

            int V = a * b * c;
            int S = 2 * (a * b + b * c + a * c);

            Console.WriteLine($"Об'єм паралелепіпеда: {V}");
            Console.WriteLine($"Площа поверхні паралелепіпеда: {S}");
        }
    }
}
