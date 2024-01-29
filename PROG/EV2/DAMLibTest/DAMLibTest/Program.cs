using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node<string> node1 = new Node<string>();
            node1.item = "Este es el nodo 1";

            Node<string> node2 = new Node<string>();
            node2.item = "este es el primer hijo";

            node1.AddChildren(node2);

            Node<string> node3 = new Node<string>();
            node3.item = "Este es el ultimo nodo";

            Node<string> node4 = new Node<string>();
            node4.item = "Este es el acompañante del node3";


            node2.AddChildren(node3);
            node2.AddChildren(node4);
            Node<string> node44 = node1.Root;
            Node<string> node5 = node2.Root;
            Node<string> nod6e = node3.Root;
        }
    }
}