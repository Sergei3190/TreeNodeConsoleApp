using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            #region
            //Subdivision s = new Subdivision("Подразделение", "1", // 0 уровень
            //                    new Subdivision("Подразделение", "1.1", // 1 уровень
            //                        new Subdivision("Подразделение", "1.1.1"))); // 2 уровень
            //                            ...      
            #endregion;

            Subdivision subdivision = SubdivisionsInitialization.FillSubdivisions();

            TreeNode treeNode = SubdivisionsTree.FillTreeNode(subdivision);

            SubdivisionsTree.PrintTreeNodeLevel(treeNode);

            Console.ReadLine();
        }       
    }
}
