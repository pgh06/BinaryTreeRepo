using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        public class BinaryTree
        {
            public Node Root { get; set; }

            public BinaryTree()
            {
                Root = null;
            }

            public string Find(int key)
            {
                Node node = Find(Root, key);

                return node == null ? null : node.Value;
            }

            private Node Find(Node node, int key)
            {
                if (node == null || node.Key == key)
                {
                    return node;
                }
                else if (key < node.Key)
                {
                    return Find(node.Left, key);
                }
                else if (key > node.Key)
                {
                    return Find(node.Right, key);
                }

                return null;
            }

            public void Insert(int key, string value)
            {
                Root = InsertItem(Root, key, value);
            }

            private Node InsertItem(Node node, int key, string value)
            {
                Node newNode = new Node(key, value);

                if (node == null)
                {
                    node = newNode;
                    return node;
                }

                if (key < node.Key)
                {
                    node.Left = InsertItem(node.Left, key, value);
                }
                else if (key > node.Key)
                {
                    node.Right = InsertItem(node.Right, key, value);
                }

                return node;
            }

            public class Node
            {
                public int Key { get; set; }
                public string Value { get; set; }
                public Node Left { get; set; }
                public Node Right { get; set; }

                public Node(int key, string value)
                {
                    Key = key;
                    Value = value;
                }

                public Node Min()
                {
                    if (Left == null)
                    {
                        return this;
                    }
                    else
                    {
                        return Left.Min();
                    }
                }
            }
        }
        

        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree();
            binaryTree.Insert(1, "a");
            binaryTree.Insert(2, "sadf");
            binaryTree.Insert(3, "ddddddd");
            binaryTree.Insert(3, "dsafsfsdsdsfs");
            binaryTree.Insert(0, "test");
            binaryTree.Insert(12, "2222222222");
            binaryTree.Insert(10, "sadfads43435324");

            var find = binaryTree.Find(0);
            var minimum = binaryTree.Root.Min();
        }
    }
}
