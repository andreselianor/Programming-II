using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Node<string> node1 = new Node<string>(null, "root");
            Node<string> node2 = new Node<string>(node1,"A");
            Node<string> node3 = new Node<string>(node2, "B");
            Node<string> node4 = new Node<string>(node3, "C");
            Node<string> node5 = new Node<string>(node4, "D");

            
            Node<string> nodetest = new Node<string>();
            /*
            bool result1 = node1.IsRoot;
            bool result2 = node2.IsRoot;
            bool result3 = node2.IsLeaf;
            bool result4 = node5.IsLeaf;
            

            nodetest = node1.GetRoot();
            nodetest = node3.GetRoot();
            nodetest = node5.GetRoot();
            nodetest = node5.Parent;

            int result5 = node1.GetLevel();
            int result6 = node5.GetLevel();
            

            nodetest = node2.Parent;
            int number1 = node1.ChildCount;
            node1.AddChildren(node5);
            node1.AddChildren(node2);
            node2.AddChildren(node3);
            node3.AddChildren(node4);

            int result1 = node1.IndexOf(node5);
            int result2 = node1.IndexOf(node2);
            int result3 = node1.IndexOf(node3);

            node1.RemoveChildAt(result1);
            int number2 = node1.ChildCount;
            node1.RemoveChildAt(0);
            int number3 = node1.ChildCount;

            */

            DAMLib.Queue<int> queue = new DAMLib.Queue<int>();
            queue.Enqueue(1);
            queue.QueueMultipleElements(new int[5] { 5, 10, 15, 20, 25 });

            DAMLib.Queue<int> second = queue.Clone();
        }
    }
}