using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producer_consumer
{
    public class Consumer
    {
        BlockingCollection<int> _buffer = new BlockingCollection<int>();

        public Consumer(BlockingCollection<int> buffer)
        {
            _buffer = buffer;
        }

        public void Run()
        {
            while (!_buffer.IsCompleted)
            {
                int i = -1;
                try
                {
                    i = _buffer.Take();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Adding was complete");
                    break;

                }
                Console.WriteLine("Take:{0} ", i);
            }
            Console.WriteLine("\r\nNo more items to take. Press the Enter key to exit.");
        }
    }
}
