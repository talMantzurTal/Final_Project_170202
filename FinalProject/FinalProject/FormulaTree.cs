using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;

namespace FinalProject
{
    class FormulaTree : Tree
    {
        
        private int m_num_of_variables;

        public FormulaTree(int num_of_children, LogicNode root_node) :
            base(num_of_children, (Node)root_node)
        {
            Console.WriteLine("FormulaTree c'tor");
            m_num_of_variables = 0;
            m_root = root_node;
            m_depth = 0;
            m_num_of_children = num_of_children;
        }

        public void add_child(string name, string type, LogicNode parent)
        {
            int new_depth = m_depth + 1;
            Node node_to_add = new LogicNode(name, type, new_depth, m_num_of_children, parent);
            bool result = parent.set_child((Node)node_to_add);
        }

        /*public LogicNode get_root()
        {
            return m_root;
        }*/


    }
}
