﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace producer_consumer
{
    public class BoundedBuffer
    {
        private Queue queue = new Queue();

        public void Add(object obj)
        {
            Monitor.Enter(queue);

            try
        }
    }
}
