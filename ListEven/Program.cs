using System.Collections.Generic;

namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine();
            Console.WriteLine("Chetni " + string.Join(" ", GetEvenElements(list)));
            Console.WriteLine("Nechetni " + string.Join(" ", GetOddElements(list)));
        }

        static List<int> GetEvenElements(List<int> input)
        {
            List<int> listEven = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    listEven.Add(input[i]);
                }
            }
            return listEven;
        }
        static List<int> GetOddElements(List<int> inputs)
        {
            List<int> listOdd = new List<int>();
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] % 2 == 0)
                {

                }
                else
                {
                    listOdd.Add(inputs[i]);
                }
            }
            return listOdd;
        }
    }
}

