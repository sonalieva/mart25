using System;

namespace mart25
{
    class Program
    {
        static void Main(string[] args)
        {
            //string smth = Console.ReadLine();
            //FindFirstWord(smth);
            //string smth = Console.ReadLine();
            //FindWord(smth);
            //Console.WriteLine("daxil olunacaq ededler necedir:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine("Arrayi daxil edin:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(" Xais olunur elave edeceyiniz reqemi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());
          
            //foreach (var item in AddNewNum(ref numbers, num))
            //{

            //    Console.WriteLine(item);
            //}

        }
        static void FindFirstWord(string word)
        {
            string[] word2 = word.Split(' ');
            string newword = word2[0];
            Console.WriteLine(newword);
        }
        string void FindWord(string word)
        {
            string[] word2 = word.Split(' ');
            if (word2.Length == 2)
            {
                if (char.IsUpper(word2[0][0]) && char.IsUpper(word2[1][0]))
                {
                    Console.WriteLine("Iki soz de boyuk herfle baslayir");

                }
            }
        }
        static int[] AddNewNum(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            return arr;

        }
}