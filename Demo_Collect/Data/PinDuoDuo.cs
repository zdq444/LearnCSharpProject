using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Collect.Data
{
    class PinDuoDuo
    {
        List<string> list = new List<string>()
        {
            "拼多多-01",
            "拼多多-02",
            "拼多多-03",
            "拼多多-04",
            "拼多多-05",
            "拼多多-06",
            "拼多多-07",
            "拼多多-08",
            "拼多多-09",
            "拼多多-10"
        };

        public event Action<string> SetData;

        public void Collect(CancellationTokenSource cts)
        {
            foreach (string item in list)
            {
                if (cts.IsCancellationRequested)
                    return;
                Thread.Sleep(100);

                SetData(item);
            }
        }
    }
}
