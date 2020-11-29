using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hash table demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string checkFreq = "be";
            int freq = hash.GetFrequency(checkFreq);
            Console.ReadKey();





            Console.WriteLine("Hash table demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paraWords = para.Split(' ');
            int pLength = paraWords.Length;
            for (int i = 0; i < pLength; i++)
            {
                hash.Add(Convert.ToString(i), paraWords[i]);
            }
            foreach (string word in paraWords)
            {
                hash.GetFrequency(word);
            }
            Console.ReadKey();




            Console.WriteLine("Hash table demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paraWords = para.Split(' ');
            int pLength = paraWords.Length;
            for (int i = 0; i < pLength; i++)
            {
                hash.Add(Convert.ToString(i), paraWords[i]);
            }

            Console.WriteLine("Frequency of 'avoidable' before removal is :" + hash.GetFrequency("avoidable"));
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency of 'avoidable' after removal is :" + hash.GetFrequency("avoidable"));
            Console.ReadKey();


            Console.WriteLine("Hello!! Welcome to Binary Search Tree");
            BST<int> bst = new BST<int>();


            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);

            bst.DisplayBST(bst.root);


            int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Insert(arr[i]);
            }
            bst.DisplayBST(bst.root);
            Console.WriteLine("\n\nSize of BST: " + bst.Size(bst.root));



            bst.Search(60);
            bst.Search(20);




        }

    }

}
