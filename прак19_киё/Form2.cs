using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace прак19_киё
{
    public partial class Form2 : Form
    {
        Socket socket;
        private void SendToserver(string command)
        {
            byte[] data =Encoding.UTF8.GetBytes(command);
            socket.Send(data);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SendToserver("Отключение");
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                timer1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled =false;
                textBox5.AppendText("Отключение" + "\r" + "\n");
            }
            catch (Exception ex)
            {
                textBox5.AppendText(ex.Message + "\n");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(textBox1.Text, Int32.Parse(textBox2.Text));
                SendToserver("Клиент" + textBox3.Text);
                timer1.Enabled = true;
                textBox5.AppendText("Подключение к " + textBox1.Text + ":" + textBox2.Text + "\r" + "\n");
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                textBox5.AppendText(ex.Message + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SendToserver("Сообщение" + textBox4.Text);
                textBox5.AppendText( textBox3.Text + ":" + textBox4.Text + "\r" + "\n");
            }
            catch(Exception ex)
            {
                textBox5.AppendText(ex.Message + "\n");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if(socket.Available>0)
                {
                    byte[] data = new byte[socket.Available];
                    int data_size = socket.Receive(data);
                    string text_data = Encoding.UTF8.GetString(data, 0, data_size);
                    if(text_data.StartsWith("Новый клиен"))
                    {
                        textBox5.AppendText(text_data.Substring(11)+"в чата" + "\r" + "\n");
                    }
                    if (text_data.StartsWith("Отключение"))
                    {
                        textBox5.AppendText(text_data.Substring(11) + "вышел из чата" + "\r" + "\n");
                    }
                    if (text_data.StartsWith("Сообщение"))
                    {
                        textBox5.AppendText(text_data.Substring(21) + "\r" + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                textBox5.AppendText(ex.Message + "\n");
            }
        }
    }
}
