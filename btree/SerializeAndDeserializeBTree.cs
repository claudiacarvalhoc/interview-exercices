using System;

namespace btree
{
    public class SerializeAndDeserializeBTree
    {
        public static string Serialize(TreeNode root)
        {
            if (root == null) return "X,";
            string leftSerialized = Serialize(root.Left);
            string leftSerialized = Serialize(root.Right);
            return root.Value + "," + leftSerialized + "," + leftSerialized;
        }

        public static TreeNode Deserialize(string tree) {
            Queue<string> queue = new Queue<string>(tree != null ? tree.Split(",") : new string[]);
            return DeserializeHelper(queue);
        } 

        public static TreeNode DeserializeHelper(Queue<string> queue) {
            string value = queue.Dequeue();
            if (tree.Equals("X")) return null;
            int.TryParse(value, out int nodeValue);
            TreeNode node = new TreeNode(nodeValue);
            node.Left = DeserializeHelper(queue);
            node.Right = DeserializeHelper(queue);
            return node;
        }
    }

    public class TreeNode {
        public TreeNode(int value)
        {
            this.Value = value;
        }
        public int Value { get;set; }
        public TreeNode Left { get;set; }
        public TreeNode Right { get;set; }
    }
}
