using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello!! Welcome to Binary Search Tree");
            BST<int> bst = new BST<int>();


            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);

            bst.DisplayBST(bst.root);

            //UC2
            int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Insert(arr[i]);
            }
            bst.DisplayBST(bst.root);
            Console.WriteLine("\n\nSize of BST: " + bst.Size(bst.root));



        }

    }

}
