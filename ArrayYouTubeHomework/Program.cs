using System;


namespace ArrayYouTubeHomework
{
    class Program
    {
        private static int IndexChecker(int [] array, int element)
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
        static void Main(string[] args)
        {
            int [] MyArray = new int[] { 1, 2, 4234, 5345 };
            Console.WriteLine("Введите искомый элемент");
            bool isInt = Int32.TryParse(Console.ReadLine(),out int userElement);
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
                Console.WriteLine("Ошибка");
            }
            Console.ReadLine();
        }
    }
}
