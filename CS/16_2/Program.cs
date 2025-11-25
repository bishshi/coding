using System;
using System.IO;

namespace _16_2
{
    class CopyDir
    {
        static public void CopyDirectory(string srcDir, string dstDir)
        {
            DirectoryInfo src = new DirectoryInfo(srcDir);
            DirectoryInfo dst = new DirectoryInfo(dstDir);
            if (!src.Exists) return;
            if (!dst.Exists) dst.Create();
            FileInfo[] sfs = src.GetFiles();
            for (int i = 0; i < sfs.Length; i++) File.Copy(sfs[i].FullName, sfs[i].FullName + "\\" + sfs[i].Name, true);
            DirectoryInfo[] srcDirs = src.GetDirectories();
            for (int j = 0; j < srcDirs.Length; j++)
                CopyDirectory(srcDirs[j].FullName, dst.FullName + "\\" + srcDirs[j].Name);
        }
        static void Main(string[] args)
        {
            try
            {
                string src = args[0];
                string dst = args[1];
                CopyDirectory(src, dst);
                Console.WriteLine("\n 源目录{0}的内容已复制到目标目录{1}中", src, dst);
            }
            catch (Exception e) { Console.WriteLine("\n 操作失败 {0}", e.ToString()); }
            finally { }
        }
    }
}