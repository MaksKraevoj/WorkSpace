using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //credit c = new credit();
            //int result = c.Payment(100000, 24, 5000);
            //bool light = result > 0 && result < 25;
            //bool based = result > 25 && result < 50;
            //bool hard = result > 50 && result < 75;

            //if (light == true)
            //{
            //    Console.WriteLine("Все хорошо, можно брать");
            //}

            //else if (based == true)
            //{
            //    Console.WriteLine("Придется экономить!");
            //}

            //else if (hard)
            //{
            //    Console.WriteLine("Будет очень тяжело!!");
            //}

            //else
            //{
            //    Console.WriteLine("Не подходит ни одно условие");
            //}

            string model = Console.ReadLine();

            switch (model)
            {
                case "Sony":
                    Console.WriteLine("Ваша операционная модель Android");
                    break;

                case "Huawei":
                    Console.WriteLine("Ваша операционная модель Android");
                    break;

                default:
                    Console.WriteLine("Не удалось определить операционную систему");
                    break;
            }
            
        }
    }
}
