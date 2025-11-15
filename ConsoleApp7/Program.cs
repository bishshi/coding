
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("卷标{0}", d.VolumeLabel);
                    Console.WriteLine("文件系统{0}", d.DriveFormat);
                    Console.WriteLine("可用空间{0,15}bytes", d.AvailableFreeSpace);
                    Console.WriteLine("总可用空间{0,15}bytes", d.TotalFreeSpace);
                    Console.WriteLine("磁盘总大小{0,15}bytes", d.TotalSize);
                }

            }

        }
    }
}
