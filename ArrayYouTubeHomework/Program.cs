using System;


namespace ArrayYouTubeHomework
{
    class Program
    {
        private static int IndexChecker(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static int Randomiser()
        {
            Random rnd = new Random();
            int rand = rnd.Next(10);
            return rand;
        }
        static int[] ArrayFller(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Randomiser();
            }
            return arr;
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                int[] MyArray = new int[10];
                ArrayFller(MyArray);

                Console.WriteLine("Введите искомый элемент");
                bool isInt = Int32.TryParse(Console.ReadLine(), out int userElement);
                if (isInt)
                {
                    int result = IndexChecker(MyArray, userElement);
                    if (result != -1)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Совпадений не найдено");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: необходимо ввести целое число");
                }
                Console.ReadLine();
            } 
        }
    }
}
