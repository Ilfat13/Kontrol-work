using System;
using System.Collections.Generic;

namespace Kontrol_work_number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetofStacks tarel = new SetofStacks(20);
            Dictionary<char, int>[] array = new Dictionary<char, int>[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = new Dictionary<char, int>();
                array[i].Add('a', 1);
                array[i].Add('b', 2);
                array[i].Add('c', 3);
                array[i].Add('d', 4);
                array[i].Add('e', 5);
            }
        }
    }
    struct SetofStacks
    {
        readonly int MAX;
        public List<Stack<int>> stacks;
        public int Count { get; private set; }

        public SetofStacks(int MaxCountStack)
        {
            MAX = MaxCountStack;
            stacks = new List<Stack<int>>();
            Count = 0;
        }

        public void Push(int item)
        {
            if (stacks.Count == 0)
            {
                stacks[0] = new Stack<int>();
                stacks[0].Push(item);
                Count++;
            }

            if (Count % MAX == 0)
            {
                stacks[Count % MAX + 1] = new Stack<int>();
                stacks[Count % MAX + 1].Push(item);
                Count++;
            }
            else
            {
                stacks[Count % MAX].Push(item);
                Count++;
            }
        }

        public int Pop()
        {
            if (stacks.Count == 0)
                return 0;
            else
            {
                int a = stacks[Count % MAX].Pop();
                Count--;
                return a;
            }
        }
    }
}
