using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Collect.Data
{
    class JingDong
    {
        List<string> list = new List<string>()
        {
            "京东-01",
            "京东-02",
            "京东-03",
            "京东-04",
            "京东-05",
            "京东-06",
            "京东-07",
            "京东-08",
            "京东-09",
            "京东-10"
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
