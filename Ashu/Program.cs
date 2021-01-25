using System;

namespace Ashu
{
    class Program
    {
        Node Head = null;
        int NodeCount = 0;
        class Node {

            public int data;
            public Node next = null;

            public Node(int val) 
            {
                data = val;
                next = null;
            }

        }

        void InsertAtLast(int val) 
        {
            Node node = new Node(val);
            Node node2 = null;
            NodeCount = 0;
            if (Head == null)
            {
                Head = node;
            }
            else 
            {
                node2 = Head;
                while (node2.next != null)
                {
                    node2 = node2.next;
                }
                node2.next = node;   
            }
            NodesCount();
        }

        void Display() 
        {
            Node node1 = Head;
            NodeCount = 0;
            if (node1 != null)
            {
                while (node1.next != null)
                {
                    Console.Write(" --> [ " + node1.data + " ] [Next] ");
                    node1 = node1.next;
                }
                Console.Write(" -->  [ " + node1.data + " ] [Null] ");
                NodesCount();
            }
            else 
            {
                Console.WriteLine("Ooops Node is Empty");
                NodesCount();
            }
        }

        void InsertAtFirst(int val) 
        {
            Node node = new Node(val);
            Node node2 = null;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node2 = node;
                node2.next = Head;
                Head = node2;
            }
            NodesCount();
        }

        void UpdateValue(int val,int change) 
        {
            Node node = Head;
            if (node != null)
            {
                while (node.data != val && node.next != null)
                {
                    node = node.next;
                }
                node.data = change;
            }
        }

        void InsertAtPerticularPlace(int Position,int val) 
        {
            NodesCount();
            int temp = 1;
            if (Position > 0 && Position < NodeCount) 
            {
                if (Position == 1)
                {
                    InsertAtFirst(val);
                }
                else
                {
                    Node node = new Node(val);
                    Node node2 = null, node1 = null;
                    node2 = Head;
                    node1 = Head;
                    while (temp != Position)
                    {
                        temp++;
                        node2 = node2.next;
                    }
                    node1 = node2.next;
                    node2.next = node;
                    node.next = node1;
                }
            }
            NodesCount();
        }

        void NodesCount() 
        {
            Node node1 = Head;
            NodeCount = 0;
            while (node1 != null && node1.next != null)
            {
                node1 = node1.next;
                NodeCount++;
            }
            Console.WriteLine("Total Node is " + NodeCount);
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            while (1 != 0)
            {
                Console.WriteLine("Enter your Choice :");
                Console.WriteLine("1 Insert :");
                Console.WriteLine("2 Insert at First :");
                Console.WriteLine("3 Insert at PerticularNode :");
                Console.WriteLine("4 Update :");
                Console.WriteLine("5 Display Node :");
                Console.WriteLine("6 Display Node Count :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        {
                            Console.WriteLine("Enter your Value:");
                            int val = Convert.ToInt32(Console.ReadLine());
                            prg.InsertAtLast(val);
                            break;
                        }
                    case 2: 
                        {
                            Console.WriteLine("Enter your Value:");
                            int val = Convert.ToInt32(Console.ReadLine());
                            prg.InsertAtFirst(val);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter your Value:");
                            int val = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your Position where you want to insert:");
                            int Position = Convert.ToInt32(Console.ReadLine());
                            prg.InsertAtPerticularPlace(Position,val);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter your Value you want to change:");
                            int val = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your Value you want to Insert:");
                            int Change = Convert.ToInt32(Console.ReadLine());
                            prg.UpdateValue(val, Change);
                            break;
                        }
                    case 5:
                        {
                            prg.Display();
                            break;
                        }
                    case 6:
                        {
                            prg.NodesCount();
                            break;
                        }
                }
            }

        }
    }
}
