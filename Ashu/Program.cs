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

        private void Insert() 
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 Insert At Last :");
            Console.WriteLine("2 Insert at First :");
            Console.WriteLine("3 Insert at Position :");
            Console.Write("Enter your Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            switch (choice)
            {
                case 1:
                    {
                        InsertAtLast(input("Enter your Value:"));
                        break;
                    }
                case 2:
                    {
                        InsertAtFirst(input("Enter your Value:"));
                        break;
                    }
                case 3:
                    {
                        InsertAtPerticularPlace(
                                input("Enter your Position where you want to insert:"),
                                input("Enter your Value:"
                                )
                            );
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Enter Valid Input");
                        break;
                    }
            }
        }

        private void InsertAtLast(int val) 
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
            DisplayNodesCount();
        }

        private void InsertAtFirst(int val)
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
            DisplayNodesCount();
        }

        private void InsertAtPerticularPlace(int Position, int val)
        {
            DisplayNodesCount();
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
            DisplayNodesCount();
        }

        private void Display() 
        {
            Node node1 = Head;
            NodeCount = 0;
            if (node1 != null)
            {
                Console.WriteLine("--------------------------------------------------");
                while (node1.next != null)
                {
                    Console.Write(" --> [ " + node1.data + " ] [Next] ");
                    node1 = node1.next;
                }
                Console.Write(" -->  [ " + node1.data + " ] [Null]\n");
                Console.WriteLine("--------------------------------------------------");
                DisplayNodesCount();
            }
            else 
            {
                Console.WriteLine("Ooops Node is Empty");
                DisplayNodesCount();
            }
        }

        private void DisplayNodesCount()
        {
            Node node1 = Head;
            NodeCount = 0;
            while (node1 != null && node1.next != null)
            {
                node1 = node1.next;
                NodeCount++;
            }
            NodeCount++;
            Console.WriteLine("Total Node is " + NodeCount);
        }

        private void UpdateValue(int val,int change) 
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

        private void DeleteNote() 
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 Delete by value :");
            Console.WriteLine("2 Insert at First :");
            Console.Write("Enter your Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            switch (choice)
            {
                case 1: 
                    {
                        DeleteNote(input("Enter your Value:"));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter Valid Input");
                        break;
                    }
            }
        }

        private void DeleteNote(int val)
        {
            Node node = Head;
            if (node != null)
            {
                while (node.next.data != val && node.next != null)
                {
                    node = node.next;
                }
                node = node.next.next;
            }
        }

        private int input(string text) 
        {
            Console.WriteLine(text);
            int val = Convert.ToInt32(Console.ReadLine());
            return val;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            while (1 != 0)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1 Insert :");
                Console.WriteLine("2 Update :");
                Console.WriteLine("3 Delete :");
                Console.WriteLine("4 Display Node :");
                Console.WriteLine("5 Display Node Count :");
                Console.Write("Enter your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");
                switch (choice)
                {
                    case 1: 
                        {
                            prg.Insert();
                            break;
                        }
                    case 2:
                        {
                            
                            prg.UpdateValue(
                                prg.input("Enter your Value you want to change:"), 
                                prg.input("Enter your Value you want to Insert:"
                                ));
                            break;
                        }
                    case 3: 
                        {
                            prg.DeleteNote();
                            break;
                        }
                    case 4:
                        {
                            prg.Display();
                            break;
                        }
                    case 5:
                        {
                            prg.DisplayNodesCount();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter Valid Input");
                            break;
                        }
                }
            }

        }
    }
}
