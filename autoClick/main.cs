using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace autoClick
{
    public partial class main : Form
    {
        [DllImport("user32.dll")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);
        const int MOUSEEVENTF_MOVE = 0x0001;      //移动鼠标 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002; //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTUP = 0x0004; //模拟鼠标左键抬起 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008; //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTUP = 0x0010; //模拟鼠标右键抬起 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040; //模拟鼠标中键抬起 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000; //标示是否采用绝对坐标 

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            background bg = new background();
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.WindowState = FormWindowState.Maximized;
            bg.TopMost = true;
            // 如果设为0，就会出现这个页面真的消失了。。。尼玛谁能告诉我为啥？
            bg.Opacity = 0.01;

            // 注册获得坐标函数
            bg.PointUpdated += new background.PointUpdateHandler(get_background_point);

            bg.Show();
        }

        private void get_background_point(object sender, PointUpdateEventArgs e)
        {
            var mouse_point = e.Mouse;
            mouse_x.Text = mouse_point.X.ToString();
            mouse_y.Text = mouse_point.Y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (times.Text == "" || mouse_x.Text == "" || mouse_y.Text == "")
            {
                MessageBox.Show("请选择坐标，然后设定需要循环的时间");
                return;
            }

            int time = int.Parse(times.Text);
            System.Timers.Timer t = new System.Timers.Timer(time * 1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(theout); 
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)； 
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件； 
        }

        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            // 拿个随机种子, 随机在10秒内的一个时间点点击
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int sleep_time = ran.Next(10);
            Thread.Sleep(sleep_time * 1000);
            //执行定位到需要点击的地方
            SetCursorPos(int.Parse(mouse_x.Text), int.Parse(mouse_y.Text));

            //执行点击
            //点击
            mouse_event(MOUSEEVENTF_LEFTDOWN, int.Parse(mouse_x.Text), int.Parse(mouse_y.Text), 0, MOUSEEVENTF_ABSOLUTE);
            Thread.Sleep(50);
            //抬起
            mouse_event(MOUSEEVENTF_LEFTUP, int.Parse(mouse_x.Text), int.Parse(mouse_y.Text),0, MOUSEEVENTF_ABSOLUTE);

            // 防止大姨妈点两次
            //点击
            mouse_event(MOUSEEVENTF_LEFTDOWN, int.Parse(mouse_x.Text), int.Parse(mouse_y.Text), 0, MOUSEEVENTF_ABSOLUTE);
            Thread.Sleep(50);
            //抬起
            mouse_event(MOUSEEVENTF_LEFTUP, int.Parse(mouse_x.Text), int.Parse(mouse_y.Text), 0, MOUSEEVENTF_ABSOLUTE);

        }
    }
}
