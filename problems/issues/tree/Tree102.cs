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
        var tree = "[3,9,20,null,null,15,7]";
        var root = Utils.CreateTree(tree);
        var result = LevelOrder(root);
    }

    private IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        var layer = new List<TreeNode> { root };
        return result;
    }
}