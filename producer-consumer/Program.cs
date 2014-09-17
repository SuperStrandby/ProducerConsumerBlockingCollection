using System;
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
            BoundedBuffer buff = new BoundedBuffer(4);

            Producer prod = new Producer(buf, 15);

            Consumer con = new Consumer(buf);

            Parallel.Invoke(prod.Run(), con.Run());
        }
    }
}
