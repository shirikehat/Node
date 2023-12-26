using System.Collections.Specialized;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int Count(Node<int> train)
        {
            int counter = 0;
            while(train != null)
            {
                counter++;
                train= train.GetNext();
            }
            return counter;
        }

        public static int CountRec(Node<int> train)
        {
            int counter = 0;
            if (train != null) return 0;
            
            return 1+CountRec(train.GetNext());
        }

        public static void DoubleVal(Node<int> train)
        {
            while(train != null)
            {
                train.SetValue(train.GetValue() * 2);
                train= train.GetNext();
            }
            
        }

        static void Main(string[] args)
        {
            Node<int> b = new Node<int>(4);
            Node<int> a = new Node<int>(8,b);
            Node<int> a0 = new Node<int>(12, a);
            int result = Count(a0);
            Console.WriteLine(result);
        }
    }
}