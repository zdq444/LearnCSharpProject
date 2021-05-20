using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Collect
{
    public class TaskModel
    {
        public Task _Task { get; set; }

        /// <summary>
        /// 线程的任务管理对象（取消任务）
        /// </summary>
        public CancellationTokenSource _CTS { get; set; }
    }
}
