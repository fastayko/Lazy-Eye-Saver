using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lazy_Eye_Saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            setBrightness((int)nudBrightness.Value);
        }

        private void setBrightness(int value)
        {
            var instance = new PhysicalMonitorBrightnessController();
            instance.Set((uint)value);
            WindowsSettingsBrightnessController.Set((int)value);
        }

        private void nudBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbBrightness.Value = (int)nudBrightness.Value;
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            nudBrightness.Value = tbBrightness.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        void loadSettings()
        {
            nudBrightness.Value = Properties.Settings.Default.lastBrightness;
            tbBrightness.Value = Properties.Settings.Default.lastBrightness;
            cbAutoBrightnessControl.Checked = Properties.Settings.Default.AutoBrightnessChecked;
            cbZone1.Checked = Properties.Settings.Default.Zone1Checked;
            cbZone2.Checked = Properties.Settings.Default.Zone2Checked;
            cbZone3.Checked = Properties.Settings.Default.Zone3Checked;
            cbZone4.Checked = Properties.Settings.Default.Zone4Checked;
            dtpFrom1.Value = Properties.Settings.Default.TimeFrom1;
            dtpFrom2.Value = Properties.Settings.Default.TimeFrom2;
            dtpFrom3.Value = Properties.Settings.Default.TimeFrom3;
            dtpFrom4.Value = Properties.Settings.Default.TimeFrom4;
            dtpTo1.Value = Properties.Settings.Default.TimeTo1;
            dtpTo2.Value = Properties.Settings.Default.TimeTo2;
            dtpTo3.Value = Properties.Settings.Default.TimeTo3;
            dtpTo4.Value = Properties.Settings.Default.TimeTo4;
            nudAutoBrightness1.Value = Properties.Settings.Default.Brightness1;
            nudAutoBrightness2.Value = Properties.Settings.Default.Brightness2;
            nudAutoBrightness2.Value = Properties.Settings.Default.Brightness3;
            nudAutoBrightness3.Value = Properties.Settings.Default.Brightness4;
            nudSmoothDuration.Value = Properties.Settings.Default.SmoothDuration;
            cbTimeUnit.SelectedItem = Properties.Settings.Default.SmoothUnit;
        }

        void saveSettings()
        {
            Properties.Settings.Default.lastBrightness = (int)nudBrightness.Value;
            Properties.Settings.Default.AutoBrightnessChecked = cbAutoBrightnessControl.Checked;
            Properties.Settings.Default.Zone1Checked = cbZone1.Checked;
            Properties.Settings.Default.Zone2Checked = cbZone2.Checked;
            Properties.Settings.Default.Zone3Checked = cbZone3.Checked;
            Properties.Settings.Default.Zone4Checked = cbZone4.Checked;
            Properties.Settings.Default.TimeFrom1 = dtpFrom1.Value;
            Properties.Settings.Default.TimeFrom2 = dtpFrom2.Value;
            Properties.Settings.Default.TimeFrom3 = dtpFrom3.Value;
            Properties.Settings.Default.TimeFrom4 = dtpFrom4.Value;
            Properties.Settings.Default.TimeTo1 = dtpTo1.Value;
            Properties.Settings.Default.TimeTo2 = dtpTo2.Value;
            Properties.Settings.Default.TimeTo3 = dtpTo3.Value;
            Properties.Settings.Default.TimeTo4 = dtpTo4.Value;
            Properties.Settings.Default.Brightness1 = (int)nudAutoBrightness1.Value;
            Properties.Settings.Default.Brightness2 = (int)nudAutoBrightness2.Value;
            Properties.Settings.Default.Brightness3 = (int)nudAutoBrightness2.Value;
            Properties.Settings.Default.Brightness4 = (int)nudAutoBrightness3.Value;
            Properties.Settings.Default.SmoothDuration = (int)nudSmoothDuration.Value;
            Properties.Settings.Default.SmoothUnit = (string)cbTimeUnit.SelectedItem;
        }

        private void cbAutoBrightnessControl_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAutoBrightnessControl.Checked) tmrCheckAutomation.Enabled = true;
            else tmrCheckAutomation.Enabled = false;
        }

        private void updateStatus(string text)
        {

            lblStatus.Text = "Status: " + text + ", at: " + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void tmrCheckAutomation_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int res = DateTime.Compare(now, dtpFrom1.Value);
            if (cbZone1.Checked && DateTime.Compare(now, dtpFrom1.Value) >= 0 && DateTime.Compare(now, dtpTo1.Value) <= 0)
            {
                setBrightness((int)nudAutoBrightness1.Value);
                updateStatus("Zone 1 Activated.");
            }
            else if (cbZone2.Checked && DateTime.Compare(now, dtpFrom2.Value) >= 0 && DateTime.Compare(now, dtpTo2.Value) <= 0)
            {
                setBrightness((int)nudAutoBrightness2.Value);
                updateStatus("Zone 2 Activated.");
            }
            else if (cbZone3.Checked && DateTime.Compare(now, dtpFrom3.Value) >= 0 && DateTime.Compare(now, dtpTo3.Value) <= 0)
            {
                setBrightness((int)nudAutoBrightness3.Value);
                updateStatus("Zone 3 Activated.");
            }
            else if (cbZone4.Checked && DateTime.Compare(now, dtpFrom4.Value) >= 0 && DateTime.Compare(now, dtpTo4.Value) <= 0)
            {
                setBrightness((int)nudAutoBrightness4.Value);
                updateStatus("Zone 4 Activated.");
            }
            //TODO: i have to make it do once not spam every minute
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }
    }


    public class PhysicalMonitorBrightnessController : IDisposable
    {
        #region DllImport
        [DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

        [DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetMonitorBrightness(IntPtr handle, ref uint minimumBrightness, ref uint currentBrightness, ref uint maxBrightness);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetMonitorBrightness(IntPtr handle, uint newBrightness);

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DestroyPhysicalMonitor(IntPtr hMonitor);

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPhysicalMonitors(uint dwPhysicalMonitorArraySize, [In] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("user32.dll")]
        static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, EnumMonitorsDelegate lpfnEnum, IntPtr dwData);
        delegate bool EnumMonitorsDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);
        #endregion

        private IReadOnlyCollection<MonitorInfo> Monitors { get; set; }

        public PhysicalMonitorBrightnessController()
        {
            UpdateMonitors();
        }

        #region Get & Set
        public void Set(uint brightness)
        {
            Set(brightness, true);
        }

        private void Set(uint brightness, bool refreshMonitorsIfNeeded)
        {
            bool isSomeFail = false;
            foreach (var monitor in Monitors)
            {
                uint realNewValue = (monitor.MaxValue - monitor.MinValue) * brightness / 100 + monitor.MinValue;
                if (SetMonitorBrightness(monitor.Handle, realNewValue))
                {
                    monitor.CurrentValue = realNewValue;
                }
                else if (refreshMonitorsIfNeeded)
                {
                    isSomeFail = true;
                    break;
                }
            }

            if (refreshMonitorsIfNeeded && (isSomeFail || !Monitors.Any()))
            {
                UpdateMonitors();
                Set(brightness, false);
                return;
            }
        }

        public int Get()
        {
            if (!Monitors.Any())
            {
                return -1;
            }
            return (int)Monitors.Average(d => d.CurrentValue);
        }
        #endregion

        private void UpdateMonitors()
        {
            DisposeMonitors(this.Monitors);

            var monitors = new List<MonitorInfo>();
            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, (IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData) =>
            {
                uint physicalMonitorsCount = 0;
                if (!GetNumberOfPhysicalMonitorsFromHMONITOR(hMonitor, ref physicalMonitorsCount))
                {
                    // Cannot get monitor count
                    return true;
                }

                var physicalMonitors = new PHYSICAL_MONITOR[physicalMonitorsCount];
                if (!GetPhysicalMonitorsFromHMONITOR(hMonitor, physicalMonitorsCount, physicalMonitors))
                {
                    // Cannot get physical monitor handle
                    return true;
                }

                foreach (PHYSICAL_MONITOR physicalMonitor in physicalMonitors)
                {
                    uint minValue = 0, currentValue = 0, maxValue = 0;
                    if (!GetMonitorBrightness(physicalMonitor.hPhysicalMonitor, ref minValue, ref currentValue, ref maxValue))
                    {
                        DestroyPhysicalMonitor(physicalMonitor.hPhysicalMonitor);
                        continue;
                    }

                    var info = new MonitorInfo
                    {
                        Handle = physicalMonitor.hPhysicalMonitor,
                        MinValue = minValue,
                        CurrentValue = currentValue,
                        MaxValue = maxValue,
                    };
                    monitors.Add(info);
                }

                return true;
            }, IntPtr.Zero);

            this.Monitors = monitors;
        }

        public void Dispose()
        {
            DisposeMonitors(Monitors);
            GC.SuppressFinalize(this);
        }

        private static void DisposeMonitors(IEnumerable<MonitorInfo> monitors)
        {
            if (monitors?.Any() == true)
            {
                PHYSICAL_MONITOR[] monitorArray = monitors.Select(m => new PHYSICAL_MONITOR { hPhysicalMonitor = m.Handle }).ToArray();
                DestroyPhysicalMonitors((uint)monitorArray.Length, monitorArray);
            }
        }

        #region Classes
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PHYSICAL_MONITOR
        {
            public IntPtr hPhysicalMonitor;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szPhysicalMonitorDescription;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public class MonitorInfo
        {
            public uint MinValue { get; set; }
            public uint MaxValue { get; set; }
            public IntPtr Handle { get; set; }
            public uint CurrentValue { get; set; }
        }
        #endregion
    }

    public static class WindowsSettingsBrightnessController
    {
        public static int Get()
        {
             var mclass = new ManagementClass("WmiMonitorBrightness")
            {
                Scope = new ManagementScope(@"\\.\root\wmi")
            };
             var instances = mclass.GetInstances();
            foreach (ManagementObject instance in instances)
            {
                return (byte)instance.GetPropertyValue("CurrentBrightness");
            }
            return 0;
        }

        public static void Set(int brightness)
        {
             var mclass = new ManagementClass("WmiMonitorBrightnessMethods")
            {
                Scope = new ManagementScope(@"\\.\root\wmi")
            };
             var instances = mclass.GetInstances();
            var args = new object[] { 1, brightness };
            foreach (ManagementObject instance in instances)
            {
                instance.InvokeMethod("WmiSetBrightness", args);
            }
        }
    }
}
