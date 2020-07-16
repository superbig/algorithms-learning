/*
102. 二叉树的层序遍历
给你一个二叉树，请你返回其按 层序遍历 得到的节点值。 （即逐层地，从左到右访问所有节点）。

示例：
二叉树：[3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
返回其层次遍历结果：

[
  [3],
  [9,20],
  [15,7]
]
*/
using System.Collections.Generic;
public class Tree102
{
    public void Execute()
    {
        var tree = "3,9,20,null,null,15,7";
        var root = Utils.CreateTree(tree);
        var result = LevelOrder(root);
        Log(result);
    }

    private IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var len = queue.Count;
            var list = new int[len];
            for (int i = 0; i < len; i++)
            {
                root = queue.Dequeue();
                list[i] = root.val;
                if (root.left != null)
                    queue.Enqueue(root.left);
                if (root.right != null)
                    queue.Enqueue(root.right);
            }
            result.Add(list);
        }

        return result;
    }

    public List<IList<int>> Best(TreeNode root)
    {
        var res = new List<IList<int>>();

        DFS(root, 0);

        void DFS(TreeNode node, int level)
        {
            if (node == null) return;
            if (res.Count == level)
            {
                var lst = new List<int>();
                res.Add(lst);
            }

            res[level].Add(node.val);
            DFS(node.left, level + 1);
            DFS(node.right, level + 1);
        }

        return res;
    }

    private void Log(IList<IList<int>> treeLayers)
    {
        var log = "";
        if (treeLayers == null || treeLayers.Count <= 0)
        {
            log = "empty!";
        }
        else
        {
            for (int i = 0; i < treeLayers.Count; i++)
            {
                log += string.Join(',', treeLayers[i]) + "\n";
            }
        }
        System.Console.WriteLine(log);
    }
}