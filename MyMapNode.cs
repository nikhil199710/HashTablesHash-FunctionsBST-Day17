using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class MyMapNode<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach(KeyValue<K,V> item in linkedList)
            {
                if(item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>(){ Key = key, Value = value};
            linkedList.AddLast(item);
        }

        /// <summary>
        /// UC1-UC2
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetFrequency(V value)
        {
            int frequency = 0;
            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                {
                    continue;
                }
                foreach (KeyValue<K, V> keyvalue in list)
                {
                    if (keyvalue.Equals(null))
                    {
                        continue;
                    }
                    if (keyvalue.Value.Equals(value))
                    {
                        frequency++;
                    }
                }
            }
            Console.WriteLine("Word '{0}' appears {1} times", value, frequency);
            return frequency;
        }


        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="value"></param>
        public void RemoveValue(V value)
        {
            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                    continue;
                foreach (KeyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                    {
                        continue;
                    }
                    if (obj.Value.Equals(value))
                    {
                        Remove(obj.Key);
                        break;
                    }
                }
            }
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach(KeyValue<K,V> item in linkedList)
            {
                if(item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if(itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        public LinkedList<KeyValue<K,V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if(linkedList==null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " :" + element.Value);
                    }
                }

            }
        }

    }
    public struct KeyValue<k,v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }





    //Binary Search Tree Implemented
    
    class Node<T> where T : IComparable
    {
        public T data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }

    }
    class BST<T> where T : IComparable
    {
        public Node<T> root;
        public BST()
        {
            this.root = null;
        }
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }

                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void DisplayBST(Node<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
            {
                Console.WriteLine("Right :" + parent.Right.data);
            }

            if (parent.Left != null)
            {
                DisplayBST(parent.Left);
            }
            if (parent.Right != null)
            {
                DisplayBST(parent.Right);
            }
        }

        public int Size(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }



        public void Search(T element)
        {
            Node<T> current = root;
            bool found = false;
            while (current != null)
            {
                if (current.data.Equals(element))
                {
                    found = true;
                    break;
                }
                else
                {
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (found)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element Not Found");
        }


    }

}
