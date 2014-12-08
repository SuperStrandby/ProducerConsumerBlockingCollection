using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producer_consumer
{
    public class Middleman
    {
        private BlockingCollection<int> _ingoingBuffer;
        private BlockingCollection<int> _outgoingBuffer;

        public Middleman(BlockingCollection<int> ingoingBuffer, BlockingCollection<int> outgoingBuffer)
        {
            _ingoingBuffer = ingoingBuffer;
            _outgoingBuffer = outgoingBuffer;
        }

        public void Run()
        {
            while (true)
            {
                int element = _ingoingBuffer.Take();
                _outgoingBuffer.Add(element);
                Console.WriteLine("Middleman handled: {0}", element);
                
            }

        }

    }
}
