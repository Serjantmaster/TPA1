using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class PriorityQueueItem<T> 
    {
        public int Priority;
        public T Item;
        

    }
    public class PriorityQueue<T> : PriorityQueueItem<T> 
    {
        public List<PriorityQueueItem<T>> Queue = new List<PriorityQueueItem<T>>();
        public void Enqueue(T item, int priority) 
        {
            PriorityQueueItem<T> thing = new PriorityQueueItem<T> { Priority = priority, Item = item };
            Queue.Add(thing);
        }
        public void Dequeue()
        {
            int value = Queue[0].Priority;
            int itemIndex = 0;
            int index = 0;
            foreach (var thing in Queue)
            {
                if(thing.Priority > value)
                {
                    value = thing.Priority;
                    itemIndex = index;
                }
                index++;
            }
            Queue.RemoveAt(itemIndex);
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
        public void IsEmpty()
        {
            if (!Queue.Any()) Console.WriteLine("Coada este goala");
            else Console.WriteLine("Coada nu este goala");
        }
    }
}
