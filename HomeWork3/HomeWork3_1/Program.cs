using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<int> l1 = new List<int>();
            //l1.Add(1);
            //l1.Add(2);
            //l1.Add(3);
            //l1.Add(4);
            //l1.Add(5);
            //l1.Add(6);
            //l1.Add(7);
            //l1.ForEach(print);

            GenericList<int> l1 = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                l1.Add(i + 10);
            }
            l1.ForEach(Console.WriteLine);
            l1.ForEach(print);

            System.Console.Read();
        }

        private static void print(int obj)
        {
            System.Console.WriteLine(obj);
        }
    }
    
    public class Node<T>
    {
        public Node<T> Next
        {
            get;set;
        }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node<T> n1 = head;
                while (n1.Next != null)
                {
                    action(n1.Data);
                    n1 = n1.Next;
                }
            }
        }


    }




}
