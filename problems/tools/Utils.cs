using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

public class Utils
{
    public static TreeNode CreateTree(string data)
    {
        if (string.IsNullOrEmpty(data)) return null;
        var info = data.Split(',');
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
            if (list[i] == null) continue;

            var left = 2 * i + 1;
            var right = left + 1;

            if (left >= count) break;
            list[i].left = list[left];
            if (right >= count) break;
            list[i].right = list[right];
        }

        return list[0];
    }

    public static void Test()
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        var path = @"D:\P4Workspace\VP\trunk\build\build-android-exe-full-output\unity_log.txt";
        var bytes = File.ReadAllBytes(path);
        var datas = md5.ComputeHash(bytes);

        var len = datas.Length;
        for (int i = 0; i < len; i++)
        {
            System.Console.WriteLine(datas[i].ToString("x2"));
        }
    }
}