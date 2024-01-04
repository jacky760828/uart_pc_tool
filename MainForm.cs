using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;


/// <summary>
/// this is a program about usart.
/// this is a simple practice program.
/// we are use the technology with "serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);"
/// and use should write funcation at the line 25
/// author:xiebin 2016.4.11
/// </summary>
namespace Usart1
{
    
  
    
    public partial class MainForm : Form
    {
        int speed;
        byte battary;
        private Thread t;
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);//导出系统函数
        [DllImport("kernel32.dll")]
        private static extern long GetPrivateProfileString(string section,string key,string def,StringBuilder retVal,int size,string filePath);
        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "info.ini";//获取当前可执行文件的位置，在此位置建立一个文件名
        StringBuilder savePort = new StringBuilder(255);//存储读取的ini内容变量
        StringBuilder saveBps = new StringBuilder(255);
        StringBuilder saveDataBit = new StringBuilder(8);
        StringBuilder saveStopBit = new StringBuilder(8);
        StringBuilder saveChickBit = new StringBuilder(8);
        StringBuilder saveFlowControl = new StringBuilder(8);
       // private WriteProtocol writeCommand;
        private ReadProtocol readResponse;
       
        private Boolean sending;
        private Boolean receiving;
     //   private Boolean receiving;
       // delegate int Display(Byte[] buffer);
        delegate void Display(Byte[] buffer);
        byte[] UTF8bytes = new byte[20];
        byte[] send_c3 = new byte[200];
        byte[] revData = new byte[50];
        ushort Send_CRC ;
        private string usartPortNum = "";//用来保留控件上的串口号
        int RX_DATA=10;
        int set_voltage_flag = 0;
       WriteProtocol  writeCommand = new WriteProtocol();
       // UTF8bytes[]={0x12};
      // string s = "12";
        public MainForm()
        {
           InitializeComponent();

           serialPort1.ReadTimeout = 2000;
            
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//委托一个接收处理事件
           // 
           

            serialPort1.Encoding = Encoding.GetEncoding("gb2312");//串口接收编码GB2312码
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//忽略程序跨越线程运行导致的错误.没有此句将会产生错误
        }
        public void DisplayText(Byte[] buffer)
        {
            textBox1.Text += String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine);
            //totalLength = totalLength + buffer.Length;
            //Label2.Text = totalLength.ToString();
        }
        private void port_DataReceived()//串口数据接收事件
        {
            Boolean readingFromBuffer;
            Int32 count = 0;

            while (receiving)
            {
                readingFromBuffer = true;

               // if (serialPort1.IsOpen)
              //  {
                    if (serialPort1.BytesToRead > 0)
                    {
                        //    byte[] revData = new byte[serialPort1.BytesToRead];
                        //    //while (serialPort1.BytesToRead < revData.Length && count < 501)
                        //    //while (serialPort1.BytesToRead < revData.Length )
                        //    //{
                        //     Thread.Sleep(3);
                        //    //    count++;
                        //    //    if (count > 500)
                        //    //    {
                        //    //        readingFromBuffer = false;
                        //    //    }
                        //    //}
                        //    Int32 length = serialPort1.Read(revData, 0,10);
                        //    Array.Resize(ref revData, 10);
                        //    //Array.Resize(ref buffer, length);


                        //  //  count = 0;
                    }
                    Thread.Sleep(16);
                    //    if (readingFromBuffer)
                    //    {
                    //        Int32 length = serialPort1.Read(revData, 0, revData.Length);
                    //        Display d = new Display(DisplayText);
                    //        this.Invoke(d, new Object[] { revData });
                    //    }
                    //    else
                    //    {
                    //        serialPort1.DiscardInBuffer();
                    //    }

                    //    Thread.Sleep(16);


                    //    // Int32 length = (sender as SerialPort).


                    //    // Array.Resize(ref revData, length);

                    //    //foreach (byte i in revData)//顯示到 text
                    //    //{
                    //    //    string str = i.ToString("X").ToUpper();//以十六进制字符串形式显示
                    //    //    receiveBox.AppendText((str.Length == 2 ? str : "0" + str) + " ");
                    //    //}


                    //}

               // }

            }
        }
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            //if (sendBox.Text != "")
            //{
            //    //if (checkGb2312ToUtf8.Checked || checkUtf8ToGb2312.Checked)//选择了数据转换功能
            //    //{
            //    //    sendButton.Text = "点击转换";
            //    //    if (checkGb2312ToUtf8.Checked)
            //    //    {                         
            //    //        try
            //    //        {
            //    //            //receiveBox.Text = "";
            //    //            string mystr = sendBox.Text;
            //    //            mystr = mystr.Replace("0X", string.Empty);//去掉所有“OX”
            //    //            mystr = mystr.Replace(" ", string.Empty);//去掉所有“ ”
            //    //            byte[] myBytes = new byte[mystr.Length / 2];
            //    //            for (int i = 0; i < mystr.Length / 2; i++)
            //    //            {
            //    //                myBytes[i] = Convert.ToByte(mystr.Substring(i * 2, 2), 16);//转换为以十六进制显示的整数形式
            //    //            }
            //    //            string str = BytesToString(myBytes);
            //    //            receiveBox.Text += str;

            //    //        }
            //    //        catch
            //    //        {
            //    //            MessageBox.Show("数据转换错误，请输入数据", "错误");
            //    //        }
                            
            //    //    }
            //    //    else if (checkUtf8ToGb2312.Checked)
            //    //    {

            //    //        //receiveBox.Text = "";
            //    //        string str = sendBox.Text;
            //    //        byte[] myBytes = StringToBytes(str);
            //    //        foreach (byte myByte in myBytes)
            //    //        {
            //    //            string mystr = myByte.ToString("X").ToUpper();
            //    //            receiveBox.Text += "0X" + (mystr.Length == 1 ? "0" + mystr : mystr) + " ";
            //    //        }
                            
            //    //    }
            //    //}
            //    //else //直接数据发送模式
            //    //{
            //        sendButton.Text = "發送數據";
            //        if (serialPort1.IsOpen)
            //        {
            //            //if (!checkHexSend.Checked)//字符串方式发送
            //            //{
            //            //    if (checkTXNewLine.Checked)
            //            //        serialPort1.WriteLine(sendBox.Text);
            //            //    else
            //            //        serialPort1.Write(sendBox.Text);
            //            //}
            //            //else//Hex方式发送
            //            //{
            //                //byte[] data = new byte[] { 0x0D, 0x0A };
            //               // string mystr = sendBox.Text;
            //                //mystr = mystr.Replace("0X", string.Empty);//去掉所有“OX”
            //                //mystr = mystr.Replace(" ", string.Empty);//去掉所有“ ”
            //                //byte[] myBytes = new byte[s.Length / 2];//去掉最后的奇数 如0A 06 8。将去掉末尾的8
            //                //for (int i = 0; i < s.Length ; i++)
            //                //{
            //                //   // myBytes[i] = Convert.ToByte(s.Substring(i * 2, 2), 16);
                               
            //                //   // UTF8bytes = Encoding.UTF16.GetBytes(s);
            //                //    UTF8bytes = Encoding.UTF8.GetBytes(s);
            //                //    //UTF8bytes =Convert.ToInt32(UTF8bytes[0]);

            //                //    UTF8bytes[i] =(byte)( UTF8bytes[i]-48);

            //                //}
            //                /*if (checkNewLine.Checked)
            //                {
            //                    serialPort1.Write(myBytes, 0, mystr.Length / 2);
            //                    serialPort1.Write(data, 0, 2);
            //                }
            //                else*/
            //           UTF8bytes[0]=0xAA;UTF8bytes[1]=0xB0;UTF8bytes[2]=0x00;UTF8bytes[3]=0x00;UTF8bytes[4]=0x20;
            //            Send_CRC = Rx_CRC_CCITT(UTF8bytes, 4);
            //             UTF8bytes[5] = (byte)(Send_CRC>>8&0xff);
            //             UTF8bytes[6] = (byte)(Send_CRC & 0xff);
                      
                        
            //            UTF8bytes[7] = 0xE4; UTF8bytes[8] = 0x1B; UTF8bytes[9] = 0x11; UTF8bytes[10] = 0xEE; 
            //            serialPort1.Write(UTF8bytes, 0, 11);
            //            //}
            //        }
            //        else
            //        {
            //            MessageBox.Show("请检查串口的打开情况","提示");
            //        }
            //   // }
            //}
            
        }

        public void SendData(Object sendBuffer)
        {
           if (sendBuffer != null)
            {
                Byte[] buffer = sendBuffer as Byte[];
                 serialPort1.Write(buffer, 0, buffer.Length);
                // Usart1.MainForm. 

                //try
                //{
                //    sending = true;


                //.Write(buffer, 0, buffer.Length);
                //    receiving = true;
                //    Thread.Sleep(200);
                //    DoReceive();
                //}
                //catch (Exception ex)
                //{
                //    //這邊你可以自訂發生例外的處理程序
                //    CloseComport();
                //    MessageBox.Show(String.Format("出問題啦:{0}", ex.ToString()));
                //}
                //finally
                //{
                //    sending = false;
                //}
            }
        }





 public  ushort Rx_CRC_CCITT( byte[] puchMsg, int usDataLen)        // 生成CRC
{
	 int j=0;
	 ushort wCRCin = 0x0000;
	 ushort wCPoly = 0x1021;
     ushort andcode = 0x8000;
	 byte wChar = 0;
    // bool tr;
     ushort tr;
     int DataLen;

     DataLen=usDataLen;
     while (usDataLen!=0)
	{
       
        for (j = 0; j < DataLen;j++ )
        {
            usDataLen--;
            wChar = (puchMsg[j + 1]);//第二個開始算
            wCRCin ^= (ushort)(wChar << 8);
            // wCRCin ^=(wChar << 8);
            //wCRCin ^= (0x00);
            for (int i = 0; i < 8; i++)
            {
                tr = (ushort)(wCRCin & andcode);

                if ((tr) == 0x8000)
                    wCRCin = (ushort)((wCRCin << 1) ^ wCPoly);
                else
                    wCRCin = (ushort)(wCRCin << 1);
            }
        }
	}
	return (wCRCin);
}
       



