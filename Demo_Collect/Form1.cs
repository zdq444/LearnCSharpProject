using Demo_Collect.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Collect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 放待采集的对象
        /// </summary>
        Dictionary<string, TaskModel> dict = new Dictionary<string, TaskModel>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            JingDong jd = new JingDong();
            TaoBao tb = new TaoBao();
            PinDuoDuo pdd = new PinDuoDuo();

            jd.SetData += GetData;//注册委托事件，需要回调的时候才注册
            tb.SetData += GetData;
            pdd.SetData += GetData;

            TaskModel taskModel1 = new TaskModel();
            TaskModel taskModel2 = new TaskModel();
            TaskModel taskModel3 = new TaskModel();
            taskModel1._CTS = new System.Threading.CancellationTokenSource();
            taskModel2._CTS = new System.Threading.CancellationTokenSource();
            taskModel3._CTS = new System.Threading.CancellationTokenSource();

            taskModel1._Task = new Task(()=> { jd.Collect(taskModel1._CTS); });
            taskModel2._Task = new Task(() => { tb.Collect(taskModel2._CTS); });
            taskModel3._Task = new Task(() => { pdd.Collect(taskModel3._CTS); });


            dict.Add("京东", taskModel1);
            dict.Add("淘宝", taskModel2);
            dict.Add("拼多多", taskModel3);


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //JingDong JD = new JingDong();
            //JD.GetData += GetData;
            //Task t1 = new Task(JD.Collect);
            //t1.Start();


            foreach (TaskModel taskModel in dict.Values)
            {
                taskModel._Task.Start();

            }
           
        }

        private void GetData(string value)
        {           
                this.Invoke(new Action(() => {
                    lock (this)
                    {
                        this.listBox1.Items.Add(value);
                    }
                   
                }));
            
            
        }

        public void SetValue(string value)
        {
            
            this.Invoke(new Action(() => {
                this.listBox1.Items.Add(value);
            }));
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            TaskModel tm = dict[this.cmbWeb.Text];
            tm._CTS.Cancel();
        }
    }
}
