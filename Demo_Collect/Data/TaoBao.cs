using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Collect.Data
{
    class TaoBao
    {
        List<string> list = new List<string>()
        {
            "淘宝-01",
            "淘宝-02",
            "淘宝-03",
            "淘宝-04",
            "淘宝-05",
            "淘宝-06",
            "淘宝-07",
            "淘宝-08",
            "淘宝-09",
            "淘宝-10"
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
