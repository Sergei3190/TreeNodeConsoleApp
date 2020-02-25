using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNodeConsoleApp
{
    class SubdivisionsTree
    {
        public static TreeNode FillTreeNode(Subdivision s)
        {
            TreeNode parent = new TreeNode($"{s.Name} {s.Number}");

            for (int i = 0; i < s.ChildSubdiv.Count; i++)
            {
                if (s.ChildSubdiv[i].ChildSubdiv.Count == 0)
                {
                    parent.Nodes.Add(new TreeNode($"{s.ChildSubdiv[i].Name} {s.ChildSubdiv[i].Number}"));
                }
                else
                {
                    parent.Nodes.Add(new TreeNode($"{s.ChildSubdiv[i].Name} {s.ChildSubdiv[i].Number}", AddNodes(s.ChildSubdiv[i].ChildSubdiv)));
                }
            }
            return parent;
        }

        private static TreeNode[] AddNodes(List<Subdivision> childSubdiv)
        {
            var child = new List<TreeNode>();

            foreach (var item in childSubdiv)
            {
                if (item.ChildSubdiv.Count > 0)
                {
                    child.Add(new TreeNode($"{item.Name} {item.Number}", AddNodes(item.ChildSubdiv)));
                }
                else
                {
                    child.Add(new TreeNode($"{item.Name} {item.Number}"));
                }
            }

            return child.ToArray();
        }

        public static void PrintTreeNodeLevel(TreeNode treeNode)
        {
            Console.WriteLine($"{treeNode.Text} ({treeNode.Level})");

            foreach (TreeNode item in treeNode.Nodes)
            {
                Console.WriteLine($"{item.Text} ({item.Level})");
                if (item.FirstNode != null)
                {
                    PrintChildNodeLevel(item.FirstNode);
                }
            }
        }

        private static void PrintChildNodeLevel(TreeNode firstNode)
        {
            Console.WriteLine($"{firstNode.Text} ({firstNode.Level})");

            if (firstNode.Nodes.Count > 0)
            {
                PrintChildNodeLevel(firstNode.FirstNode);
            }
            if (firstNode.NextNode != null)
            {
                PrintChildNodeLevel(firstNode.NextNode);
            }
        }
    }
}
