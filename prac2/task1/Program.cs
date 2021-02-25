using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList TestList = new MyList();

            TestList.AddNode(5);

            TestList.AddNode(46);

            TestList.AddNodeAfter(TestList.StartNode, 101);


        }
    }
}
