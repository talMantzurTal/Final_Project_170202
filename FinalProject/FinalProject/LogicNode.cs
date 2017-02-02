using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;

namespace FinalProject
{
    class LogicNode : Node
    {


        public LogicNode() : base()
        {
            Console.WriteLine("LogicNode defult c'tor");
            m_children = new LogicNode[m_number_of_children];
            for (int i = 0; i < m_number_of_children; i++)
            {
                m_children[i] = null;
            }
        }
        public LogicNode(string name, string type, int depth, int number_of_children, LogicNode parent) :
            base(name, type, depth, number_of_children, parent)
        {
            Console.WriteLine("LogicNode c'tor");
            m_children = new LogicNode[m_number_of_children];
            for (int i = 0; i < m_number_of_children; i++)
            {
                m_children[i] = null;
            }
        }

        public LogicNode get_child(string child_name)
        {
            for (int i = 0; i<m_number_of_children; i++)
                if ((m_children[i] != null) && (m_children[i].get_node_name() == child_name)) return (LogicNode)m_children[i];
            return null;
        }



        // Indexers
        /* public LogicNode this [int idx]
         {
             get
             {
                 return; 
              }
         }*/





    }
}
