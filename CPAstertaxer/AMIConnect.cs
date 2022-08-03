using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace CPAstertaxer
{
    public class AMIConnect
    {
        public void AMIcon(string server, string DataNum, string Login, string Password)
        {
        // Connect to the asterisk server.
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.69"), 5038);
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(server), 5038);
        clientSocket.Connect(serverEndPoint);

        // Login to the server; manager.conf needs to be setup with matching credentials.
        clientSocket.Send(Encoding.ASCII.GetBytes("Action: Login\r\nUsername:" + Login + "\r\nSecret:" + Password + "\r\nActionID: 1\r\n\r\n"));

        int bytesRead = 0;

            do
            {
                byte[] buffer = new byte[5120];
                bytesRead = clientSocket.Receive(buffer);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (Regex.Match(response, "Message: Authentication accepted", RegexOptions.IgnoreCase).Success)
                {
                    m:
                    bytesRead = 0;
                    clientSocket.Send(Encoding.ASCII.GetBytes("Action: QueueAdd\r\nQueue: queuetax\r\nInterface: Dongle/dongle1/" + DataNum + "\r\n\r\n"));
                    bytesRead = clientSocket.Receive(buffer);
                    string response2 = Encoding.ASCII.GetString(buffer, 0, bytesRead); 

                    if 
                        (Regex.Match(response2, "Message: Added interface to queue", RegexOptions.IgnoreCase).Success)
                        {
                            MessageBox.Show("Tелефон таксиста " + DataNum + " добавлен в очередь \nPhone of agent added to queue");//Message: Unable to add interface
                            bytesRead = 0;
                        }
                    else 
                        if (Regex.Match(response2, "Unable to add interface", RegexOptions.IgnoreCase).Success)
                        {
                            MessageBox.Show("Tелефон таксиста " + DataNum + " уже есть в очереди \nPhone of agent already is queue");//Message: Unable to add interface
                            return;
                        }
                else { goto m; }
                }
            } 
            while(bytesRead != 0);
            byte[] buffer2 = new byte[5120];
            clientSocket.Send(Encoding.ASCII.GetBytes("Action: Logoff\r\nActionID: 1\r\n\r\n"));
            bytesRead = clientSocket.Receive(buffer2);
            string response3 = Encoding.ASCII.GetString(buffer2, 0, bytesRead);

            if (Regex.Match(response3, "Goodbye", RegexOptions.IgnoreCase).Success)
                //MessageBox.Show(response3);
            clientSocket.Close();
        }
    }
}