using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace прак19_киё
{
    public partial class Form1 : Form
    {
        class ClientInfo
        {
            public Socket socket;
            public string Neme;

            public override string ToString()
            {
                return Neme + "(" + socket.RemoteEndPoint + ")";
            }
        }
        TcpListener listener;
        List<ClientInfo> clients;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int l = int.Parse(textBox1.Text);
                IPEndPoint lo = new IPEndPoint(IPAddress.Any, l);
                listener = new TcpListener(l);
                listener.Start();
                clients = new List<ClientInfo>();
                timer1.Enabled = true;
                textBox2.AppendText("Порт окрфт" + textBox1.Text + "\r" + "\n");
            }
            catch (Exception ex)
            {
                textBox2.AppendText(ex.Message + "\r" + "\n");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CheckListener();
                for (int i = clients.Count - 1; i >= 0; i--)
                {
                    byte[] data = new byte[client.socket.Available];
                    int data_size = client.socket.Receive(data);
                    string text_data = Encoding.UTF8.GetString(data, 0, data_size);
                    DoClient(client, text_data);
                }
            }
            catch (Exception ex)
            {
                textBox2.AppendText(ex.Message + "\r" + "\n");
            }

        }

        private void CheckListener()
        {
            if (listener.Pending())
            {
                ClientInfo newClient = new ClientInfo();
                newClient.socket = listener.AcceptSocket();
                clients.Add(newClient);
                textBox2.AppendText("Пользовитель" + newClient.socket.RemoteEndPoint + "подключился" + "\r" + "\n");
            }
        }
        private void DoClient(ClientInfo client, string text_data)
        {
            if (text_data.StartsWith("Клиент"))
            {
                client.Neme = text_data.Substring(2);
                listBox1.Items.Add(client);
                SendToClients("Новый клинет" + client.Neme, client);
                textBox2.AppendText("Пользователь" + client.socket.RemoteEndPoint + "с именем" + client.Neme + "\r" + "\n");



            }
            if (text_data =="Отключение")
            {
                SendToClients("Отключение"+ client.Neme, client);
                textBox2.AppendText("Пользователь" + client.socket.RemoteEndPoint + "с именем" + client.Neme + "\r" + "\n");
               client.socket.Shutdown(SocketShutdown.Both);
                client.socket.Close();
                listBox1.Items.Remove(client);
                clients.Remove(client);
            }
            if (text_data.StartsWith("Собщение"))
            {
                string message = text_data.Substring(2);
                SendToClients("Сообщение от клиента" + client.Neme + "\r" + message, client);
                textBox2.AppendText(client.Neme + ":" + message + "\r\n");
            }
            private void SendToClients(string command, ClientInfo exceptOf)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    ClientInfo client = clients[i];
                    if(client != exceptOf) 
                    {
                        try
                        {
                            byte[] data = Encoding.UTF8.GetBytes(command);
                            client.socket.Send(data);
                        }
                        catch(Exception ex)
                        {
                            textBox2.AppendText(ex.Message + "\n");
                        }
                    }
                }
            }





        }
    }
}
