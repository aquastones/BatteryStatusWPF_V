using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;

namespace BatteryStatusWPF_V
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartBatteryMonitoring();
        }

        private void StartBatteryMonitoring()
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += (s, e) => UpdatePowerStatus();
            timer.Start();

            UpdatePowerStatus();
        }

        private void UpdatePowerStatus()
        {
            PowerStatus status = SystemInformation.PowerStatus;

            txtChargeStatus.Text = $"Status: {status.BatteryChargeStatus}";
            txtCharge.Text = $"Charge: {status.BatteryLifePercent:P0}";
        }

        private void Draggable(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}