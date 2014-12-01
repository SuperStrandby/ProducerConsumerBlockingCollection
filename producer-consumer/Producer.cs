using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producer_consumer
{
    public class Producer
    {
        public int _howMany = 500;
        BlockingCollection<int> _buffer = new BlockingCollection<int>(); 
        public Producer(BlockingCollection<int> buffer, int howMany)
        {
            _buffer = buffer;
            _howMany = howMany;

        }

        public void Run()
        {
            for (int i = 0; i > _howMany; i++)
            {
                _buffer.Add(i);
                Console.WriteLine("Add:{0} Count={1}", i, _buffer.Count);
            }
            _buffer.CompleteAdding();
        }
    }
}
