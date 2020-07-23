using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

public class Utils
{
    public static TreeNode CreateTree(string data)
    {
        if (string.IsNullOrEmpty(data))
            return null;

        if (!data[0].Equals('[') || !data[data.Length - 1].Equals(']'))
            return null;

        if (data.Equals("[]"))
            return null;

        data = data.Substring(1, data.Length - 2);

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

    public static ListNode CreateList(string data)
    {

        var head = new ListNode(0);
        return head;
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

    public static void PrintPathFileCount(string path, string pattern)
    {
        var files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
        var log = files.Length.ToString();
        foreach (var f in files)
        {
            log += f + "\n";
        }
        System.IO.File.WriteAllText(path + "/log.txt", log);
    }
}