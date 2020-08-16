using System;
using System.Collections.Generic;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                { "name", "bob" },
                { "email", "bob@gmail.com" },
                { "telephone", "098-858-89-22" },
                { "lastName","sara" }
            };



            //if (dict.TryAdd("email1", "bob@gmail.com"))
            //{
            //    Console.WriteLine("Ключ успешно добавлен!");
            //}

            //else
            //{
            //    Console.WriteLine("Ключ не добавлен!");
            //}

            //var testDict = dict.GetEnumerator();
            //while (testDict.MoveNext())
            //{
            //    Console.WriteLine($"Ключ {testDict.Current.Key}. Значение {testDict.Current.Value}");
            //}

            string name = dict["name"];
            Console.WriteLine(name);



        }

    }

}
