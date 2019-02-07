using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(50);
            list.AddLast(50);
            list.AddLast(50);
            list.AddLast(50);
            list.AddLast(50);
            list.AddLast(50);
            list.AddLast(50);

            list.Remove(50);
            list.RemoveFirst();

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            Number n1 = new Number();
            n1.value = 5;
            n1.nextNumber = new Number();
            n1.nextNumber.value = 10;
            n1.nextNumber.nextNumber = new Number();
        }
    }

    class Number
    {
        public int value;
        public Number nextNumber;
    }
}
