#define XCV
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Parsing to text file
//#define FILE_PATH @"C:\Users\mantz\Documents\GitHub\Final_Project\tree_input.txt"


namespace FinalProject
{

    class TreeUtils
    {
        #if XCV
            const string FILE_NAME = @"C:\Users\mantz\Documents\GitHub\Final_Project\Final_Project\tree_input.txt";
#endif

        public static void read_tree_from_file()
        {
            FileStream fs;
            string line;
            int depth_counter = 0;
            bool flag_found_char = false;

            // Read the text file
            if (File.Exists(FILE_NAME)) {
                fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                int i_alphabeth_size = (reader.Read())-48; // Read single char in the file
                // Create a new n-ary tree
                reader.ReadLine(); // Ignore the rest of the first line
                line = reader.ReadLine();
                string s_node_name = line[0].ToString();
                string s_node_type = line[1].ToString();
                Console.WriteLine("tree c'tor({0},{1},{2})", i_alphabeth_size, s_node_name ,s_node_type);

                // Initialize the root of the formula tree
                Node tmp_node = new LogicNode(s_node_name,s_node_type,0,i_alphabeth_size,null);
                FormulaTree formula_tree = new FormulaTree(i_alphabeth_size, (LogicNode)tmp_node);
                LogicNode logic_tmp_node = new LogicNode();
                LogicNode logic_parent_node = new LogicNode();
                while ((line = reader.ReadLine()) != null)
                {
                    logic_tmp_node = (LogicNode)formula_tree.get_root();
                    
                    // Start adding a child only if it's not the root
                    for (int i = 2; i < line.Length; i = i + 2)
                    {
                        s_node_name = line[i].ToString();
                        s_node_type = line[i+1].ToString();
                        logic_parent_node = logic_tmp_node;
                        logic_tmp_node = (LogicNode)logic_tmp_node.get_child(s_node_name.ToString());
                        if (logic_tmp_node == null)
                            formula_tree.add_child(s_node_name, s_node_type, logic_parent_node);
                        Console.WriteLine("Node.create+add(name={0},type={1})", line[i], line[i + 1]);
                    }
                }
                fs.Close();
            } // If file exists
            
            return;
        } // End of function "read_tree_from_file"
    }
}
