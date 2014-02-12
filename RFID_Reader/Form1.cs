using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RFID_Reader
{
    public partial class Form1 : Form
    {
        private byte[] StrToByetArray(string hexValues)
        {
            string[] hexValuesSplit = hexValues.Split(' ');
            byte[] retBytes = new byte[hexValuesSplit.Length];

            for (int nLoop = 0; nLoop < retBytes.Length; nLoop++)
            {
                retBytes[nLoop] = Convert.ToByte(hexValuesSplit[nLoop], 16);
            }

            return retBytes;
        }

        private byte[] StrToByetArray(string[] hexValues, int nLen)
        {
            byte[] retBytes = new byte[nLen];

            for (int nLoop = 0; nLoop < retBytes.Length; nLoop++)
            {
                retBytes[nLoop] = Convert.ToByte(hexValues[nLoop], 16);
            }

            return retBytes;
        }

        private string ByteArrayToStr(byte[] byteArray, bool bNeedFormat, int nStart, int nEnd)
        {
            string strReturn = "";

            if (bNeedFormat)
            {
                strReturn = "\r\nHEX RESULT:";
            }

            int nLoop = 0;
            nLoop += nStart;
            if (nEnd == 0)
            {
                nEnd = byteArray.GetLength(0);
            }
            else if (nEnd > byteArray.GetLength(0))
            {
                nEnd = byteArray.GetLength(0);
            }


            for (; nLoop < nEnd; nLoop++)
            {
                string strHex = "";

                if (bNeedFormat)
                {
                    if (nLoop % 16 != 0)
                    {
                        strHex = string.Format(" {0:X2}", byteArray[nLoop]);
                    }
                    else
                    {
                        strHex = string.Format("\r\n  {0:X2}...{1:X2}", nLoop / 16, byteArray[nLoop]);
                    }
                }
                else
                {
                    strHex = string.Format(" {0:X2}", byteArray[nLoop]);
                }

                strReturn += strHex;
            }

            return strReturn;
        }

        private string FormatErrorCode(byte[] byteArray)
        {
            string strErrorCode = "";
            switch (byteArray[0])
            {
                case 0x80:
                    strErrorCode = "Success";
                    break;

                case 0x81:
                    strErrorCode = "Parameter Error";
                    break;

                case 0x82:
                    strErrorCode = "communication TimeOut";
                    break;

                case 0x83:
                    strErrorCode = "Couldn't Find Card ";
                    break;

                default:
                    strErrorCode = "Commond Error";
                    break;
            }

            return strErrorCode;
        }

        private string[] strCutLength(string str, int iLength)
        {
            string[] reslut = null;
            if (!string.IsNullOrEmpty(str))
            {
                int iTemp = 0;
                string strTemp = null;
                System.Collections.ArrayList strArr = new System.Collections.ArrayList();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        iTemp++;
                        strTemp += str.Substring(i, 1);
                    }

                    System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^(([A-F])*(\d)*)$");
                    if (!reg.IsMatch(strTemp))
                    {
                        return reslut;
                    }

                    if ((iTemp == iLength) || (i == str.Length - 1 && !string.IsNullOrEmpty(strTemp)))
                    {
                        strArr.Add(strTemp);
                        iTemp = 0;
                        strTemp = null;
                    }
                }
                if (strArr.Count > 0)
                {
                    reslut = new string[strArr.Count];
                    strArr.CopyTo(reslut);
                }
            }
            return reslut;
        }

        private void WriteLog(string strText, int nRet, string strErrcode)
        {
            if (nRet != 0)
            {

                textResponse.Text += System.DateTime.Now.ToLocalTime().ToString() + " " + strText + "\r\n" + strErrcode + "\r\n";
            }
            else
            {
                textResponse.Text += System.DateTime.Now.ToLocalTime().ToString() + " " + strText + " " + "\r\n";
            }

            textResponse.Select(textResponse.TextLength, 0);
            textResponse.ScrollToCaret();
        }

        private byte[] convertSNR(string str, int keyN)
        {
            string regex = "[^a-fA-F0-9]";
            string tmpJudge = Regex.Replace(str, regex, "");

            if (tmpJudge.Length != 12) return null;

            string[] tmpResult = Regex.Split(str, regex);
            byte[] result = new byte[keyN];
            int i = 0;
            foreach (string tmp in tmpResult)
            {
                result[i] = Convert.ToByte(tmp, 16);
                i++;
            }
            return result;
        }

        private string formatStr(string str, int num_blk)
        {

            string tmp = Regex.Replace(str, "[^a-fA-F0-9]", "");
            if (num_blk == -1) return tmp;
            if (num_blk < -1)
            {
                if (tmp.Length != -16 / num_blk * 2) return null;
                else return tmp;
            }
            if (tmp.Length != 16 * num_blk * 2) return null;
            else return tmp;
        }
        private void convertStr(byte[] after, string before, int length)
        {
            for (int i = 0; i < length; i++)
            {
                after[i] = Convert.ToByte(before.Substring(2 * i, 2), 16);
            }
        }

        private void showData(string text, byte[] data, int s, int e)
        {
            for (int i = 0; i < e; i++)
            {
                if (data[s + i] < 0)
                    data[s + i] = Convert.ToByte(Convert.ToInt32(data[s + i]) + 256);
            }
            textResponse.Text += text;

            for (int i = 0; i < e; i++)
            {
                textResponse.Text += data[s + i].ToString("X2") + " ";
            }
            textResponse.Text += "\r\n\r\n";

        }

        private void showStatue(int Code)
        {
            string msg = "";
            switch (Code)
            {
                case 0x00:
                    msg = "Command succeed.....";
                    break;
                case 0x01:
                    msg = "Command failed.....";
                    break;
                case 0x02:
                    msg = "Checksum error.....";
                    break;
                case 0x03:
                    msg = "Not selected COM port.....";
                    break;
                case 0x04:
                    msg = "Reply time out.....";
                    break;
                case 0x05:
                    msg = "Check sequence error.....";
                    break;
                case 0x07:
                    msg = "Check sum error.....";
                    break;
                case 0x0A:
                    msg = "The parameter value out of range.....";
                    break;
                case 0x80:
                    msg = "Command OK...";
                    break;
                case 0x81:
                    msg = "Command FAILURE.....";
                    break;
                case 0x82:
                    msg = "Reader reply time out error.....";
                    break;
                case 0x83:
                    msg = "The card does not exist.....";
                    break;
                case 0x84:
                    msg = "The data is error.....";
                    break;
                case 0x85:
                    msg = "Reader received unknown command.....";
                    break;
                case 0x87:
                    msg = "Error.....";
                    break;
                case 0x89:
                    msg = "The parameter of the command or the format of the command error.....";
                    break;
                case 0x8A:
                    msg = "Some error appear in the card InitVal process.....";
                    break;
                case 0x8B:
                    msg = "Get the wrong snr during anticollison loop.....";
                    break;
                case 0x8C:
                    msg = "The authentication failure.....";
                    break;
                case 0x8F:
                    msg = "Reader received unknown command.....";
                    break;
                case 0x90:
                    msg = "The card do not support this command.....";
                    break;
                case 0x91:
                    msg = "The foarmat of the command error.....";
                    break;
                case 0x92:
                    msg = "Do not support option mode.....";
                    break;
                case 0x93:
                    msg = "The block do not exist.....";
                    break;
                case 0x94:
                    msg = "The object have been locked.....";
                    break;
                case 0x95:
                    msg = "The lock operation do not success.....";
                    break;
                case 0x96:
                    msg = "The operation do not success.....";
                    break;
            }
            textResponse.Text += msg + "\r\n";
        }

        public Form1()
        {
            InitializeComponent();
            UL_readBlock.SelectedIndex = 0;
            UL_writeBlock.SelectedIndex = 0;
            readStart.SelectedIndex = 0;
            readNum.SelectedIndex = 0;
            readKey.SelectedIndex = 2;
            readAll.Checked = true;
            writeStart.SelectedIndex = 0;
            writeNum.SelectedIndex = 0;
            writeKey.SelectedIndex = 2;
            writeAll.Checked = true;
        }

        private void btn_ControlLED_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];

            int nRet = Reader.ControlLED(int.Parse(txt_LEDFREQ.Text), int.Parse(txt_LEDDURATION.Text), buffer);     
            showStatue(nRet);
            showStatue(buffer[0]);
        }

        private void btn_ControlBuzzer_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];

            int nRet = Reader.ControlBuzzer(int.Parse(txt_BUZZERFREQ.Text), int.Parse(txt_BUZZERDURATION.Text), buffer);
            showStatue(nRet);
            showStatue(buffer[0]);
        }

        private void btn_MF_Read_Click(object sender, EventArgs e)
        {
            byte mode1 = (readKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (readAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(readStart.Text, 16);
            byte num_blk = Convert.ToByte(readNum.Text, 16);
            byte[] snr = new byte[6];            

            snr = convertSNR(readKey.Text, 6);
            
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];

            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);

            showStatue(nRet);
            if (nRet != 0)
            {
                showStatue(buffer[0]);
            }
            else
            {
                showData("CardNumber: ", snr, 0, 4);
                showData("Data: ", buffer, 0, 16 * num_blk);
                
                // My Extra Codes Start
                byte[] mycard = new byte[6] { 77, 54, 11, 211, 255, 255 };
                mycard = convertSNR(readKey.Text, 6);

                bool mm = false;

                for (int i = 0; i < 6; i++) {
                    if (snr[i] == mycard[i]) {
                        mm = true;
                    }
                    else
                    {
                        mm = false;
                    }
                }

                if (mm)
                {
                    MessageBox.Show("Merhaba Emre");

                    Process myProcess = new Process();

                    try
                    {

                        myProcess.StartInfo.FileName = "C:\\Program Files (x86)\\Notepad++\\notepad++.exe";
                        
                        myProcess.Start();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                // My Extra Codes End
            }
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            textResponse.Text = "";
        }

        private void btn_MF_Write_Click(object sender, EventArgs e)
        {
            byte mode1 = (writeKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (writeAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(writeStart.Text, 16);
            byte num_blk = Convert.ToByte(writeNum.Text, 16);

            byte[] snr = new byte[6];            
            
            snr = convertSNR(writeKey.Text, 16);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];
            string bufferStr = formatStr(writeData.Text, num_blk);
            if (bufferStr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }
            convertStr(buffer, bufferStr, 16 * num_blk);

            int nRet = Reader.MF_Write(mode, blk_add, num_blk, snr, buffer);

            showStatue(nRet);
            if (nRet != 0)
            {
                showStatue(buffer[0]);
            }
            else
            {
                showData("CardNumber:", snr, 0, 4);
            }
        }

        private void btn_GetVersionNum_Click(object sender, EventArgs e)
        {
            byte[] byteArry = new byte[12];
            int nRet = Reader.GetVersionNum(byteArry);
            if (nRet != 0)
            {
                showStatue(byteArry[0]);
            }
            else
            {
                showData("VersionNum：", byteArry, 1, 11);
            }
        }

        private void btn_GetSerNum_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[9];
            int nRet = Reader.GetSerNum(buffer);

            showStatue(nRet);
            showData("SerialNum：", buffer, 1, 8);
        }

        private void btn_SetSerNum_Click(object sender, EventArgs e)
        {
            byte[] byteRet = new byte[1];
            //string strErrorCode = "";
            string[] reslut = strCutLength(txt_SetSerNum.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("The input is not valid！");
                return;
            }
            else if (reslut.GetLength(0) < 8)
            {
                MessageBox.Show("Please input 8 bytes！");
                return;
            }

            byte[] byteBuffer = StrToByetArray(reslut, 8);

            int nRet = Reader.SetSerNum(byteBuffer, byteRet);

            showStatue(nRet);
            showStatue(byteRet[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            byte mode1 = (readKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (readAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(readStart.Text, 16);
            byte num_blk = Convert.ToByte(readNum.Text, 16);
            byte[] snr = new byte[6];

            snr = convertSNR(readKey.Text, 6);

            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];

            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);

            if (nRet != 0)
            {
            }
            else
            {
                // My Extra Codes Start
                byte[] buffer2 = new byte[1];

                int nRet2 = Reader.ControlBuzzer(100, 1, buffer2);

                byte[] mycard = new byte[6] { 77, 54, 11, 211, 255, 255 };
                mycard = convertSNR(readKey.Text, 6);

                bool mm = false;

                for (int i = 0; i < 6; i++)
                {
                    if (snr[i] == mycard[i])
                    {
                        mm = true;
                    }
                    else
                    {
                        mm = false;
                    }
                }

                if (mm)
                {
                    timer1.Stop();
                    MessageBox.Show("Merhaba Emre");

                    Process myProcess = new Process();

                    try
                    {
                        myProcess.StartInfo.FileName = "C:\\Program Files (x86)\\Notepad++\\notepad++.exe";

                        myProcess.Start();                        
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                // My Extra Codes End
            }  
        }
    }
}
