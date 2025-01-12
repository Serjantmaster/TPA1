using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii.TPA6
{
    public class GeneralItem<T>
    {
        public int Priority;
        public T Item;


    }
    public class PriorityQueue<T>
    {
        public List<GeneralItem<T>> Queue = new List<GeneralItem<T>>();
        public void Enqueue(T item, int priority)
        {
            GeneralItem<T> thing = new GeneralItem<T> { Priority = priority, Item = item };
            Queue.Add(thing);
        }
        public T Dequeue()
        {
            int value = Queue[0].Priority;
            int index = 0;
            int itemIndex = 0;
            GeneralItem<T> item;
            foreach (var thing in Queue)
            {
                if (thing.Priority > value)
                {
                    value = thing.Priority;
                    itemIndex = index;
                }
                index++;
            }
            item = Queue[itemIndex];
            Queue.RemoveAt(itemIndex);
            return item.Item;
        }
        public T Peek()
        {
            int value = Queue[0].Priority;
            int itemIndex = 0;
            int index = 0;
            foreach (var thing in Queue)
            {
                if (thing.Priority > value)
                {
                    value = thing.Priority;
                    itemIndex = index;
                }
                index++;
            }
            return Queue[itemIndex].Item;
        }
        public bool IsEmpty()
        {
            if (!Queue.Any())
                return true;
            else
                return false;
        }
    }
}
