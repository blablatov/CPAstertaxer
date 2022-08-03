using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace CPAstertaxer
{
    public class WhoQueue
    {
        public string response2;
        public void WhoQue(string server)
        {
        // Connect to the asterisk server.
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.69"), 5038);
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(server), 5038);
        clientSocket.Connect(serverEndPoint);

        // Login to the server; manager.conf needs to be setup with matching credentials.
        clientSocket.Send(Encoding.ASCII.GetBytes("Action: Login\r\nUsername: root\r\nSecret: taxer\r\nActionID: 1\r\n\r\n"));

        int bytesRead = 0;

            do
            {
                byte[] buffer = new byte[10240];
                bytesRead = clientSocket.Receive(buffer);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (Regex.Match(response, "Message: Authentication accepted", RegexOptions.IgnoreCase).Success)
                {
                    //MessageBox.Show(response);
                    m:
                    bytesRead = 0;
                    clientSocket.Send(Encoding.ASCII.GetBytes("Action: Command\r\nCommand: queue show queuetax\r\nActionID: 1\r\n\r\n"));
                    bytesRead = clientSocket.Receive(buffer);
                    response2 = Encoding.ASCII.GetString(buffer, 0, bytesRead); 
                    //MessageBox.Show(response2);

                    if (Regex.Match(response2, "dongle1", RegexOptions.IgnoreCase).Success)
                    {
                        MessageBox.Show("ТАКСИСТЫ В ОЧЕРЕДИ (Agents to queue):\r\n" + response2);
                        bytesRead = 0;
                        //return response2;
                    }
                    else { goto m;}
                }
            } 
            while(bytesRead != 0);
            byte[] buffer2 = new byte[5120];
            clientSocket.Send(Encoding.ASCII.GetBytes("Action: Logoff\r\nActionID: 1\r\n\r\n"));
            //bytesRead = 0;
            bytesRead = clientSocket.Receive(buffer2);
            string response3 = Encoding.ASCII.GetString(buffer2, 0, bytesRead);

            if (Regex.Match(response3, "Goodbye", RegexOptions.IgnoreCase).Success)
                //MessageBox.Show(response3);
            clientSocket.Close();
            //Form1 Res = new Form1();
            //Res.textBoxQueue.Text = response2;
            //return Form1.dataGridViewQueue(response2);
        }
    }
}