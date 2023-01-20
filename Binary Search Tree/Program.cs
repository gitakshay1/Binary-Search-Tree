namespace Binary_Search_Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree=new Tree();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(22);
            tree.Insert(40);
            tree.Insert(11);
            tree.Insert(63);
            tree.Insert(67);
            tree.Insert(16);
            tree.Insert(60);
            tree.Insert(95);
            tree.Insert(65);
            tree.Insert(3);
            Console.WriteLine(tree.GetSize());

        }
    }
}
