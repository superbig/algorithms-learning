using System;

namespace com.lzx.leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var example = new Tree102();
            // example.Execute();

            var path = @"D:\P4Workspace\VP\trunk\client\Assets\Framework";
            var pattern = "*.cs";

            Utils.PrintPathFileCount(path, pattern);
        }
    }
}
