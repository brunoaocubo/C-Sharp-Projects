using System;
using System.Collections.Generic;

namespace projects
{
    public class  Playground01()
    {
        static void AddToList(List<object> list, string value)
        {
            list.Add(value);

            foreach (object obj in list)
            {
                if(list.Count >= 5)
                {
                    //double converObj = Convert.ToDouble(obj);
                    bool number = double.TryParse(obj.ToString(), out double result);

                    if (number)
                    {
                        Console.WriteLine(obj);
                    }
                    else
                    {
                        Console.WriteLine($"Desculpe, o valor {obj} não é um número");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<object> listObj = new List<object>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Insira o valor do {i}º número: ");
                var myInput = Console.ReadLine();

                if (myInput != null) { AddToList(listObj, myInput); }
            }
        }
    }
}