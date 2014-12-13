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
        private BlockingCollection<int> _buffer;

        public Consumer(BlockingCollection<int> buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException("buffer");
            }
            _buffer = buffer;
        }

        public void Run()
        {
            while (!_buffer.IsCompleted)
            {
                
                try
                {
                    int i = _buffer.Take();
                    Console.WriteLine("Take:{0} ", i);
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Adding was complete");
                    break;

                }
                
            }
            Console.WriteLine("\r\nNo more items to take. Press the Enter key to exit.");
        }
    }
}
