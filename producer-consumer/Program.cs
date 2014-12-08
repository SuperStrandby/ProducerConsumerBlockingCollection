using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producer_consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> _buffer = new BlockingCollection<int>(40);
            BlockingCollection<int> _buffer2 = new BlockingCollection<int>(40);

            Producer prod = new Producer(_buffer, 40);

            Consumer con = new Consumer(_buffer2);
            Middleman mid = new Middleman(_buffer, _buffer2);

            Parallel.Invoke(prod.Run, con.Run, mid.Run);
            
        }
    }
}
