using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using PrintScreener.Resources;
using System.Runtime.InteropServices;

//2013-06-14 Expression.Encoder 
//由於發布給人及其他種種問題，關掉了此功能
namespace PrintScreener
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;

        //ScreenCaptureJob job; //跟錄影有關
        bool isRecord = false;

        private static Bitmap bmp;
        private static Graphics gfx;

        Point upLfSource;
        Point upLfDestination;
        Size blockRegionSize;

        string imgformat = "jpg";
        ImageFormat imgFormat = ImageFormat.Jpeg;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();

            btnRecord.Enabled = false;
            //job = new ScreenCaptureJob();

            txtPath.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
            rbtnJPG.Checked = true;
            rbtnModFull.Checked = true;

            upLfSource = new Point(0, 0);//左上角的點
            upLfDestination = new Point(0, 0);//圖片左上角的點 的 位移
            blockRegionSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);//圖片大小

            //KeyboardHook.globalControlOnly = true;  //只有Global KeyDown會起作用，其他程式不能攔截鍵盤事件
            KeyboardHook.GlobalKeyDown += KeyboardHook_KeyDown; //啟用全域事件處理

            //job.CaptureRectangle = new Rectangle(0, 0, blockRegionSize.Width, blockRegionSize.Height);
            //job.OutputPath = txtPath.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                //job.OutputPath = txtPath.Text;
            }
        }

        int pictureNumber = 0;
        private void btnPrSc_Click(object sender, EventArgs e)
        {
            PrintScreen();
        }
        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();  //取得KeyCode字串
            //this.Text = key;
            if (key == "PrintScreen")
                PrintScreen();

            if (isRecord && key == "Escape")
            {
                this.WindowState = FormWindowState.Normal;
                isRecord = false;
                //job.Stop();
            }
        }
        private void PrintScreen()//main
        {
            this.Hide();
            form3.Hide();
            Thread.Sleep(300);
            if (this.Visible == false)
            {
                bmp = new Bitmap(blockRegionSize.Width, blockRegionSize.Height);
                gfx = Graphics.FromImage(bmp);
                gfx.CopyFromScreen(upLfSource, upLfDestination, blockRegionSize, CopyPixelOperation.SourceCopy);

                bmp.Save(txtPath.Text + "screen " + pictureNumber.ToString() + "." + imgformat, imgFormat);
                pictureNumber++;
            }
            this.Show();
            if (rbtnModArea.Checked) form3.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)//從系統列還原
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (rbtnModArea.Checked) form3.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;//Notify Icon隱藏
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)//縮到最小
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (rbtnModArea.Checked) form3.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;//Notify Icon顯示
            }
        }

        private void rbtnJPG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJPG.Checked)
            {
                imgformat = "jpg";
                imgFormat = ImageFormat.Jpeg;
            }
        }

        private void rbtnPNG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPNG.Checked)
            {
                imgformat = "png";
                imgFormat = ImageFormat.Png;
            }
        }

        private void rbtnBMP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBMP.Checked)
            {
                imgformat = "bmp";
                imgFormat = ImageFormat.Bmp;
            }
        }

        private void rbtnModFull_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnModFull.Checked)
            {
                form3.Hide();
                upLfSource = new Point(0, 0);
                blockRegionSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                //job.CaptureRectangle = new Rectangle(upLfSource.X, upLfSource.Y, blockRegionSize.Width, blockRegionSize.Height);
            }
        }

        private void rbtnModArea_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnModArea.Checked)
            {
                upLfSource = form3.UpLeftSource();
                blockRegionSize = form3.BlockRegionSize();

                form3.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Hide();

            KeyboardHook.GlobalKeyDown -= KeyboardHook_KeyDown; //不啟用全域事件處理

            form2.ShowDialog();

            KeyboardHook.GlobalKeyDown += KeyboardHook_KeyDown; //啟用全域事件處理

            this.Show();

            form3.Location = form2.Location;
            form3.Size = form2.Size;

            form3.Show();

            upLfSource = form3.UpLeftSource();
            blockRegionSize = form3.BlockRegionSize();
        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            isRecord = !isRecord;
            if (isRecord)
            {
                MessageBoxTimeout.Show("Press \"Esc\" to Stop", "Message", 3000);
                this.WindowState = FormWindowState.Minimized;
                //job.CaptureRectangle = new Rectangle(upLfSource.X, upLfSource.Y, blockRegionSize.Width, blockRegionSize.Height);
                //Thread.Sleep(1);                

                //job.Start();
            }
            else
            {
                //job.Stop();
            }
        }

        //[DllImport("User32.dll", EntryPoint = "FindWindow")]
        //private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        //[DllImport("user32.dll")]
        //private static extern Int32 GetWindowText(Int32 hWnd, StringBuilder lpsb, Int32 count);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();        

        [DllImport("user32.dll")]
        public static extern Boolean GetWindowRect(IntPtr hWnd, out Rectangle bounds);

        private void rbtnAct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAct.Checked)
            {
                form3.Hide();
                System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer();
                formTimer.Tick += new EventHandler(formTimerTick);

                formTimer.Start();
            }
        }
        private void formTimerTick(object sender, EventArgs e)
        {
            IntPtr handle = GetForegroundWindow();
            //StringBuilder sb = new StringBuilder(256);

            Rectangle bounds = new Rectangle();
            GetWindowRect(handle, out bounds);

            upLfSource = bounds.Location;
            blockRegionSize = new Size(bounds.Width - bounds.Left, bounds.Height - bounds.Top);

            //if (GetWindowText(handle, sb, sb.Capacity) > 0)
            //{
            //    label1.Text = "視窗標題:" + sb.ToString();                
            //}
        }

             

    }
}
