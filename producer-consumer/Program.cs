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
            BlockingCollection<int> _buffer = new BlockingCollection<int>(100);

            Producer prod = new Producer(_buffer, 50);

            Consumer con = new Consumer(_buffer);

            Parallel.Invoke(prod.Run, con.Run);
            
        }
    }
}
