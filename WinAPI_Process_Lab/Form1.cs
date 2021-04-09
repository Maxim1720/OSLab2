using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace WinAPI_Process_Lab
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Data data;
        public Form1()
        {
            InitializeComponent();
            data = new Data();
            data.p = Process.GetCurrentProcess();
            
            ApiMethods.GetPhysicallyInstalledSystemMemory(out data.RAM_Size);
            
            VirtualMemorySize_SlidingLabel.Text = 
                (data.p.VirtualMemorySize64 / (1024*1024)).ToString("0.0") + "/" + (data.RAM_Size / (1024)).ToString("0.0");
        }

        

        private void Read_AltoButton_Click(object sender, EventArgs e)
        {
            data.ReadingValue = new StringBuilder(TextToReadingVar_altoTextBox1.Text);
            ReadingVar_metroLabel1.Text = data.ReadingValue.ToString();

        }
    }
    public class Data
    {
        public Process p;
        public long RAM_Size;

        public StringBuilder ReadingValue;
        public StringBuilder WritingValue;

    }

    public class ApiMethods
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);


        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
    }
}
