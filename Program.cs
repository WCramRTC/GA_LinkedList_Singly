namespace GA_LinkedList_Singly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList mll = new MyLinkedList();

            for (int i = 0; i < 10; i++)
            {
                mll.InsertAtEnd((i + 1).ToString());
            }

            mll.Display();
        }
    }
}
