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
using ZedGraph;
using System.IO;

namespace DLCN
{
    public partial class Form1 : Form
    { private string data;
        private string dataIn;
        private string data1;
        private string data2;
        private string dataIT; // nhận khi ngắt, ấn button
        private float tem1;
        private float tem2;
        private int count = 0;
        private string txData;
        public Form1()
        {
            InitializeComponent();
        }
        string[] pause = { "1200", "2400", "4800", "9600", "19200", "38400" };
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listnamecom = SerialPort.GetPortNames();
            listcom.Items.AddRange(listnamecom);
            listbaud.Items.AddRange(pause);
            rad5s.Checked = true;
            updown1.Value = 40;
            updown2.Value = 30;
            updown3.Value = 40;
            updown4.Value = 30;
            



        }

        private void listCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listcom.Text == "")
            {
                MessageBox.Show("bạn chưa chọn cổng Com", "thông báo");
            }
            else if ( listbaud.Text == "")
            {
                MessageBox.Show("bạn chưa chọn baudrate", "thông báo");
            }
            if (serialPort1.IsOpen== true)
            {
                serialPort1.Close();
                button1.Text = "CONNECT";
            }
            else if (serialPort1.IsOpen== false)
            {
                serialPort1.PortName = listcom.Text;
                serialPort1.BaudRate = int.Parse(listbaud.Text);
                serialPort1.Open();
                button1.Text = "DISCONNECT";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { if (rad5s.Checked == true)
            { serialPort1.Write(txtTruyen.Text); }
        else if (rad10s.Checked == true)
            { serialPort1.Write("@"); }    
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);

            dataIn = serialPort1.ReadExisting();

            this.Invoke(new EventHandler(Showdata));
            
        }
        private void Showdata (object sender, EventArgs e)
        {   if (dataIn == "a")
            {
                if (lblIT.BackColor == Color.Lime)
                {
                    lblIT.BackColor= Color.Red;
                }
                else lblIT.BackColor = Color.Lime;
            }
            else

                data = dataIn;
          
            data1 = data.Substring(0, 5);
            data2 = data.Substring(5);
            tem1 = float.Parse(data1);
            tem2 = float.Parse(data2);
            txtTruyen.Text = "REALTIME: Khu vực 1 = " + tem1 +"độ C; Khu vực 2 = " + tem2 + "độ C";
            if (tem1 >= (float)updown1.Value)
            {
                label5.BackColor = Color.Red;
            }
            else { label5.BackColor = Color.Green; }

            if (tem1 <= (float)updown2.Value)
            {
                label6.BackColor = Color.Red;
            }
            else { label6.BackColor = Color.Green; }

            if (tem2 >= (float)updown3.Value)
            {
                label7.BackColor = Color.Red;
            }
            else { label7.BackColor = Color.Green; }

            if (tem2 <= (float)updown4.Value)
            {
                label8.BackColor = Color.Red;
            }
            else { label8.BackColor = Color.Green; }
        }
        

        private void txtTruyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void chklbTinhnang(object sender, EventArgs e)
        {

        }

        private void radNhietdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rad10s.Checked == true)
            {
                timer2.Enabled = true;
            }
            else timer2.Enabled = false;
        }

        private void radTruyenNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (rad5s.Checked == true)
            {
                timer1.Enabled = true;
            }
            else timer1.Enabled = false;
        }

        private void grpTinhNang_Enter(object sender, EventArgs e)
        {

        }

        private void txtNhan(object sender, EventArgs e)
        {

        }

        private void lblNhan_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                lblNhan.Text = "nhiệt độ là " + this.data1 + " độ C";
                lblNhan2.Text = "nhiệt độ là  " + this.data2 + " độ C";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                lblNhan.Text = "nhiệt độ là  " + this.data1 + " độ C";
                lblNhan2.Text = "nhiệt độ là  " + this.data2 + " độ C";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                lblNhan.Text = "nhiệt độ là  " + this.data1 + " độ C";
                lblNhan2.Text = "nhiệt độ là  " + this.data2 + " độ C";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                lblNhan.Text = "nhiệt độ là " + this.data1 + " độ C";
                lblNhan2.Text = "nhiệt độ là  " + this.data2 + " độ C";
            }
        }

        private void rad30s_CheckedChanged(object sender, EventArgs e)
        {
            if (rad30s.Checked == true)
            {
                timer3.Enabled = true;
            }
            else
                timer3.Enabled = false;
        }

        private void rad1p_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1p.Checked == true)
            {
                timer4.Enabled = true;
            }
            else
                timer4.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (updown4.Value >= updown3.Value)
            {
                updown4.Value = (updown3.Value - 1);
                MessageBox.Show("Mời nhập lại");
            }
        }

        private void updown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updown1_ValueChanged_1(object sender, EventArgs e)
        {
            if( updown1.Value <= updown2.Value)
            {
                updown1.Value = (updown2.Value + 1);
                MessageBox.Show("Mời nhập lại");
            }    
        }

        private void updown2_ValueChanged_1(object sender, EventArgs e)
        {
            if (updown2.Value >= updown1.Value)
            {
                updown2.Value = (updown1.Value - 1);
                MessageBox.Show("Mời nhập lại");
            }
        }

        private void updown3_ValueChanged(object sender, EventArgs e)
        {
            if (updown3.Value <= updown4.Value)
            {
                updown3.Value = (updown4.Value + 1);
                MessageBox.Show("Mời nhập lại");
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString()+ "_____"+ DateTime.Now.ToString("dd/ MM/ yyyy");
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {   
                if (label5.BackColor == Color.Red) 
                {
                  FileStream fs = new FileStream("warning.txt",FileMode.Append,FileAccess.Write);
                    StreamWriter sWriter = new StreamWriter(fs);
                    sWriter.Write("cảnh báo nhiệu độ CAO_KHU VỰC 1: " + DateTime.Now.ToLongTimeString() +"___"+DateTime.Now.ToString("dd/ MM/ yyyy") + Environment.NewLine);
                    sWriter.Flush();
                    fs.Close();
                    
                }
                if (label6.BackColor == Color.Red)
                {
                    FileStream fs = new FileStream("warning.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sWriter = new StreamWriter(fs);
                    sWriter.Write("cảnh báo nhiệu độ THẤP_KHU VỰC 1: " + DateTime.Now.ToLongTimeString() +"___"+ DateTime.Now.ToString("dd/ MM/ yyyy") + Environment.NewLine);
                    sWriter.Flush();
                    fs.Close();
                }


                if (label7.BackColor == Color.Red)
                {
                    FileStream fs = new FileStream("warning.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sWriter = new StreamWriter(fs);
                    sWriter.Write("cảnh báo nhiệu độ CAO_KHU VỰC 2: " + DateTime.Now.ToLongTimeString() + "___" + DateTime.Now.ToString("dd/ MM/ yyyy") + Environment.NewLine);
                    sWriter.Flush();
                    fs.Close();

                }
                if (label8.BackColor == Color.Red)
                {
                    FileStream fs = new FileStream("warning.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sWriter = new StreamWriter(fs);
                    sWriter.Write("cảnh báo nhiệu độ THẤP_KHU VỰC 2: " + DateTime.Now.ToLongTimeString() + "___" + DateTime.Now.ToString("dd/ MM/ yyyy") + Environment.NewLine);
                    sWriter.Flush();
                    fs.Close();
                }



            }    
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen== true)
            {
                if (count % 2 ==0)
                { 
                if (label5.BackColor== Color.Red)
                    { txData = "1"; }    
                else if (label6.BackColor == Color.Red)
                    { txData = "2"; }
                else { txData = "3"; }
                    serialPort1.Write(txData);
                }
                else
                {
                    if (label7.BackColor == Color.Red)
                    { txData = "4"; }
                    else if (label8.BackColor == Color.Red)
                    { txData = "5"; }
                    else { txData = "6"; }
                    serialPort1.Write(txData);
                } 
                count++;
                
                    

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
