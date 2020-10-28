using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CodeLearn
{
    internal class Node
    {
        public Node pNext;
        public int info;
    }

    internal class List
    {
        public Node Head, Tail;

        public List()
        {
            Head = Tail = null;
        }

        public Node getNode(int x)
        {
            Node p = new Node();
            p.info = x;
            p.pNext = null;
            return p;
        }

        public void addNode(int x)
        {
            Node p = getNode(x);
            if (Head == null)
                Head = Tail = p;
            else
            {
                if (x < 0)
                {
                    p.pNext = Head;
                    Head = p;
                }
                else
                {
                    Tail.pNext = p;
                    Tail = p;
                }
            }
        }

        public int demBoi(int M)
        {
            Node p = Head;
            int count = 0;
            while (p != null)
            {
                if (p.info % M == 0) ++count;
                p = p.pNext;
            }
            return count;
        }
    }
}