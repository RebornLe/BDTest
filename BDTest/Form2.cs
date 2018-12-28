using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BDTest
{
    public partial class Form2 : Form
    {
        public delegate void Displaydelegate(byte[] InputBuf);
        Byte[] OutputBuf = new Byte[128];
        public Displaydelegate dispdelegate;
        public Form2()
        {           
            InitializeComponent();
        }
        #region 示例更改
        static bool _continue;
        static SerialPort _serialPort;
        static void GetData(string[] args)
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();           

            while (_continue)
            {
                message = Console.ReadLine();
                _serialPort.WriteLine(
                    String.Format("{0}", message));
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }

        // Display Port values and prompt user to enter a port.
        public static string SetPortName(string defaultPortName)
        {
            string portName;           
            portName = defaultPortName;           
            return portName;
        }
        // Display BaudRate values and prompt user to enter a value.
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;           
            baudRate = defaultPortBaudRate.ToString();         
            return int.Parse(baudRate);
        }

        // Display PortParity values and prompt user to enter a value.
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;         
            parity = defaultPortParity.ToString();           
            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value.
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;           
            dataBits = defaultPortDataBits.ToString();            
            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value.
        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;                                 
            stopBits = defaultPortStopBits.ToString();           
            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;                                 
            handshake = defaultPortHandshake.ToString();            
            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
        #endregion



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)//每次从端口接收数据
        {
            Byte[] InputBuf = new Byte[128];
            
            try
            {
                serialPort1.Read(InputBuf, 0, serialPort1.ReadByte());       //读取缓冲区的数据直到“}”即0x7D为结束符  
                //InputBuf = UnicodeEncoding.Default.GetBytes(strRD);             //将得到的数据转换成byte的格式  
                System.Threading.Thread.Sleep(50);
                this.Invoke(dispdelegate, InputBuf);

            }
            catch (TimeoutException ex)         //超时处理  
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DispUI(byte[] InputBuf)
        {
            //textBox1.Text = Convert.ToString(InputBuf);  

            ASCIIEncoding encoding = new ASCIIEncoding();
            richTextBox1.AppendText(encoding.GetString(InputBuf));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadPortNameList();
            LoadParityList();
            LoadStopBitsList();
            LoadHandShakeList();
            dispdelegate = new Displaydelegate(DispUI);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        #region PortName,Parity,StopBits,HandShake四个下拉框的数据源
        private void LoadPortNameList()//PortName下拉框数据源
        {
            List<string> NameList = new List<string>();
            foreach (string name in SerialPort.GetPortNames())
            {
                NameList.Add(name);
            }
            PortName0.DataSource = NameList;
        }

        private void LoadParityList()//Parity下拉框数据源
        {
            List<string> ParityList = new List<string>();
            foreach (string parity in Enum.GetNames(typeof(Parity)))
            {
                ParityList.Add(parity);
            }
            Parity0.DataSource = ParityList;
        }

        private void LoadStopBitsList()//StopBits下拉框数据源
        {
            List<string> StopBitsList = new List<string>();
            foreach (string stopbits in Enum.GetNames(typeof(StopBits)))
            {
                StopBitsList.Add(stopbits);
            }
            StopBits0.DataSource = StopBitsList;
            StopBits0.Text = "One";
        }

        private void LoadHandShakeList()//Handshake下拉框数据源
        {
            List<string> HandShakeList = new List<string>();
            foreach (string handshake in Enum.GetNames(typeof(Handshake)))
            {
                HandShakeList.Add(handshake);
            }
            HandShake0.DataSource = HandShakeList;
        }
        #endregion

        private void OpenSerialPort_Click(object sender, EventArgs e)//打开按钮
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    MessageBox.Show("串口已经打开");
                }
                else
                {
                    serialPort1.PortName = PortName0.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BandRate0.Text);         
                    serialPort1.Parity  = StringToParity(Parity0.Text);
                    serialPort1.DataBits = Convert.ToInt32(DataBits0.Text);
                    serialPort1.StopBits = StringToStopBits(StopBits0.Text);
                    serialPort1.Handshake = StringToHandShake(HandShake0.Text);
                    serialPort1.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ShowMap_Click(object sender, EventArgs e)//显示地图
        {
            Form1 map = new Form1();
            map.Show();
        }

        private void CloseSerialPort_Click(object sender, EventArgs e)//关闭串口
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();              
                }
                else
                {
                    MessageBox.Show("串口已经关闭");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region 三种类型转换
        private Parity StringToParity(string parity)//字符串到Parity
        {
            if (parity.Equals("None"))
            {
                return Parity.None;

            }
            else if (parity.Equals("Odd"))
            {
                return Parity.Odd;
            }
            else if (parity.Equals("Even"))
            {
                return Parity.Even;
            }
            else if (parity.Equals("Mark"))
            {
                return Parity.Mark;
            }
            else
            {
                return Parity.Space;
            }
        }

        private StopBits StringToStopBits(string stopbits)//字符串到StopBits
        {
            if (stopbits.Equals("None"))
            {
                return StopBits.None;
            }
            else if (stopbits.Equals("One"))
            {
                return StopBits.One;
            }
            else if (stopbits.Equals("Two"))
            {
                return StopBits.Two;
            }
            else
            {
                return StopBits.OnePointFive;
            }
        }

        private Handshake StringToHandShake(string handshake)//字符串到Handshak
        {
            if (handshake.Equals("None"))
            {
                return Handshake.None;
            }
            else if (handshake.Equals("XOnXOff"))
            {
                return Handshake.XOnXOff;
            }
            else if (handshake.Equals("RequestToSend"))
            {
                return Handshake.RequestToSend;
            }
            else
            {
                return Handshake.RequestToSendXOnXOff;
            }
        }
        #endregion

    }
}