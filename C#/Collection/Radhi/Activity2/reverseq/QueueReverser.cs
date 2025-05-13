using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseq
{
    internal class QueueReverser
    {
        public static Queue<int> ReverseSimple(Queue<int> queue)
        {
            var list = new List<int>(queue); // Copy elements
            queue.Clear(); // Clear original queue

            // Add elements back in reverse order
            for (int i = list.Count - 1; i >= 0; i--)
            {
                queue.Enqueue(list[i]);
            }

            return queue;
        }
    }
}
