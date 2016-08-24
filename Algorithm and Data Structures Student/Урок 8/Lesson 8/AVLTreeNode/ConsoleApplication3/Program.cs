using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeNode
{
    class Program
    {
        static void Main(string[] args)
        {

            AVLTree<int> Oak = new AVLTree<int>();
                          //                             10                              10                                             
            Oak.Add(10);  //                            /   \                           /   \
            Oak.Add(3);   //                           /     \                         /     \
            Oak.Add(2);   //                          3      12      ====>            3       15
            Oak.Add(4);   //                         / \     / \                     / \      / \
            Oak.Add(12);  //                        2   4  null 15                  2   4    12  25
            Oak.Add(15);  //                                      \              
            Oak.Add(11);  //                                       25
            Oak.Add(25);  //

            Oak.Remove(11);

            foreach (var item in Oak)
            {
                Console.WriteLine(item);
            }

            int rex = Math.Max(100, 200)*2;

            Console.WriteLine(rex);


        }
    }
}
