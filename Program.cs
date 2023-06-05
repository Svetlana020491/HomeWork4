internal class Program
{
    private static void Main(string[] args)
    {
        int InputNumber(string text) // метод для ввода начальной информации 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());

        }

        void Task25()

        {//Задача 25: Используя определение степени числа, напишите цикл, 
         //который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
         // 3, 5 -> 243 (3⁵)
         // 2, 4 -> 16

            int numberA = 3;
            int numberB = 5;
            int result = 1;
            for (int i = 0; i < numberB; i++)
            {
                result = result * numberA;
            }
            Console.WriteLine($"{numberA} в степени {numberB} равно {result}");
        }

        void Task27()
        {
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            // 452 -> 11
            // 82 -> 10
            // 9012 -> 12

            int numberA = InputNumber("введите число");
            int sum = 0;
            while (numberA > 0)
            {
                sum += numberA % 10;
                numberA /= 10;
            }
            Console.WriteLine($"Сумма всех числе {numberA} равна {sum}");

        }

        void Task29_2()
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 
            //случайных целых чисел и выводит отсортированный по модулю массив.
            // -> [1, 2, 5, 7, 19]
            // 6, 1, 33 -> [6, 1, 33]

            int size = 8;
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                int MinPoz = i;
                for (int g = i+1; g < array.Length; g++)
                {
                    if (array[g] < array[MinPoz])
                    MinPoz = g;
                }
                int temporary = array[i];
                array[i] = array[MinPoz];
                array[MinPoz] = temporary;
                
                Console.Write($"{array[i]} ");}
        }

        Console.Clear(); 
        Task29_2();
    }
}







        
    



  

    