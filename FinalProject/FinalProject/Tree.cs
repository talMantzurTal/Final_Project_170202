using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;

namespace FinalProject
{
    class Tree
    {
        protected int m_depth;
        protected int m_num_of_children;
        protected Node m_root;

        public Tree(int num_of_children, Node root_node)
        {
            Console.WriteLine("Tree c'tor");
            m_root = root_node;
            m_depth = 0;
            m_num_of_children = num_of_children;
        }

        public Node get_root()
        {
            return m_root;
        }

        

        // public abstract Node get_root();
    }
}
