using System;

namespace Program0603_2
{

        public class Node//creat node class
        {
            public int value;
            public Node left;//left child node
            public Node right;//right child node
            public void show()
            {
                Console.Write("{0} ",value);
            }

        }
        public class BST
        {
            public Node rootNode = null;//define rootnode 
            
            public void Insert(int value)//create a binary tree
                {
                    Node Parent;
                    Node newNode = new Node();
                    newNode.value = value;

                    if (rootNode == null)//firstly, give the value to rootnode if the rootnode is null
                    {
                        rootNode = newNode;
                    }
 /*___________________________________________________________________________________________________*/                   
                    else
                    {
                        Node updatenode= rootNode;//when insert a newnode, begin with compare to the rootnode 
                        while (true)
                        {
                            Parent = updatenode;
                            if (newNode.value < updatenode.value)
                            {
                                updatenode = updatenode.left;/*when the value of new node is lower than the parent node, 
                                                              * let the left node become the parent node*/
                                if (updatenode == null)
                                {
                                    Parent.left = newNode;
                                    break;
                                }
                            }
                            else
                            {
                                updatenode = updatenode.right;
                                if (updatenode == null)
                                {
                                    Parent.right = newNode;
                                    break;
                                }
                            }
                        }
                    }
 /*___________________________________________________________________________________________________*/           
        }
        public void PreOrder(Node theRoot)//root->left->right
        {
            if (theRoot != null)
            {
                theRoot.show();//print the noderoot first
                PreOrder(theRoot.left);
                PreOrder(theRoot.right);/*Recursive calls*/
            }
        }
        public void InOrder(Node theRoot)//left->root->right
        {
            if (theRoot != null)
            {
                InOrder(theRoot.left);
                theRoot.show();
                InOrder(theRoot.right);
            }
        }
        public void PostOrder(Node theRoot)//left->right->root
        {
            if (theRoot != null)
            {
                PostOrder(theRoot.left);
                PostOrder(theRoot.right);
                theRoot.show();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tree");
            BST nodetree = new BST();
            nodetree.Insert(10);//create a BinarySearchTree
            nodetree.Insert(5);
            nodetree.Insert(15);
            nodetree.Insert(6);
            nodetree.Insert(4);
            nodetree.Insert(20);                   
                    /* The Binaryserachtree will look like this:
                     *            (10)
                     *           /    \
                     *         (5)    (15) 
                     *         / \      \
                     *       (4) (6)     (20) 
                     */
             Console.Write("Preorder:\n");
             nodetree.PreOrder(nodetree.rootNode);
             Console.Write("\nInorder:\n");
             nodetree.InOrder(nodetree.rootNode);
             Console.Write("\nPostorder:\n");
             nodetree.PostOrder(nodetree.rootNode);

        }           
         }

}



