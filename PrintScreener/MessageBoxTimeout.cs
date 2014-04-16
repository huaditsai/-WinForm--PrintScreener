using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace PrintScreener.Resources
{
    class MessageBoxTimeout
    {
        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        private delegate int EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        private static extern int GetClassName(IntPtr hWnd, [Out] StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern bool IsWindowEnabled(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        private class TimerThread
        {
            private readonly DateTime timeoutTime;
            private readonly uint currentThreadId;
            private bool terminateFlag;
            private readonly Thread thread;

            public TimerThread(int timeoutMillisec)
            {
                timeoutTime = DateTime.Now.AddMilliseconds(timeoutMillisec);
                currentThreadId = GetCurrentThreadId();
                terminateFlag = false;
                thread = new Thread(ThreadProc);
                thread.Start();
            }

            private void ThreadProc()
            {
                while (!terminateFlag)
                {
                    Thread.Sleep(100);

                    if (DateTime.Now > timeoutTime)
                    {
                        EnumWindows(EnumWindowsProc, new IntPtr(0));
                        return;
                    }
                }
            }

            private int EnumWindowsProc(IntPtr hWnd, IntPtr lParam)
            {
                uint processId;
                uint threadId;
                threadId = GetWindowThreadProcessId(hWnd, out processId);

                if (threadId == currentThreadId)
                {
                    StringBuilder className = new StringBuilder("", 256);
                    GetClassName(hWnd, className, 256);
                    if (className.ToString() == "#32770" && IsWindowEnabled(hWnd))
                    {
                        const int WM_COMMAND = 0x111;
                        PostMessage(hWnd, WM_COMMAND, new IntPtr(2), new IntPtr(0));
                        return 0;
                    }
                }
                return 1;
            }            

            public void Terminate()
            {
                terminateFlag = true;
                thread.Join();
            }
        }
        
        public static DialogResult Show(string text, int timeoutMillsec)
        {
            TimerThread tt = new TimerThread(timeoutMillsec);

            try
            {
                return MessageBox.Show(text);
            }
            finally
            {
                tt.Terminate();
            }
        }


        public static DialogResult Show(string text, string caption, int timeoutMillsec)
        {
            TimerThread tt = new TimerThread(timeoutMillsec);
            try
            {
                return MessageBox.Show(text, caption);
            }
            finally
            {
                tt.Terminate();
            }
        }


    }
}

