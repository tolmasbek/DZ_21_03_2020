using System;

namespace DZ_21_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                1. Даны два неотрицательных числа a и b. 
                Найти их среднее геометрическое, то
                есть квадратный корень из их произведения: √a·b 
                    a = 16.80
                    b = 12.40
                    результат = 14.43
            */
            
            float a = 16.80f;
            float b = 12.40f;
            float srednee = MathF.Sqrt(a * b);
                Console.WriteLine(srednee);

            /*  
                2. Даны три точки A, B, C на числовой оси. 
                Найти длины отрезков AC и BC и их сумму
                    A = 1.40
                    B = -5.50
                    C = 0.60
                            AC = 0.80
                            BC = 6.10
                    AC+BC = 6.90
            */

            double A = 1.40, B = -5.50, C = 0.60;
            double ac = Math.Abs(C - A);
            double bc = Math.Abs(C - B);
            double abc = ac + bc;
                Console.WriteLine(ac);
                Console.WriteLine(bc);
                Console.WriteLine(abc);

            /*
                3. Найти расстояние между двумя точками с заданными 
                координатами (x1,y1) и (x2,y2) на плоскости. 
                Расстояние вычисляется по формуле √((x2 — x1)^2 + (y2 —y1)^2)
                    x1, y1: -6.20 5.20
                    x2, y2: 2.10 9.80
                    результат = 9.49
            */

            double rastoyanie;
            double x1 = -6.20, y1 = 5.20;
            double x2 = 2.10, y2 = 9.80;
            rastoyanie = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
                Console.WriteLine(rastoyanie);
        
            /*
                4. Дано двузначное число. Вывести число, полученное 
                при перестановке цифр исходного числа.
                    Число: 41
                    Результат: 14
            */

            int chislo = 41;
            int perestanovlenniy = (chislo % 10) * 10 + (chislo / 10);
                Console.WriteLine(perestanovlenniy);
            
            /*
                5. С начала суток прошло N секунд (N — целое). 
                Найти количество полных часов, прошедших с начала суток
                    N = 10985
                    Результат: 183
            */

            int N = 10985;
            int hour = N / 60;
                Console.WriteLine(hour);
            
            /*
                6. Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 —
                понедельник, 2 — вторник, …, 6 — суббота. Дано целое число K, лежащее в
                диапазоне 1–365. Определить номер дня недели для K-го дня года, если
                известно, что в этом году 1 января было понедельником.
                    K = 202
                    Номер дня недели: 6
            */
            
            int K = 202;
            int day = K % 7;
                Console.WriteLine(day);
        }
    }
}
