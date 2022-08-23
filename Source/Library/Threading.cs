using System.Threading;

namespace Library
{
    public class Threading
    {
        public void GenerateThread(int threadID)
        {
            switch (threadID)
            {
                case 0:
                    Thread NetworkingThread = new Thread(new ThreadStart(Library.utils.FetchIndexesForDownload));
                    NetworkingThread.IsBackground = true;
                    NetworkingThread.Name = "Conversion Thread";
                    NetworkingThread.Start();
                    break;
            }
        }
    }
}
