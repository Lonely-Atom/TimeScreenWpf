using System.Windows;
using System.Windows.Threading;

namespace TimeScreenWpf
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            #region 创建并启动计时器
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(0.5)
            };
            timer.Tick += Timer_Tick;

            timer.Start();
            #endregion
        }

        /// <summary>
        /// 窗口关闭事件回调
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            timer.Stop();
        }

        /// <summary>
        /// 计时器 Tick 事件回调
        /// </summary>
        private void Timer_Tick(object? sender, EventArgs e)
        {
            lab_Time.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
