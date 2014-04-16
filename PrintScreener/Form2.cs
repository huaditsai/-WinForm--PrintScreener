using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintScreener
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //this.MouseDown += new MouseEventHandler(this.MouseDown1);
            //this.MouseMove += new MouseEventHandler(this.MouseMove1);

            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 0.8;//透明度

            label1.Text = "Confirm with Space" + "\r\n" + "Esc to Exit";
            label1.Location = new Point(this.Location.X + this.Size.Width / 2 - label1.Size.Width / 2, this.Location.Y + this.Size.Height / 2 - label1.Size.Height / 2);
        }


        #region 控制大小
        const int WM_NCHITTEST = 0x0084; //滑鼠事件
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        int padding = 5;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= padding)//left
                    {
                        if (vPoint.Y <= padding)//top left
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - padding)//bottom left
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;//left
                    }
                    else if (vPoint.X >= ClientSize.Width - padding)//right
                    {
                        if (vPoint.Y <= padding)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - padding)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    }
                    else if (vPoint.Y <= padding)//top
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - padding)//bottom
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
            }
        }
        #endregion


        bool issave = true;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                issave = false;                
            }

            if (e.KeyCode == Keys.Space)
            {
                issave = true;                
            }
            this.Close();
        }
        

        public bool IsSave()
        {
            return issave;
        }
        


        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            //label1.Location = new Point(this.Location.X + this.Size.Width / 2 - label1.Size.Width / 2, this.Location.Y + this.Size.Height / 2 - label1.Size.Height / 2);

            labLx.Text = "X : " + this.Location.X.ToString();
            labRx.Text = this.Size.Width.ToString();
            labTy.Text = "Y : " + this.Location.Y.ToString();
            labDy.Text = this.Size.Height.ToString();
        }        


        #region 移動視窗
        //[DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();
        //[DllImport("user32.dll")]
        //public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //public const int WM_SYSCOMMAND = 0X0112;
        //public const int SC_MOVE = 0XF010;
        //public const int HTCAPTION = 0X0002;

        //private void MouseDown1(object sender, MouseEventArgs e)
        //{
        //    //if (e.Y > 65)
        //    //    return;

        //    ReleaseCapture();
        //    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        //}

        //private void MouseMove1(object sender, MouseEventArgs e)
        //{
        //    //if (e.Y < 65)
        //    this.Cursor = Cursors.SizeAll;
        //    //else
        //    //    this.Cursor = Cursors.Default;
        //}
        #endregion


    }
}
