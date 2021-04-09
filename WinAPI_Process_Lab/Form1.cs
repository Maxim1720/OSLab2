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
                (data.p.VirtualMemorySize64 / (1024 * 1024)).ToString("0.0") + "/" + (data.RAM_Size / (1024)).ToString("0.0");
        }


        private void Read_AltoButton_Click(object sender, EventArgs e)
        {
            data.ReadingValue = TextToReadingVar_altoTextBox1.Text;
            ReadingVar_metroLabel1.Text = data.ReadingValue;

            WriteString();
            WritingVar_metroLabel2.Text = data.WritingValue;
        }

        private void WriteString()
        {
            //data.buffer;// = Encoding.Unicode.GetBytes(data.ReadingValue);
            data.WritingValue = new string(data.ReadingValue.Length.ToString().ToCharArray());
            byte[] buffer = new byte[data.ReadingValue.Length * 2];

            IntPtr bytesReaden = IntPtr.Zero;
            IntPtr bytesWritten = IntPtr.Zero;

            //if (data.GetReadingAddress().ToInt64() > 0)
            //{
            if (ApiMethods.ReadProcessMemory(data.p.Handle, data.GetReadingAddress(), buffer, buffer.Length, out bytesReaden))
            {
                buffer = Encoding.Unicode.GetBytes(Encoding.Unicode.GetString(buffer).Trim());

                if (ApiMethods.WriteProcessMemory(data.p.Handle, data.GetWritingAddress(), buffer, buffer.Length, out bytesWritten))
                {
                    MessageBox.Show("Запись и чтение прошли успешно");
                }
                else
                {
                    MessageBox.Show("Не записал");
                }
            }
            else
                MessageBox.Show("Не прочёл");
            // }

        }

        
    }
    public class Data
    {

        #region Private fields

        private string readingValue_field = "              ";
        private string writingValue_field = "              ";

        IntPtr ReadingValueAdr = IntPtr.Zero;
        IntPtr WritingValueAdr = IntPtr.Zero;

        #endregion



        #region Public fields

        public Process p;
        public long RAM_Size;
        public byte[] buffer;

        #endregion



        #region Public methods

        public Data()
        {
        }

        public string ReadingValue
        {
            get
            {
                return readingValue_field;
            }
            set
            {
                readingValue_field = value;

                buffer = new byte[value.Length * 2];
            }
        }
        public string WritingValue
        {
            get
            {
                return writingValue_field;
            }
            set
            {
                writingValue_field = value;
            }
        }





        public IntPtr GetReadingAddress()
        {
            //if (ReadingValueAdr == IntPtr.Zero)
            //{
                unsafe
                {
                    TypedReference carRef = __makeref(readingValue_field);
                    IntPtr ptr = **(IntPtr**)&carRef;
                    ReadingValueAdr = ptr + 8;
                }
            //}
            return ReadingValueAdr;
        }
        public IntPtr GetWritingAddress()
        {
            //if (WritingValueAdr == IntPtr.Zero)
            //{
                unsafe
                {
                    TypedReference carRef = __makeref(writingValue_field);                                                                  //     записываемоего значения
                    IntPtr ptr = **(IntPtr**)&carRef;                                                                               // <--|
                    WritingValueAdr = ptr + 8;
                }
            //}

            return WritingValueAdr;
        }

        #endregion



    }

    public class ApiMethods
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out] byte[] lpbuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            out IntPtr lpNumberOfBytesWritten);
    }


    public class ReadWrite
    {

    }

}
