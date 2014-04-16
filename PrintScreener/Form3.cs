using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PrintScreener
{
    public partial class Form3 : Form
    {
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);

        public Form3()
        {
            InitializeComponent();

            //this.Opacity = 0.4;//透明度
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //uint pre_style = GetWindowLong(this.Handle, GWL_EXSTYLE);// 先取出            
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);// 設定某form穿透            
            //SetWindowLong(this.Handle, GWL_EXSTYLE, pre_style);// 設回原本
        }

        public Point UpLeftSource()
        {
            return new Point(this.Location.X, this.Location.Y);
        }
        public Size BlockRegionSize()
        {
            return this.Size;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid);
        }



    }
}
