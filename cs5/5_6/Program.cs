namespace _5_6
{
    public interface ICDPlayer
    {
        void Play();
        void Stop();
        void PreviousTrack();
        void NextTrack();
        int CurrentTrack
        {
            get;
        }
    }
    public class CDPlayer : ICDPlayer
    {
        private int currentTrack = 0;
        public void Play()
        {
            Console.WriteLine("启动CD。。。");
        }
        public void Stop()
        {
            Console.WriteLine("停止播放CD。。。");
        }
        public void PreviousTrack()
        {
            if (currentTrack > 0)
            {
                currentTrack--;
            }
            Console.WriteLine("上一音轨：");
        }
        public void NextTrack()
        {
            Console.WriteLine("下一音轨：");
            currentTrack++;
        }
        public int CurrentTrack
        {
            get
            {
                return currentTrack;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            CDPlayer mycd = new CDPlayer();
            mycd.Play();
            Console.WriteLine("当前音轨：" + mycd.CurrentTrack);
            mycd.NextTrack();
            Console.WriteLine("当前音轨：" + mycd.CurrentTrack);
            mycd.PreviousTrack();
            Console.WriteLine("当前音轨：" + mycd.CurrentTrack);
            mycd.Stop();

        }
    }
}