public void usartButton_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)//没有打开
            {
                if (comSelect.Text != "")
                    serialPort1.PortName = comSelect.Text;
                else
                {
                    MessageBox.Show("请选择串口端口号", "提示");
                    return;
                }

                if (bpsSelect.Text != "")
                    serialPort1.BaudRate = Convert.ToInt32(bpsSelect.Text);
                else
                {
                    MessageBox.Show("请选择波特率", "提示");
                    return;
                }
                try
                {
                    serialPort1.Open();
                    serialPort1.DataBits = Convert.ToInt32(dataBitSelect.Text);
                    //serialPort1.StopBits = Convert.ToInt32(stopBitSelect.Text);
                    receiving = true;
                    comSelect.Enabled = false;
                    bpsSelect.Enabled = false;
                    dataBitSelect.Enabled = false;
                    stopBitSelect.Enabled = false;
                    chickBitSelect.Enabled = false;
                    flowControlSelect.Enabled = false;
                   // checkGb2312ToUtf8.Enabled = false;
                    //checkUtf8ToGb2312.Enabled = false;
                    usartButton.Text = "关闭串口";
                    //if (checkTiming.Checked)
                    //{
                    //    checkTiming.Checked = false;
                    //    checkTiming.Checked = true;//重启一下 以便触发定时发送事件
                    //}
                }
                catch
                {
                    serialPort1.Close();
                    MessageBox.Show("串口打开失败", "提示");
                }
            }
            else//关闭
            {
                try
                {
                    serialPort1.Close();
                    if (timer1.Enabled)
                    {
                        timer1.Stop();
                    }
                    comSelect.Enabled = true;
                    bpsSelect.Enabled = true;
                    dataBitSelect.Enabled = true;
                    stopBitSelect.Enabled = true;
                    chickBitSelect.Enabled = true;
                    flowControlSelect.Enabled = true;
                    //checkGb2312ToUtf8.Enabled = true;
                    //checkUtf8ToGb2312.Enabled = true;
                    //usartButton.Text = "打开串口";
                    //if (checkTiming.Checked)
                    //{
                    //    checkTiming.Checked = false;
                       
                    //}

                }
                catch
                 {
                    MessageBox.Show("串口关闭失败", "提示");
                } 
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            receiveBox.Clear();
        }

        

        /// <summary>
        /// 选择可用的串口号并添加到下拉列表
        /// </summary>
        /// <param name="mySerialPort"></param>
        /// <param name="myComboBox"></param>
        private void selectAndAddComport(SerialPort mySerialPort, ComboBox myComboBox)
        {
            string selectCom;
            if (comSelect.Text != "")//鼠标进入时保留控件上的端口号
            {
                usartPortNum = comSelect.Text;
                comSelect.Text = "";
            }
            comSelect.Items.Clear();
            for (int i = 1; i <= 40; i++)
            {
                selectCom = "COM" + i.ToString();
                mySerialPort.PortName = selectCom;
                try
                {
                    mySerialPort.Open();
                    comSelect.Items.Add(selectCom);
                    mySerialPort.Close();
                }
                catch
                {
                }
            }
            



        }


        /// <summary>
        /// 鼠标离开串口选择下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comSelect_MouseLeave(object sender, EventArgs e)
        { 
            if (comSelect.Text == "")//之前没有文本
            {
                if (usartPortNum == "")//检查上次的端口也是空
                {
                    if (comSelect.Items.Count > 0)//判断列表中有选项
                        comSelect.Text = Convert.ToString(comSelect.Items[0]);//选择最小的那个端口号
                    else
                        comSelect.Text = "";
                }
                else//上次的端口不是空的
                {
                    if (comSelect.Items.Count == 0)//本次已经没有端口
                    {
                        comSelect.Text = "";
                    }
                    else//这里面好像存在BUG
                    {
                        foreach (string str in comSelect.Items)//检查上次的端口是否依然存在列表中
                        {
                            if (str != usartPortNum)
                            {
                                continue;
                            }
                            else
                            {
                                comSelect.Text = usartPortNum;
                                break;
                            }
                        }
                        if (comSelect.Text == "")//循环结束都没有匹配到
                        {
                            if (comSelect.Items.Count > 0)//判断列表中的选项
                                comSelect.Text = Convert.ToString(comSelect.Items[0]);
                            else
                                comSelect.Text = "";
                        }
                    }
                }
            }
            else//之前有文本
            {
                //if(comSelect.Items.Count)
                //不必判断端口是否存在，因为刚刚刷新过
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            writeCommand = new WriteProtocol();
            readResponse = new ReadProtocol();

            bool selectOK = false;
            GetPrivateProfileString("PortSet", "PortNum", "COM1", savePort, 255,FileName);
            GetPrivateProfileString("PortSet", "PortBps", "115200", saveBps, 255, FileName);
            GetPrivateProfileString("PortSet", "PortDataBit", "8", saveDataBit, 8, FileName);
            GetPrivateProfileString("PortSet", "PortStopBit", "1", saveStopBit, 8, FileName);
            GetPrivateProfileString("PortSet", "PortChickBit", "None", saveChickBit, 8, FileName);
            GetPrivateProfileString("PortSet", "PortFlowControl", "None", saveFlowControl, 8, FileName);
            selectAndAddComport(serialPort1, null);//自动搜索端口号并添加到列表中
            foreach(string str in comSelect.Items)//遍历列表中是否有ini文件中保留的端口号
            {
                if (str == savePort.ToString())
                {
                    comSelect.Text = str;
                    selectOK = true;
                }
            }
            //if (!serialPort1.IsOpen)
            // {
            //   serialPort1.Open();
           
            //Thread t = new Thread(port_DataReceived);
            //t.IsBackground = true;
            //t.Start();
          
            //}

            if (selectOK == false)//可用端口中没有匹配到ini文件中的端口
            {
                if (comSelect.Items.Count > 0)//选择一个最小的有效端口号
                {
                    comSelect.Text = Convert.ToString(comSelect.Items[0]);
                    bpsSelect.Text = "115200";




                }
                else
                {
                    comSelect.Text = "";
                    

                }
            }

           


            bpsSelect.Text = saveBps.ToString();
            dataBitSelect.Text = saveDataBit.ToString();
            stopBitSelect.Text = saveStopBit.ToString();
            chickBitSelect.Text = saveChickBit.ToString();
            flowControlSelect.Text = saveFlowControl.ToString();






        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("PortSet", "PortNum", comSelect.Text, FileName);//将当前端口号写入ini文件
            WritePrivateProfileString("PortSet", "PortBps", bpsSelect.Text, FileName);//将当前波特率写入ini文件
            WritePrivateProfileString("PortSet", "PortDataBit", dataBitSelect.Text, FileName);
            WritePrivateProfileString("PortSet", "PortStopBit", stopBitSelect.Text, FileName);
            WritePrivateProfileString("PortSet", "PortChickBit", chickBitSelect.Text, FileName);
            WritePrivateProfileString("PortSet", "PortFlowControl", flowControlSelect.Text, FileName);
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkHexSend_Click(object sender, EventArgs e)
        {

            //if(checkHexSend.Checked)
            //{
            //    //if (sendBox.Text != "")
            //    //{
            //    //    foreach (char str in sendBox.Text)
            //    //    {
            //    //        if ((str >= '0' && str <= '9') || (str >= 'a' && str <= 'f') || (str >= 'A' && str <= 'F') || (str == ' '))
            //    //        {
            //    //            continue;
            //    //        }
            //    //        else
            //    //        {
            //    //            timer1.Stop();
            //    //            if (checkTiming.Checked == true)
            //    //            {
            //    //                checkTiming.Checked = false;
            //    //                checkHexSend.Checked = false;
            //    //            }
                               
            //    //            MessageBox.Show("请输入有效的HEX字符'0-9' 'a-f' 'A-F'或者' '\r\n每两个字符之间空一个空格，结尾不要是单个字符", "提示");
            //    //            sendBox.Clear();
            //    //            break;
            //    //        }
            //    //    }
            //    //}
            //}
        }

        private void sendBox_TextChanged(object sender, EventArgs e)
        {
            //if (checkHexSend.Checked == true)
            //{
            //    if (sendBox.Text != "")
            //    {
            //        for (int i = 0; i < sendBox.TextLength; i++)
            //        {
            //            char myChar = sendBox.Text[i];
            //            if (((myChar >= '0' && myChar <= '9') || (myChar >= 'a' && myChar <= 'f') || (myChar >= 'A' && myChar <= 'F') || (myChar == ' ')))
            //            {
            //                //其实可以试试使用MaskedTextBox,
            //            }
            //            else
            //            {
            //                MessageBox.Show("请输入有效的HEX字符'0-9' 'a-f' 'A-F'或者' '\r\n每两个字符之间空一个空格，结尾不要是单个字符", "提示");
            //                sendBox.Text = sendBox.Text.Substring(0, i);//将再一次引发本函数
            //                sendBox.Focus();
            //                sendBox.SelectionStart = sendBox.Text.Length;//获取焦点并使焦点在最右边   
            //                return;
            //            }
            //        }
            //    }
            //}
        }

        //private bool someOfPackageEnable(object sender, EventArgs e)
        //{
        //    //if ((checkUtf8ToGb2312.Checked == false) && (checkGb2312ToUtf8.Checked == false))
        //    //{
        //    //    checkHexShow.Enabled = true;
        //    //    checkHexSend.Enabled = true;
        //    //    checkTXNewLine.Enabled = true;
        //    //    checkTiming.Enabled = true;
        //    //    timeBox.Enabled = true;
        //    //    sendButton.Text = "发送数据";
        //    //    usartButton.Enabled = true;
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    usartButton.Enabled = false;
        //    //    //if (serialPort1.IsOpen)//任何一个被选中都需要将串口断开连接
        //    //    //{
        //    //    //    serialPort1.Close();
        //    //    //    usartButton.Text = "打开串口";
        //    //    //}
        //    //    return false;
        //    //}
                
        //}
        private void checkUtf8ToGb2312_Click(object sender, EventArgs e)
        {
            //if (checkGb2312ToUtf8.Checked == true)
            //{
            //    checkGb2312ToUtf8.Checked = false;
            //}
            //if (someOfPackageEnable(sender, e) == true)
            //    return;
            //else
            //{

            //    checkHexShow.Enabled = true;
            //    checkHexShow.Checked = true;
            //    checkHexShow.Enabled = false;

            //    checkHexSend.Enabled = true;
            //    checkHexSend.Checked = false;
            //    checkHexSend.Enabled = false;

            //    checkTXNewLine.Enabled = false;
            //    checkTiming.Enabled = false;
            //    timeBox.Enabled = false;
            //    sendButton.Text = "点击转换";
            //}
        }

        private void checkGb2312ToUtf8_Click(object sender, EventArgs e)
        {

            //if (checkUtf8ToGb2312.Checked == true)
            //{
            //    checkUtf8ToGb2312.Checked = false;
            //}
            //if (someOfPackageEnable(sender, e) == true)
            //    return;
            //else
            //{
            //    checkHexShow.Enabled = true;
            //    checkHexShow.Checked = false;
            //    checkHexShow.Enabled = false;

            //    checkHexSend.Enabled = true;
            //    checkHexSend.Checked = true;
            //    checkHexSend.Enabled = false;

            //    checkTXNewLine.Enabled = false;
            //    checkTiming.Enabled = false;
            //    timeBox.Enabled = false;
            //    sendButton.Text = "点击转换";
            //}
        }

        private void comSelect_Click(object sender, EventArgs e)
        {
            selectAndAddComport(serialPort1, comSelect);
        }

        private void checkTiming_CheckStateChanged(object sender, EventArgs e)
        {
            //if (checkTiming.Checked == true)
            //{
            //    if (timeBox.Text == "")
            //    {
            //        checkTiming.Checked = false;
            //        MessageBox.Show("请输入定时时间", "提示");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            Int32 value = Convert.ToInt16(timeBox.Text.Substring(0, timeBox.TextLength));
            //            timer1.Interval = value;
            //            if (serialPort1.IsOpen)
            //            {
            //                timer1.Start();
            //                sendButton.Enabled = false;
            //                timeBox.Enabled = false;
            //            }
            //            else
            //                sendButton.Enabled = true;
            //        }
            //        catch
            //        {
            //            timeBox.Text = "";
            //            //checkTiming.Checked = false;
            //            MessageBox.Show("输入数据不正确，请核对", "提示");
            //        }
            //    }
            //}
            //else
            //{
            //    timer1.Stop();
            //    sendButton.Enabled = true;
            //    timeBox.Enabled = true;
            //}
        }

        ////////////////////////////////////////////////////////////////
        //以下是关于UTF8和GB2312转换的函数
        ////////////////////////////////////////////////////////////////
        /// <summary>
        /// ///////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="theString"></param>
        /// <returns></returns>
        private byte[] StringToBytes(string theString)
        {
            Encoding fromEncoding = Encoding.GetEncoding("UTF-8");//定义utf8类型
            Encoding toEncoding = Encoding.GetEncoding("gb2312");//定义gb2312
            byte[] fromBytes = fromEncoding.GetBytes(theString);//将传入的utf8类型字符串转换为相应的字节序列
            byte[] toBytes = Encoding.Convert(fromEncoding, toEncoding, fromBytes);//将UTF8的字符序列转换成GB2312的字符序列
            return toBytes;
        }

        private string BytesToString(byte[] theBytes)
        {
            Encoding fromEncoding = Encoding.GetEncoding("gb2312");//定义GB2312类型
            Encoding toEncoding = Encoding.GetEncoding("UTF-8");//定义UTF8类型
            byte[] myBytes = Encoding.Convert(fromEncoding, toEncoding, theBytes);//将GB2312类型的字节转换成UTF8类型的字节
            string myString = toEncoding.GetString(myBytes);//将UTF8类型的字节转换成相应的字符串
            return myString;
        }

        private void checkTiming_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 显示接收时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkShowReTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowReTime.Checked == true)
            {
                //checkRXNewLine.Checked = true;
                //checkRXNewLine.Enabled = false;
            }
            else
            {
                //checkRXNewLine.Enabled = true;
            }
        }

        private void comSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkHexSend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiveBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

  

        }

        private void button2_Click(object sender, EventArgs e)
        {

            byte[] data = new byte[1];//data
            data[0] = 1;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.locker);


            Thread t = CreateThread();
            t.Start(UTF8bytes);
            //SendData(UTF8bytes);
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] data = new byte[1];//data
            data[0] = 0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.locker);
            SendData(UTF8bytes);

        }

        private void button4_Click(object sender, EventArgs e)
        {


            byte[] data = new byte[1];//data
            data[0] = 1;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.accelerate);
            SendData(UTF8bytes);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            if (onoff.SelectedIndex==0)
            data[0]=1;
            else
            data[0]=0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.voice);
            SendData(UTF8bytes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            if (onoff.SelectedIndex == 0)
                data[0] = 1;
            else
                data[0] = 0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.radar);
            SendData(UTF8bytes);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            if (onoff.SelectedIndex == 0)
                data[0] = 1;
            else
                data[0] = 0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.fingerprint);
            SendData(UTF8bytes);
        }

      

        private void button10_Click(object sender, EventArgs e)
        {
          


        }

        private void Power_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            data[0] =(byte) (power.SelectedIndex+1);
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.mode);
            SendData(UTF8bytes);
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
           double test_speed;
            
            byte[] data = new byte[3];//data
            speed=trackBar1.Value;
            data[0] = (byte)(speed % 255);
            data[1] = (byte)(speed/ 255);
            data[2] = battary;
            test_speed= data[1] * 255 + data[0];
            test_speed*= 0.1;
            label13.Text = test_speed.ToString();
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.Basic_inf);
            SendData(UTF8bytes);



        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            data[0]=0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.accelerate);
            SendData(UTF8bytes);
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[2];//data
            if (lamp.SelectedIndex == 0)
                data[0] = 0;
            else if (lamp.SelectedIndex == 1)
                data[0] = 1;
            else
                data[0] = 2;

            data[1] =0;//close
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.lamp);

            SendData(UTF8bytes);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[2];//

            if (lamp.SelectedIndex == 0)
                  data[0] = 0;
            else if (lamp.SelectedIndex == 1)
                  data[0] = 1;
            else
                 data[0] =2;

            data[1] = 1;//close
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.lamp);

            SendData(UTF8bytes);


        }

        private void button14_Click(object sender, EventArgs e)
        {
       
        }

        private void button17_Click(object sender, EventArgs e)
        {
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
      
        }

        private void button18_Click(object sender, EventArgs e)
        {
         
        }

        private void button19_Click(object sender, EventArgs e)
        {
         ;
        }
        
        private void button20_Click(object sender, EventArgs e)
        {
    
       }
    
        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
         

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            byte[] data = new byte[3];//data
            battary = (byte)(trackBar2.Value);
            data[0] = (byte)(speed % 255);
            data[1] = (byte)(speed / 255);
            data[2] = battary;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.Basic_inf);
            SendData(UTF8bytes);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[2];

            if (lamp.SelectedIndex == 0)
                data[0] = 0;
            else if (lamp.SelectedIndex == 1)
                data[0] = 1;
            else
                data[0] = 2;

            data[1] = 1;//open
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.lamp);

            SendData(UTF8bytes);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            data[0] = 1;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.fail);
            SendData(UTF8bytes);
        }

        private void button23_Click(object sender, EventArgs e)
        {
      
        }

        private void button25_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];//data
            data[0] = 0;
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.fail);
            SendData(UTF8bytes);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[2];

            if (lamp.SelectedIndex == 0)
                data[0] = 0;
            else if (lamp.SelectedIndex == 1)
                data[0] = 1;
            else
                data[0] = 2;

            data[1] = 2;//flash
            UTF8bytes = writeCommand.GetFullBytes(data, Protocol.CommandCode.lamp);

            SendData(UTF8bytes);
        }

        private void power_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private Thread CreateThread()
        {
            Thread t = new Thread(SendData);
            t.IsBackground = true;
            return t;
        }

        private void bpsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }







    abstract class Protocol
    {
        public enum CommandCode : byte
        {


            Status = 0,
            Basic_inf = 1,
            lamp = 2,
            locker = 3,
            fingerprint = 4,
            voice = 5,
            fail = 6,
            accelerate = 7,
            mode = 8,
            radar = 9,
            version = 10

        }

        public Byte Head
        { get { return 0x5a; } }//5a


        public Byte End
        { get { return 0xef; } }//5a


    }
    
    
    
    
    class WriteProtocol : Protocol
    {
      // SerialPort serialPort1; 
        public Thread CreateThread()
        {
            Thread t = new Thread(SendData);
            t.IsBackground = true;
            return t;
        }

        public void SendData(Object sendBuffer)
        {
            
            
            
            if (sendBuffer != null)
            {
                Byte[] buffer = sendBuffer as Byte[];
               // serialPort1.Write(buffer, 0, buffer.Length);
           // Usart1.MainForm. 

                //try
                //{
                //    sending = true;

             
                //.Write(buffer, 0, buffer.Length);
                //    receiving = true;
                //    Thread.Sleep(200);
                //    DoReceive();
                //}
                //catch (Exception ex)
                //{
                //    //這邊你可以自訂發生例外的處理程序
                //    CloseComport();
                //    MessageBox.Show(String.Format("出問題啦:{0}", ex.ToString()));
                //}
                //finally
                //{
                //    sending = false;
                //}
            }
        }



         public Byte GetLengthValue(Byte[] dataBytes)
        {
            if (dataBytes != null)
            {
                return ((Byte)(dataBytes.Length + 4));
            }
            else
            { return (Byte)4; }
        }


        public Byte[] GetFullBytes(Byte[] dataBytes, CommandCode command)
        {
            Byte lengthValue = GetLengthValue(dataBytes);
            Byte[] result = new Byte[lengthValue];
            result[0] = Head;
            result[1] = (Byte)(command);
            result[2] = (Byte)dataBytes.Length;
          //  result[2] = (Byte)Direction.PCToDevice;
           
            if (lengthValue > 0)
            {
                Array.Copy(dataBytes, 0, result, 3, dataBytes.Length);
            }
            result[result.Length - 1] =End;
            return result;
        }




    }

    class ReadProtocol : Protocol
    {
        private Int32 innerReceiveDataFullLength;
        private bool innerDataCheckedResult;
        private string innerDataCheckedMessage;
        private Byte[] innerResponseFullBytes;
        public delegate void DataCheckecdHandler(Boolean result, String checkedMessage);

        public event DataCheckecdHandler DataChecked;
        public delegate void ReceiveErrorDataHandler();

        public event ReceiveErrorDataHandler ReceiveErrorData;
        public delegate void ReceiveActionResultHandler(Boolean result, CommandCode command);

        public event ReceiveActionResultHandler ReceiveActionResult;
        public delegate void ReceiveReturnDataHandler(Byte[] content, CommandCode command);

        public event ReceiveReturnDataHandler ReceiveReturnData;

        private void GetReceiveDataFullLength(List<Byte> tempList)
        {
            if (tempList.Count >= 2 && innerReceiveDataFullLength == 0)
            {
                Int32 startIndex = tempList.IndexOf(Head);
                if (startIndex >= 0 && startIndex < tempList.Count - 1)
                {
                    innerReceiveDataFullLength = Convert.ToInt32(tempList[startIndex + 1]) + 2;
                }
            }
        }
        public Boolean DataCheckedResult
        {
            get { return innerDataCheckedResult; }
            private set
            {
                innerDataCheckedResult = value;
                DataChecked(innerDataCheckedResult, innerDataCheckedMessage);
            }
        }

        private Boolean GetFullReceiveData(List<Byte> tempList)
        {
            if (innerReceiveDataFullLength > 0 && tempList.Count >= tempList.IndexOf(Head) + innerReceiveDataFullLength)
            {
                Byte[] temp = new Byte[innerReceiveDataFullLength];
                Array.Copy(tempList.ToArray(), tempList.IndexOf(Head), temp, 0, temp.Length);
               innerResponseFullBytes = temp;
                //InterpretReceiveData();
                innerReceiveDataFullLength = 0;
                return true;
            }
            else
            { return false; }
        }

        public Boolean ArrangeReceiveData(List<Byte> tempList)
        {
            if (innerReceiveDataFullLength == 0)
            {
                GetReceiveDataFullLength(tempList);
                return GetFullReceiveData(tempList);
            }
            else
            {
                return GetFullReceiveData(tempList);
            }
        }



        //private void InterpretReadBlock()
        //{
        //    Byte[] content = new Byte[innerResponseContentLength];
        //    Array.Copy(innerResponseFullBytes, 4, content, 0, content.Length);
        //    ReceiveReturnData(content, innerResponseCommand);
        //}

        private void InterpretReceiveData()
        {
            if (CheckData())
            {
                //innerResponseCommand = (CommandCode)innerResponseFullBytes[3];
                //switch (innerResponseCommand)
                //{
                //    case CommandCode.ReadBlock:
                //        InterpretReadBlock();
                //        break;
                //    case CommandCode.WriteBlock:
                //        ReceiveActionResult(Convert.ToBoolean(innerResponseFullBytes[4]), innerResponseCommand);
                //        break;
                //    case CommandCode.LightControl:
                //        ReceiveActionResult(Convert.ToBoolean(innerResponseFullBytes[4]), innerResponseCommand);
                //        break;
                //    case CommandCode.DataError:
                //        ReceiveErrorData();
                //        break;
                //    default:
                //        throw new ArgumentOutOfRangeException();
                //}
            }
        }
        private Boolean CheckData()
        {
            if (innerResponseFullBytes != null)
            {
                DataCheckedResult = CheckHead();
            }
            else
            {
                innerDataCheckedMessage = "無回傳資料";
                DataCheckedResult = false;
            }
            return DataCheckedResult;
        }

        private Boolean CheckHead()
        {
            if (innerResponseFullBytes[0] == Head)
            {
                return CheckLength();
            }
            else
            {
                innerDataCheckedMessage = "開頭碼錯誤";
                return false;
            }
        }
        private Boolean CheckLength()
        {
            if (innerResponseFullBytes.Length - 2 == innerResponseFullBytes[1])
            {
             //  nnerResponseContentLength = innerResponseFullBytes.Length - 5; //減去開頭, 長度, 接收者, 命令, XOR
                return true;
            }
            else
            {
                innerDataCheckedMessage = "長度錯誤";
                return false;
            }
        }


        private void ReadResponse_DataChcked(Boolean result, String checkedMessage)
        {
            if (!result)
            {
                MessageBox.Show(String.Format("{0}:{1}", "資料檢查錯誤", checkedMessage));
            }
        }

        private void ReadResponse_ReceiveErrorData()
        {
            MessageBox.Show("傳輸的資料無法判讀");
        }

        private void ReadResponse_ReceiveActionResult(Boolean result, Protocol.CommandCode command)
        {
            String resultString;
            if (result)
            { resultString = "成功"; }
            else
            { resultString = "失敗"; }
            MessageBox.Show(String.Format("命令{0}:{1}", command, resultString));
        }

        //private void ReadResponse_ReceiveReturnData(Byte[] content, Protocol.CommandCode command)
        //{
        //    ShowBlockMethod d = ShowBlockData;
        //    this.Invoke(d, new Object[] { content });
        //}

        //private void ShowBlockData(Byte[] content)
        //{
        //    Byte[] dataBytes = new Byte[16];
        //    Array.Copy(content, 1, dataBytes, 0, dataBytes.Length);
        //    TextBox1.Text = BitConverter.ToString(dataBytes).Replace("-", "");
        //}



    }





}
