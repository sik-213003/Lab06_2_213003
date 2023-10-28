using System;
using System.Reflection;
namespace Basics
{
    class lab6
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();

        }
        
        static void ex1()
        {
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
        }

        static void ex2()
        {
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            List<int> intList2 = new List<int>();
            intList2.AddRange(intList);
        }

        static void ex3()
        {
            List<int> intList = new List<int>() { 10, 20, 30 };
            intList.ForEach(el => Console.WriteLine(el));
        }

        static void ex4()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40};
            foreach(var el in intList)
                Console.WriteLine(el);
        }

        static void ex5()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40};
            int elem = intList[1];
        }

        static void ex6()
        {
           List<int> intList = new List<int>() { 10, 20, 30, 40};
           Console.Write("Total Elements: {0}", intList.Count); 
        }

        static void ex7()
        {
           List<int> intList = new List<int>() { 10, 20, 30, 40};
           for(int i = 0; i < intList.Count; i++)
           {
            Console.WriteLine(intList[i]);
           }
        }

        static void ex8(IList<string> list)
        {
            Console.WriteLine("Count: {0}", list.Count);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }

        static void ex9()   
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40};
            intList.Insert(1, 11);

            foreach(var el in intList)
                Console.WriteLine(el);
        }

        static void ex10()
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40};
            intList.Remove(10);
            intList.RemoveAt(2);
        }

        static void ex11()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40};
            bool res = intList.TrueForAll(el => el % 2 == 0);
        }

        static bool isPostiveInt(int i)
        {
            return i > 0;
        }

        static void ex12()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40};
            bool res = intList.TrueForAll(isPostiveInt);
        }
    }
}


