using System;

namespace com.lzx.leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var example = new Tree102();
            // example.Execute();

            var path = @"D:\perforce\VP\trunk\client\Assets\Wwise";
            var pattern = "*.*";

            Utils.PrintPathFileCount(path, pattern);
        }
    }
}
