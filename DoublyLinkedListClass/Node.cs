﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
    
        }
        public Node(int val)
        {
            Data = val;
        }
    }
}
