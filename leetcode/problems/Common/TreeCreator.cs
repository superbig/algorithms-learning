using System.Collections.Generic;
public class TreeCreator
{
    public static TreeNode Create(string data)
    {
        if (string.IsNullOrEmpty(data)) return null;
        var content = data.Substring(1, data.Length - 1);
        if (string.IsNullOrEmpty(content)) return null;
        var info = content.Split(',');
        if (info.Length <= 0) return null;

        // create nodes
        var val = 0;
        var count = info.Length;
        var list = new List<TreeNode>(count);
        for (int i = 0; i < count; i++)
        {
            var node = int.TryParse(info[i], out val) ? new TreeNode(val) : null;
            list.Add(node);
        }

        //create tree
        for (int i = 0; i < count; i++)
        {
            var left = 2 * i + 1;
            var right = left + 1;

            if (left >= count) break;
            list[i].left = list[left];
            if (right >= count) break;
            list[i].right = list[right];
        }

        return list[0];
    }
}