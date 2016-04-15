using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoClick
{
    public partial class background : Form
    {
        //声明一个更新Point的委托
        public delegate void PointUpdateHandler(object sender, PointUpdateEventArgs e);

        //声明一个更新Point的事件
        public event PointUpdateHandler PointUpdated;

        public background()
        {
            InitializeComponent();
        }

        private void background_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            var args = new PointUpdateEventArgs(x, y);
            PointUpdated(this, args);
            this.Close();
        }

    }

    public class PointUpdateEventArgs : System.EventArgs
    {
        private Point mouse;
        public PointUpdateEventArgs(int x, int y)
        {
            this.mouse = new Point(x, y);
        }
        public Point Mouse { get { return mouse; } }
    }
}
