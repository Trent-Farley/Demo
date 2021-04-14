using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh.Sort
{
    internal class InsertionSort
    {
        private List<Node> _nodes { get; set; }

        public InsertionSort(List<Node> nodes)
        {
            _nodes = nodes;
        }

        public void Sort()
        {
            var lengthOfList = _nodes.Count;

            for (var i = 1; i < lengthOfList; ++i)
            {
                var key = _nodes[i];
                var j = i - 1;

                while (j >= 0 && _nodes[j].Value > key.Value)
                {
                    _nodes[j + 1] = _nodes[j];
                    j--;
                }
                _nodes[j + 1] = key;
            }
            PrintList(_nodes);
        }

        public static void PrintList(List<Node> nodes)
        {
            Console.Write("\n[");
            foreach (var node in nodes)
            {
                Console.Write(" " + node.Value);
            }
            Console.Write("]\n");
        }
    }
}