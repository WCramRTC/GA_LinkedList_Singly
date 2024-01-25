using System.Security;

namespace GA_LinkedList_Singly
{
    internal class Program
    {
        static void Main(string[] args)
        {
          LinkeListDoubly<int> doubly = new LinkeListDoubly<int>();

            for (int i = 0; i < 10; i++)
            {
                doubly.Add(i);
            }

            doubly.PrintReverse();


        } // main

        public static void Singly()
        {
            LinkedListSingly linked = new LinkedListSingly();

            Console.WriteLine("Populate");
            for (int i = 6; i < 24; i++)
            {
                linked.Add(i);
            }

            Console.WriteLine("Display");
            linked.Display();
            Console.WriteLine($"Number of Elements {linked.Count()}");
            Console.WriteLine($"Number of Elements {linked.CurrentCount}");
            linked.MaintainIntegrity();
            Console.WriteLine($"Number of Elements {linked.CurrentCount}");

            Console.WriteLine(linked[5]);
        }

    } // class

} // namespace
