using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Node
    {
        protected string m_name;
        protected string m_type;
        protected int m_my_depth;
        protected int m_number_of_children;
        protected Node m_parent;
        protected Node[] m_children;

        public Node()
        {
            Console.WriteLine("Node c'tor");
            m_type = null;
            m_my_depth = 0;
            m_number_of_children = 0;
            m_parent = null;
            m_name = null;
            m_children = null;

        }

        public Node(string name,string type, int depth, int number_of_children, Node parent)
        {
            Console.WriteLine("Node c'tor");
            m_type = type;
            m_my_depth = depth;
            m_number_of_children = number_of_children;
            m_parent = parent;
            m_name = name;
            

        }



        public string get_node_name()
        {
            return m_name;
        }

        /*public Node get_child(string child_name)
        {
            foreach ( Node node in mp_children )
                if ((node != null) && (node.m_name == child_name)) return node;              
            return null;
        } */

        public void set_parent(ref Node parent)
        {

        }
        
        public void add_child(ref Node new_child)
        {

        }

        

        public bool set_child(Node child_to_add)
        {
            int i = 0;
            while (m_children[i] != null) i++;
            if (i == m_number_of_children) return false;
            else m_children[i] = child_to_add;
            return true;
        }


    }

}
