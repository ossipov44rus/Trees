using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Tree

    {
        public string Name { get; set; }
        public IEnumerable<Tree> Children { get; set; }
        public void WriteAllNamesInATree()
        {
            Queue<Tree> myQueue = new Queue<Tree>();
            myQueue.Enqueue(this);
            while (myQueue.Count != 0)
            {
                var currentTree = myQueue.Peek();
                Console.WriteLine(currentTree.Name);
                if (currentTree.Children == null)
                {
                    myQueue.Dequeue();
                }
                else
                {
                    foreach (var j in currentTree.Children)
                    {
                        myQueue.Enqueue(j);
                    }
                    myQueue.Dequeue();
                }
            }
        }

    }
}
