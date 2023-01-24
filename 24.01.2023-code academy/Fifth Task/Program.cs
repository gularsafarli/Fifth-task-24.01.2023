using System;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace Fifth_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = 10;
            //Plus10(ref num);
            //Console.WriteLine(num);

            //int number = 180;
            //CorrectPoint(ref number);
            //Console.WriteLine(number);

            //var numbers1 = new int[] { 2, 13,4,8 };
            //ChooseEven(ref numbers1);
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    Console.WriteLine(numbers1);
            //}

            #region Methods
            //char symbol = 'a';
            //Console.WriteLine(char.IsDigit(symbol));

            //Console.WriteLine(char.IsLetter('a'));

            //Console.WriteLine(char.IsLower('h'));
            //Console.WriteLine(char.IsNumber('8'));
            //Console.WriteLine(char.IsPunctuation('@'));
            //Console.WriteLine(char.IsLetterOrDigit('!'));

            //Console.WriteLine("Password daxil edin:");
            //string password = Console.ReadLine();
            //if (char.IsUpper(password[0]))
            //{
            //    Console.WriteLine(" password boyuk herfle baslamamalidir");
            //}

            //string password;
            //do
            //{
            //    Console.WriteLine("Password daxil edin:");
            //    password = Console.ReadLine();
            //} while (char.IsDigit(password[0]));

            //string name = "salam";
            //Console.WriteLine(char.ToUpper(name[0])); 

            //string str = "  Hello World  ";
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.TrimStart());

            //string name = "Abdullah";
            //Console.WriteLine(name.Contains("Abdul"));
            //Console.WriteLine(name.Contains('L'));
            //Console.WriteLine(name.Substring(2,3));
            //Console.WriteLine(name.IndexOf("h"));

            //string word = "Hello Azerbaijan";
            //Console.WriteLine(word.IndexOf("SEHER"));
            //Console.WriteLine(word.IndexOf("seher"));
            //Console.WriteLine(word.LastIndexOf('e'));
            //Console.WriteLine(word.Substring(0, word.IndexOf(' ')));
            // Console.WriteLine(word.Substring(word.IndexOf(' ')+1));

            //int[] numbers = { 2, 34, 678 };
            //var Index = Array.IndexOf(numbers, 678);
            //Console.WriteLine(Index);

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion


        }


                

    }


    #region AcademyTask1 Verilmis ededi 10 vahid artiran metod
    //   static void Plus10(ref int number)
    //   {
    //    number += 10;
    //   }
    #endregion

    #region Academy Task2 Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 eden metod.

    //static void CorrectPoint(ref int num)
    //{
    //    if (num < 0)
    //    {
    //        num = 0;
    //    }
    //    else if (num > 100)
    //    {
    //        num = 100;
    //    }
    //}
    #endregion

    #region Verilmis ededler siyahisini yalniz cut deyerler qalan yeni bir arraye-e ceviren metod
    //static void ChooseEven(ref int[] numbers)
    //{
    //    int count = 0;
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        if (numbers[i] % 2 == 0)
    //        {
    //            count++;
    //        }
    //    }

    //    int[] NewArray = new int[count];

    //    int j = 0;
    //    for (int i = 0; i < NewArray.Length; i++)
    //    {
    //        if (NewArray[i] % 2 == 0)
    //        {
    //            NewArray[j] = numbers[i];
    //            j++;
    //        }
    //    }
    //    numbers = NewArray;
    //}
    #endregion

    #region Homework Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
    //static void Createarry (ref int[] nums, ref int number)
    //{
    //    int[] numArry = new int[nums.Length + 1];
    //    int count = 0;
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        numArry[count] = nums[i];
    //       count++;
    //    }
    //    nums = numArry;
    //}
    #endregion


}


